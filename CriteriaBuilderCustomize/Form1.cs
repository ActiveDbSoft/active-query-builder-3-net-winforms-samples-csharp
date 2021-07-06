//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.CriteriaBuilder;
using ActiveQueryBuilder.View.CriteriaBuilder.CustomEditors;
using CriteriaBuilderCustomize.CustomControls;
using GeneralAssembly;

namespace CriteriaBuilderCustomize
{
    public partial class Form1 : Form
    {
        private readonly BaseSyntaxProvider _genericSyntaxProvider = new MSSQLSyntaxProvider();
        private ConnectionInfo _selectedConnection;

        public Form1()
        {
            InitializeComponent();
            criteriaBuilder1.QueryTransformer = new QueryTransformer { Query = queryBuilder1.SQLQuery };

            criteriaBuilder1.NeedEditorForValue += CriteriaBuilderOnNeedEditorForValue;
            criteriaBuilder1.NeedCustomLookupButton += CriteriaBuilderOnNeedCustomLookupButton;
            criteriaBuilder1.NeedCustomLookupControl += CriteriaBuilderOnNeedCustomLookupControl;
        }

        private ICriteriaBuilderCustomLookupControl CriteriaBuilderOnNeedCustomLookupControl(object sender, CPoint location)
        {
            if (checkBoxList.Checked == false) return null;
            return new CustomLookupControl {Location = location};
        }

        private ICriteriaBuilderCustomLookupButton CriteriaBuilderOnNeedCustomLookupButton(object sender, CRectangle bounds)
        {
            if (checkBoxButton.Checked == false) return null;
            return new CustomLookupButton
                {Bounds = new Rectangle((int) bounds.X, (int) bounds.Y, (int) bounds.Width, (int) bounds.Height)};
        }

        private ICriteriaBuilderCustomEditor CriteriaBuilderOnNeedEditorForValue(object sender,
            KindOfType kindTypeContent, MetadataField metadataField, CRectangle bounds)
        {
            if (checkBoxEditor.Checked == false) return null;

            return new CustomEditor  {Bounds = bounds};
        }

        private void textBoxSql_Validated(object sender, EventArgs e)
        {
            try
            {
                queryBuilder1.SQL = textBoxSql.Text;
            }
            catch
            {
                //ignore
            }
        }

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
        {
            textBoxSql.Text = queryBuilder1.FormattedSQL;
        }

        private void connectToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cf = new ConnectionForm { Owner = this };

            if (cf.ShowDialog() != DialogResult.OK) return;

            _selectedConnection = cf.SelectedConnection;

            InitializeSqlContext();
        }

        private void InitializeSqlContext()
        {
            try
            {
                queryBuilder1.Clear();

                BaseMetadataProvider metadataProvider = null;

                if (_selectedConnection == null) return;

                // create new SqlConnection object using the connections string from the connection form
                if (!_selectedConnection.IsXmlFile)
                    metadataProvider = _selectedConnection.ConnectionDescriptor?.MetadataProvider;

                // setup the query builder with metadata and syntax providers
                queryBuilder1.SQLContext.MetadataContainer.Clear();
                queryBuilder1.MetadataProvider = metadataProvider;
                queryBuilder1.SyntaxProvider = _selectedConnection.ConnectionDescriptor?.SyntaxProvider;
                queryBuilder1.MetadataLoadingOptions.OfflineMode = metadataProvider == null;

                if (metadataProvider == null)
                {
                    queryBuilder1.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString);
                }

                // Instruct the query builder to fill the database schema tree
                queryBuilder1.InitializeDatabaseSchemaTree();

            }
            catch
            {
                //ignore
            }
        }

        private void fillTheQueryBuilderProgrammaticallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetQueryBuilder();

            // Fill the query builder metadata programmatically

            // setup the query builder with metadata and syntax providers
            queryBuilder1.SyntaxProvider = _genericSyntaxProvider;
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true; // prevent querying objects from database

            // create database and schema
            MetadataNamespace database = queryBuilder1.MetadataContainer.AddDatabase("MyDB");
            database.Default = true;
            MetadataNamespace schema = database.AddSchema("MySchema");
            schema.Default = true;

            // create table
            MetadataObject tableOrders = schema.AddTable("Orders");
            tableOrders.AddField("OrderID");
            tableOrders.AddField("OrderDate");
            tableOrders.AddField("CustomerID");
            tableOrders.AddField("ResellerID");

            // create another table
            MetadataObject tableCustomers = schema.AddTable("Customers");
            tableCustomers.AddField("CustomerID");
            tableCustomers.AddField("CustomerName");
            tableCustomers.AddField("CustomerAddress");

            // add a relation between these two tables
            MetadataForeignKey relation = tableCustomers.AddForeignKey("FK_CustomerID");
            relation.Fields.Add("CustomerID");
            relation.ReferencedObjectName = tableOrders.GetQualifiedName();
            relation.ReferencedFields.Add("CustomerID");

            //create view
            MetadataObject viewResellers = schema.AddView("Resellers");
            viewResellers.AddField("ResellerID");
            viewResellers.AddField("ResellerName");

            // kick the query builder to fill metadata tree
            queryBuilder1.InitializeDatabaseSchemaTree();
        }

        public void ResetQueryBuilder()
        {
            queryBuilder1.ClearMetadata();
            queryBuilder1.MetadataProvider = null;
            queryBuilder1.SyntaxProvider = null;
            queryBuilder1.MetadataLoadingOptions.OfflineMode = false;
        }
    }
}
