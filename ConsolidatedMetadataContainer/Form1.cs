//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace ConsolidatedMetadataContainer
{
    public partial class Form1 : Form
    {
        private readonly QueryBuilder _aqb;
        private readonly Dictionary<string, SQLContext> _connections = new Dictionary<string, SQLContext>();
        private readonly Dictionary<MetadataItem, MetadataItem> _consolidatedToInner = new Dictionary<MetadataItem, MetadataItem>();
        private readonly Dictionary<MetadataItem, MetadataItem> _innerToConsolidated = new Dictionary<MetadataItem, MetadataItem>();

        public Form1()
        {
            InitializeComponent();

            // first connection
            var xmlNorthwind = new SQLContext
            {
                SyntaxProvider = new MSSQLSyntaxProvider(),
            };
            xmlNorthwind.MetadataContainer.ImportFromXML("northwind.xml");
            _connections.Add("xml", xmlNorthwind);

            // second connection
            var mssqlAdventureWorks = new SQLContext
            {
                SyntaxProvider = new MSSQLSyntaxProvider(),
                MetadataProvider = new MSSQLMetadataProvider
                {
                    Connection = new SqlConnection("Server=sql2014;Database=AdventureWorks;User Id=sa;Password=********;"),
                },
            };
            _connections.Add("live", mssqlAdventureWorks);

            // QueryBuilder with consolidated metadata
            _aqb = new QueryBuilder()
            {
                SyntaxProvider = new SQL2003SyntaxProvider(),
                Dock = DockStyle.Fill,
                Parent = this,
            };

            _aqb.MetadataContainer.ItemMetadataLoading += MetadataContainerOnItemMetadataLoading;

            _aqb.InitializeDatabaseSchemaTree();
        }

        private void MetadataContainerOnItemMetadataLoading(object sender, MetadataItem item, MetadataType loadtypes)
        {
            // root of consolidated metadata contains connections
            if (item == _aqb.MetadataContainer && loadtypes.Contains(MetadataType.Connection))
            {
                // add connections (as virtual "connection" objects)
                foreach (var connectionDescription in _connections)
                {
                    var connectionName = connectionDescription.Key;
                    var connection = connectionDescription.Value;
                    var innerItem = connection.MetadataContainer;

                    if (_innerToConsolidated.ContainsKey(innerItem))
                        continue;

                    var newItem = item.AddConnection(connectionName);
                    newItem.Items = innerItem.Items;

                    MapConsolidatedToInnerRecursive(newItem, innerItem);
                }

                return;
            }

            // find "inner" item, load it's children and copy them to consolidated container
            {
                var innerItem = _consolidatedToInner[item];
                innerItem.Items.Load(loadtypes, false);

                foreach (var childItem in innerItem.Items)
                {
                    if (!loadtypes.Contains(childItem.Type))
                        continue;

                    if (_innerToConsolidated.ContainsKey(childItem))
                        continue;

                    var newItem = childItem.Clone(item.Items);
                    item.Items.Add(newItem);

                    MapConsolidatedToInnerRecursive(newItem, childItem);
                }
            }
        }

        private void MapConsolidatedToInnerRecursive(MetadataItem consolidated, MetadataItem inner)
        {
            _consolidatedToInner.Add(consolidated, inner);
            _innerToConsolidated.Add(inner, consolidated);

            for (var i = 0; i < inner.Items.Count; i++)
                MapConsolidatedToInnerRecursive(consolidated.Items[i], inner.Items[i]);
        }
    }
}
