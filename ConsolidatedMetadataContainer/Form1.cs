﻿//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
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
    }
}
