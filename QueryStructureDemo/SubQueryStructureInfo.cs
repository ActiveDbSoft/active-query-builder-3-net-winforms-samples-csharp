//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections;
using System.Diagnostics;
using System.Text;
using ActiveQueryBuilder.Core;

namespace QueryStructureDemo
{
    partial class Form1
    {
        private void DumpUnionGroupInfo(StringBuilder stringBuilder, string indent, UnionGroup unionGroup)
        {
            foreach (QueryBase child in unionGroup.Items)
            {
                if (stringBuilder.Length > 0)
                {
                    stringBuilder.AppendLine();
                }

                if (child is UnionSubQuery)
                {
                    // UnionSubQuery is a leaf node of query structure.
                    // It represent a single SELECT statement in the tree of unions
                    DumpUnionSubQueryInfo(stringBuilder, indent, (UnionSubQuery) child);
                }
                else
                {
                    // UnionGroup is a tree node.
                    // It contains one or more leafs of other tree nodes.
                    // It represent a root of the subquery of the union tree or a
                    // parentheses in the union tree.
                    Debug.Assert(child is UnionGroup);

                    unionGroup = (UnionGroup) child;

                    stringBuilder.AppendLine(indent + unionGroup.UnionOperatorFull + "group: [");
                    DumpUnionGroupInfo(stringBuilder, indent + "    ", unionGroup);
                    stringBuilder.AppendLine(indent + "]");
                }
            }
        }

        private void DumpUnionSubQueryInfo(StringBuilder stringBuilder, string indent, UnionSubQuery unionSubQuery)
        {
            string sql = unionSubQuery.GetResultSQL();

            stringBuilder.AppendLine(indent + unionSubQuery.UnionOperatorFull + ": " + sql);
        }

        public void DumpQueryStructureInfo(StringBuilder stringBuilder, SubQuery subQuery)
        {
            DumpUnionGroupInfo(stringBuilder, "", subQuery);
        }
    }
}
