//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2023 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace AppendCriteriaStringDemo
{
    public partial class Form1 : Form
    {
        private const string SampleSQL =
            "select Count(o.OrderId) " +
            "from Orders o " +
            "where 1 = 1 " +
            "Group By Count(o.CustomerId) " +
            "union all " +
            "select 1 " +
            "from Orders o " +
            "where 2 = 2";

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // don't query issue additional queries
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true;

            // load sample query into internal query builder
            queryBuilder1.SQL = SampleSQL;
        }

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
        {
            textBoxQuery.Text = queryBuilder1.FormattedSQL;
        }
        
        private void buttonClearWhere_Click(object sender, EventArgs e)
        {
            // get reference to first UnionSubQuery of the Main query
            UnionSubQuery usq = queryBuilder1.SQLQuery.QueryRoot.FirstSelect();

            ClearWhere(usq);
        }

        private void buttonAppend_Click(object sender, EventArgs e)
        {
            // get reference to first UnionSubQuery of the Main query
            UnionSubQuery usq = queryBuilder1.SQLQuery.QueryRoot.FirstSelect();

            AppendWhere(usq, textBoxNewWhere.Text);
        }

        private void buttonReplaceWhere_Click(object sender, EventArgs e)
        {
            // get reference to first UnionSubQuery of the Main query
            UnionSubQuery usq = queryBuilder1.SQLQuery.QueryRoot.FirstSelect();

            ReplaceWhere(usq, textBoxNewWhere.Text);
        }

        private void buttonReplaceWhereAccess_Click(object sender, EventArgs e)
        {
            // get reference to first UnionSubQuery of the Main query
            UnionSubQuery usq = queryBuilder1.SQLQuery.QueryRoot.FirstSelect();

            ReplaceWhereAccess(usq, textBoxNewWhereAccess.Text);
        }

        private void buttonReplaceWhereAll_Click(object sender, EventArgs e)
        {
            // get reference to the main query
            SubQuery query = queryBuilder1.SQLQuery.QueryRoot;

            ReplaceWhereAll(query, textBoxNewWhereAccess.Text);
        }

        private void ClearWhere(UnionSubQuery unionSubQuery)
        {
            // get reference to QueryColumnList
            QueryColumnList cl = unionSubQuery.QueryColumnList;

            // disable SQL updating for QueryBuilder
            queryBuilder1.BeginUpdate();

            try
            {
                // clear old Where
                for (int i = 0; i < cl.Count; i++)
                {
                    QueryColumnListItem ci = cl[i];

                    if (ci.ConditionType == ConditionType.Where)
                    {
                        // clear all WHERE expressions in a row
                        for (int j = 0; j < ci.ConditionCount; j++)
                        {
                            ci.ConditionStrings[j] = "";
                        }
                    }
                }
            }
            finally
            {
                queryBuilder1.EndUpdate();
            }
        }

        private void AppendWhere(UnionSubQuery unionSubQuery, string newWhereStr)
        {
            SQLExpressionAnd resultWhere;

            // parse and prepare new WHERE expression
            SQLExpressionItem newWhere = ParseExpression(newWhereStr);

            // if there are no new expression - nothing to do
            if (newWhere == null)
            {
                return;
            }

            // extract old WHERE expression
            SQLExpressionItem oldWhere = unionSubQuery.QueryColumnList.GetConditionTree(new[] { ConditionType.Where });

            // normalize old WHERE expression
            if (oldWhere != null)
            {
                oldWhere.RestoreColumnPrefixRecursive(true);
            }

            // simplify old WHERE expression
            if (oldWhere != null)
            {
                // if old WHERE is a collection of ORed or ANDed expressions
                // with only one expression in the list - remove the external list
                while (oldWhere is SQLExpressionLogicalCollection &&
                       ((SQLExpressionLogicalCollection) oldWhere).Count == 1)
                {
                    using (SQLExpressionLogicalCollection tmp = (SQLExpressionLogicalCollection) oldWhere)
                    {
                        oldWhere = tmp.Extract(0);
                    }
                }
            }

            // combine old and new WHERE expressions
            resultWhere = new SQLExpressionAnd(queryBuilder1.SQLContext);

            if (oldWhere != null)
            {
                resultWhere.Add(oldWhere);
            }

            resultWhere.Add(newWhere);

            // fix up combined WHERE expression
            FixupExpression(unionSubQuery, resultWhere);

            // defer SQL updates
            unionSubQuery.BeginUpdate();

            try
            {
                // clear old WHERE expression
                ClearWhere(unionSubQuery);

                // load new WHERE expression (if exists)
                unionSubQuery.QueryColumnList.LoadConditionFromAST(resultWhere, ConditionType.Where);
            }
            finally
            {
                // enable SQL updates
                unionSubQuery.EndUpdate();
            }
        }

        private void ReplaceWhere(UnionSubQuery unionSubQuery, string newWhereStr)
        {
            // parse and prepare new WHERE expression
            SQLExpressionItem newWhere = ParseExpression(newWhereStr);

            if (newWhere != null)
            {
                FixupExpression(unionSubQuery, newWhere);
            }

            // defer SQL updates
            unionSubQuery.BeginUpdate();

            try
            {
                // clear old WHERE expression
                ClearWhere(unionSubQuery);

                // load new WHERE expression (if exists)
                if (newWhere != null)
                {
                    unionSubQuery.QueryColumnList.LoadConditionFromAST(newWhere, ConditionType.Where);
                }
            }
            finally
            {
                // enable SQL updates
                unionSubQuery.EndUpdate();
            }
        }

        private void ReplaceWhereAccess(UnionSubQuery unionSubQuery, string newWhereStr)
        {
            // parse and prepare new WHERE expression
            SQLExpressionItem newWhere = ParseExpressionAccess(newWhereStr);

            if (newWhere != null)
            {
                FixupExpression(unionSubQuery, newWhere);
                ConvertExpressionConstantsNotation(newWhere);
            }

            // defer SQL updates
            unionSubQuery.BeginUpdate();

            try
            {
                // clear old WHERE expression
                ClearWhere(unionSubQuery);

                // load new WHERE expression (if exists)
                if (newWhere != null)
                {
                    unionSubQuery.QueryColumnList.LoadConditionFromAST(newWhere, ConditionType.Where);
                }
            }
            finally
            {
                // enable SQL updates
                unionSubQuery.EndUpdate();
            }
        }

        private void ReplaceWhereAll(SubQuery subQuery, string newWhere)
        {
            ReplaceWhereInGroup(subQuery, newWhere);
        }

        private void ReplaceWhereInGroup(UnionGroup unionGroup, string newWhere)
        {
            for (int i = 0; i < unionGroup.Count; i++)
            {
                if (unionGroup[i] is UnionGroup)
                {
                    ReplaceWhereInGroup((UnionGroup) unionGroup[i], newWhere);
                }
                else
                {
                    Debug.Assert(unionGroup[i] is UnionSubQuery);
                    ReplaceWhereAccess((UnionSubQuery) unionGroup[i], newWhere);
                }
            }
        }

        private void FixupExpression(QueryElement queryContext, SQLExpressionItem expression)
        {
            Debug.Assert(expression != null);

            List<SQLWithClauseItem> listCTE = new List<SQLWithClauseItem>();
            List<SQLFromSource> listFromSources = new List<SQLFromSource>();

            // fix up names in raw AST in given context
            queryContext.GatherPrepareAndFixupContext(listCTE, listFromSources, true);
            expression.PrepareAndFixupRecursive(listCTE, listFromSources);
        }

        private SQLExpressionItem ParseExpression(string expression)
        {
            // parse expression to get raw AST (Abstract Syntax Tree)
            return queryBuilder1.SQLContext.ParseLogicalExpression(expression);
        }

        private SQLExpressionItem ParseExpressionAccess(string expression)
        {
            SQLContext accessSQLContext = new SQLContext();
            SQLExpressionItem accessExpression;

            try
            {
                // set up context class to use Access syntax
                accessSQLContext.SyntaxProvider = msAccessSyntaxProvider1;

                accessExpression = accessSQLContext.ParseExpression(expression);

                try
                {
                    // clone parsed expression in our default context
                    // this converts identifiers quotation, but leave the same constants notation
                    if (accessExpression != null)
                    {
                        return accessExpression.Clone(queryBuilder1.SQLContext);
                    }
                    else
                    {
                        return null;
                    }
                }
                finally
                {
                    if (accessExpression != null)
                    {
                        accessExpression.Dispose();
                    }
                }
            }
            finally
            {
                accessSQLContext.Dispose();
            }
        }

        private void ConvertExpressionConstantsNotation(SQLExpressionItem expression)
        {
            Debug.Assert(expression != null);

            List<AstNodeBase> astNodes = new List<AstNodeBase>();

            // get all children (and grand[grand...]children) AST nodes as a flat list
            expression.GetMyChildrenRecursive(astNodes);

            // add expression node itself to AST nodes list
            // (to check is the given expression is constant itself)
            astNodes.Add(expression);

            // remove all items from the list except TSQLExpressionConstant
            for (int i = astNodes.Count - 1; i >= 0; i--)
            {
                if (!(astNodes[i] is SQLExpressionConstant))
                {
                    astNodes.RemoveAt(i);
                }
            }

            // for each item in the list
            for (int i = 0; i < astNodes.Count; i++)
            {
                ConvertConstantNotation((SQLExpressionConstant) astNodes[i]);
            }
        }

        // internal procedure to convert single constant
        private void ConvertConstantNotation(SQLExpressionConstant constant)
        {
            string oldString = constant.GetSQL();

            // convert DATE representation
            if (oldString.Length > 0 && oldString[0] == '#')
            {
                string newString = oldString.Replace('#', '\'');
                constant.Clear();
                constant.AddString(newString);
            }
        }
    }
}
