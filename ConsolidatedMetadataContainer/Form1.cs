//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2024 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace ConsolidatedMetadataContainer
{
    public partial class Form1 : Form
    {
        // list of connections, name -> innerContext
        private readonly Dictionary<string, SQLContext> _connections = InitConnections();

        // fill connections dictionary
        private static Dictionary<string, SQLContext> InitConnections()
        {
            var result = new Dictionary<string, SQLContext>();

            // first connection
            var innerXml = new SQLContext
            {
                SyntaxProvider = new MSSQLSyntaxProvider(),
            };
            innerXml.MetadataContainer.ImportFromXML("northwind.xml");
            result.Add("xml", innerXml);

            // second connection
            var innerMsSql = new SQLContext
            {
                SyntaxProvider = new MSSQLSyntaxProvider(),
                MetadataProvider = new MSSQLMetadataProvider
                {
                    Connection = new SqlConnection("Server=sql2014;Database=AdventureWorks;User Id=sa;Password=********;"),
                },
                LoadingOptions =
                {
                    LoadDefaultDatabaseOnly = false,
                },
            };
            result.Add("live", innerMsSql);

            return result;
        }

        public Form1()
        {
            InitializeComponent();

            // sql editing events
            queryBuilder.SQLUpdated += QueryBuilderOnSqlUpdated;
            textSql.Validating += TextSqlOnValidating;

            // add connections
            var metadataContainer = queryBuilder.MetadataContainer;
            foreach (var connectionDescription in _connections)
            {
                var name = connectionDescription.Key;
                var innerContext = connectionDescription.Value;
                metadataContainer.AddConnection(name, innerContext);
            }

            // init metadata tree
            queryBuilder.InitializeDatabaseSchemaTree();
        }

        private void TextSqlOnValidating(object sender, CancelEventArgs e)
        {
            queryBuilder.FormattedSQL = textSql.Text;
        }

        private void QueryBuilderOnSqlUpdated(object sender, EventArgs e)
        {
            textSql.Text = queryBuilder.FormattedSQL;
        }

        private void buttonStats_Click(object sender, EventArgs e)
        {
            var result = new StringBuilder();

            // collect all subQueries
            var subQueries = queryBuilder.SQLQuery.QueryRoot.GetChildrenRecursive<SubQuery>(true); ;
            // process main query also
            subQueries.Insert(0, queryBuilder.SQLQuery.QueryRoot);

            // OR collect unionSubQueries (single SELECT expressions)
            //var subQueries = queryBuilder.SQLQuery.QueryRoot.GetChildrenRecursive<UnionSubQuery>(true);

            foreach (var subQuery in subQueries)
            {
                result.AppendLine();
                result.AppendLine("subQuery: " + subQuery.SQL);
                // collect all dataSources in this subQuery
                var dataSources = subQuery.GetChildrenRecursive<DataSourceObject>(false);

                foreach (var dataSource in dataSources)
                {
                    result.AppendLine(dataSource.NameInQuery);

                    var metadataObject = dataSource.MetadataObject;

                    // metadataObject will be null in 2 cases:
                    // 1. dataSource is CTE reference
                    if (dataSource.SubQueryCTE != null)
                    {
                        result.AppendLine("\tCTE reference");
                        continue;
                    }
                    // 2. no object with such name in MetadataContainer
                    if (metadataObject == null)
                    {
                        using (var fullName = new SQLQualifiedName(queryBuilder.SQLContext))
                        {
                            fullName.Assign(dataSource.DatabaseObject);
                            result.AppendLine("\tno such object in DB: " + fullName.GetSQL(queryBuilder.SQLGenerationOptions));
                        }

                        continue;
                    }

                    result.AppendLine("\tobject name: " + metadataObject.GetQualifiedNameSQL(null, queryBuilder.SQLGenerationOptions));
                    result.AppendLine("\tconnection: " + metadataObject.Connection.Name);
                }
            }

            MessageBox.Show(result.ToString());
        }
    }
}
