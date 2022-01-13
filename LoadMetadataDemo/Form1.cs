//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

/********************************************************************************
This sample demonstrates loading of metadata if the standard way (see GeneralDemo)
is not suitable for some reason.
*********************************************************************/

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using GeneralAssembly;

namespace LoadMetadataDemo
{
    public partial class Form1 : Form
    {
        private ConnectionInfo _selectedConnection;

        public Form1()
        {
            InitializeComponent();
        }

        //////////////////////////////////////////////////////////////////////////
        /// 1st way:
        /// This method demonstrates the direct access to the internal metadata 
        /// objects collection (MetadataContainer).
        //////////////////////////////////////////////////////////////////////////
        private void btn1Way_Click(object sender, EventArgs e)
        {
            // prevent QueryBuilder to request metadata
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true;

            queryBuilder1.MetadataProvider = null;

            MetadataContainer metadataContainer = queryBuilder1.MetadataContainer;
            metadataContainer.BeginUpdate();

            try
            {
                metadataContainer.Clear();

                MetadataNamespace schemaDbo = metadataContainer.AddSchema("dbo");

                // prepare metadata for table "Orders"
                MetadataObject orders = schemaDbo.AddTable("Orders");
                // fields
                orders.AddField("OrderId");
                orders.AddField("CustomerId");

                // prepare metadata for table "Order Details"
                MetadataObject orderDetails = schemaDbo.AddTable("Order Details");
                // fields
                orderDetails.AddField("OrderId");
                orderDetails.AddField("ProductId");
                // foreign keys
                MetadataForeignKey foreignKey = orderDetails.AddForeignKey("OrderDetailsToOrders");

                using (MetadataQualifiedName referencedName = new MetadataQualifiedName())
                {
                    referencedName.Add("Orders");
                    referencedName.Add("dbo");

                    foreignKey.ReferencedObjectName = referencedName;
                }

                foreignKey.Fields.Add("OrderId");
                foreignKey.ReferencedFields.Add("OrderId");
            }
            finally
            {
                metadataContainer.EndUpdate();
            }

            queryBuilder1.InitializeDatabaseSchemaTree();
        }

        //////////////////////////////////////////////////////////////////////////
        /// 2rd way:
        /// This method demonstrates on-demand manual filling of metadata structure using 
        /// corresponding MetadataContainer.ItemMetadataLoading event
        //////////////////////////////////////////////////////////////////////////
        private void btn2Way_Click(object sender, EventArgs e)
        {
            // allow QueryBuilder to request metadata
            queryBuilder1.MetadataLoadingOptions.OfflineMode = false;

            queryBuilder1.MetadataProvider = null;
            queryBuilder1.MetadataContainer.ItemMetadataLoading += way2ItemMetadataLoading;
            queryBuilder1.InitializeDatabaseSchemaTree();
        }

        private void way2ItemMetadataLoading(object sender, MetadataItem item, MetadataType types)
        {
            switch (item.Type)
            {
                case MetadataType.Root:
                    if (types.Contains(MetadataType.Schema))
                    {
                        // only one "dbo" schema should be at the root level
                        if (item.Items.FindItem<MetadataNamespace>("dbo", MetadataType.Schema) == null)
                            item.AddSchema("dbo");
                    }
                    break;

                case MetadataType.Schema:
                    if (item.Name == "dbo" && types.Contains(MetadataType.Table))
                    {
                        item.AddTable("Orders");
                        item.AddTable("Order Details");
                    }
                    break;

                case MetadataType.Table:
                    if (item.Name == "Orders")
                    {
                        if (types.Contains(MetadataType.Field))
                        {
                            item.AddField("OrderId");
                            item.AddField("CustomerId");
                        }
                    }
                    else if (item.Name == "Order Details")
                    {
                        if (types.Contains(MetadataType.Field))
                        {
                            item.AddField("OrderId");
                            item.AddField("ProductId");
                        }

                        if (types.Contains(MetadataType.ForeignKey))
                        {
                            MetadataForeignKey foreignKey = item.AddForeignKey("OrderDetailsToOrder");
                            foreignKey.Fields.Add("OrderId");
                            foreignKey.ReferencedFields.Add("OrderId");
                            using (MetadataQualifiedName name = new MetadataQualifiedName())
                            {
                                name.Add("Orders");
                                name.Add("dbo");

                                foreignKey.ReferencedObjectName = name;
                            }
                        }
                    }
                    break;
            }

            item.Items.SetLoaded(types, true);
        }

        //////////////////////////////////////////////////////////////////////////
        /// 3rd way:
        ///
        /// This method demonstrates loading of metadata through .NET data providers 
        /// unsupported by our QueryBuilder component. If such data provider is able 
        /// to execute SQL queries, you can use our EventMetadataProvider with handling 
        /// it's ExecSQL event. In this event the EventMetadataProvider will provide 
        /// you SQL queries it use for the metadata retrieval. You have to execute 
        /// a query and return resulting data reader object.
        ///
        /// Note: In this sample we are using GenericSyntaxProvider that tries 
        /// to detect the the server type automatically. In some conditions it's unable 
        /// to detect the server type and it also has limited syntax parsing abilities. 
        /// For this reason you have to use specific syntax providers in your application, 
        /// e.g. MySQLSyntaxProver, OracleSyntaxProvider, etc.
        //////////////////////////////////////////////////////////////////////////
        private void btn3Way_Click(object sender, EventArgs e)
        {
            var dbConnection = _selectedConnection?.ConnectionDescriptor?.MetadataProvider?.Connection;
            if (dbConnection != null)
            {
                try
                {
                    dbConnection.Close();
                    dbConnection.Open();

                    // allow QueryBuilder to request metadata
                    queryBuilder1.MetadataLoadingOptions.OfflineMode = false;

                    ResetQueryBuilderMetadata();

                    queryBuilder1.MetadataProvider = way3EventMetadataProvider;
                    queryBuilder1.InitializeDatabaseSchemaTree();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "btn3Way_Click()");
                }
            }
            else
            {
                MessageBox.Show("Please setup a database connection by clicking on the \"Connect\" menu item before testing this method.");
            }
        }

        private void way3EventMetadataProvider_ExecSQL(BaseMetadataProvider metadataProvider, string sql, bool schemaOnly, out IDataReader dataReader)
        {
            dataReader = null;

            var dbConnection = _selectedConnection?.ConnectionDescriptor?.MetadataProvider?.Connection;

            if (dbConnection != null)
            {
                IDbCommand command = dbConnection.CreateCommand();
                command.CommandText = sql;
                dataReader = command.ExecuteReader();
            }
        }

        //////////////////////////////////////////////////////////////////////////
        /// 4th way:
        /// This method demonstrates manual filling of metadata structure from 
        /// stored DataSet.
        //////////////////////////////////////////////////////////////////////////
        private void btn4Way_Click(object sender, EventArgs e)
        {
            queryBuilder1.MetadataProvider = null;
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true; // prevent QueryBuilder to request metadata from connection

            DataSet dataSet = new DataSet();

            // Load sample dataset created in the Visual Studio with Dataset Designer
            // and exported to XML using WriteXmlSchema() method.
            dataSet.ReadXmlSchema("StoredDataSetSchema.xml");

            queryBuilder1.MetadataContainer.BeginUpdate();

            try
            {
                queryBuilder1.ClearMetadata();

                // add tables
                foreach (DataTable table in dataSet.Tables)
                {
                    // add new metadata table
                    MetadataObject metadataTable = queryBuilder1.MetadataContainer.AddTable(table.TableName);

                    // add metadata fields (columns)
                    foreach (DataColumn column in table.Columns)
                    {
                        // create new field
                        MetadataField metadataField = metadataTable.AddField(column.ColumnName);
                        // setup field
                        metadataField.FieldType = TypeToDbType(column.DataType);
                        metadataField.Nullable = column.AllowDBNull;
                        metadataField.ReadOnly = column.ReadOnly;

                        if (column.MaxLength != -1)
                        {
                            metadataField.Size = column.MaxLength;
                        }

                        // detect the field is primary key
                        foreach (DataColumn pkColumn in table.PrimaryKey)
                        {
                            if (column == pkColumn)
                            {
                                metadataField.PrimaryKey = true;
                            }
                        }
                    }

                    // add relations
                    foreach (DataRelation relation in table.ParentRelations)
                    {
                        // create new relation on the parent table
                        MetadataForeignKey metadataRelation = metadataTable.AddForeignKey(relation.RelationName);

                        // set referenced table
                        using (MetadataQualifiedName referencedName = new MetadataQualifiedName())
                        {
                            referencedName.Add(relation.ParentTable.TableName);

                            metadataRelation.ReferencedObjectName = referencedName;
                        }

                        // set referenced fields
                        foreach (DataColumn parentColumn in relation.ParentColumns)
                        {
                            metadataRelation.ReferencedFields.Add(parentColumn.ColumnName);
                        }

                        // set fields
                        foreach (DataColumn childColumn in relation.ChildColumns)
                        {
                            metadataRelation.Fields.Add(childColumn.ColumnName);
                        }
                    }
                }
            }
            finally
            {
                queryBuilder1.MetadataContainer.EndUpdate();
            }

            queryBuilder1.InitializeDatabaseSchemaTree();
        }


        // =============================================================================


        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            QueryBuilder.ShowAboutDialog();
        }

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
        {
            // Handle the event raised by SQL builder object that the text of SQL query is changed

            // Hide error banner if any
            ShowErrorBanner(textBox1, "");

            // update the text box
            textBox1.Text = queryBuilder1.FormattedSQL;
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
                queryBuilder1.SQL = textBox1.Text;

                // Hide error banner if any
                ShowErrorBanner(textBox1, "");
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                textBox1.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                ShowErrorBanner(textBox1, ex.Message);
            }
        }

        private static DbType TypeToDbType(Type type)
        {
            if (type == typeof (string)) return DbType.String;
            if (type == typeof (System.Int16)) return DbType.Int16;
            if (type == typeof (System.Int32)) return DbType.Int32;
            if (type == typeof (System.Int64)) return DbType.Int64;
            if (type == typeof (System.UInt16)) return DbType.UInt16;
            if (type == typeof (System.UInt32)) return DbType.UInt32;
            if (type == typeof (System.UInt64)) return DbType.UInt64;
            if (type == typeof (System.Boolean)) return DbType.Boolean;
            if (type == typeof (System.Single)) return DbType.Single;
            if (type == typeof (System.Double)) return DbType.Double;
            if (type == typeof (System.Decimal)) return DbType.Decimal;
            if (type == typeof (System.DateTime)) return DbType.DateTime;
            if (type == typeof (System.TimeSpan)) return DbType.Time;
            if (type == typeof (System.Byte)) return DbType.Byte;
            if (type == typeof (System.SByte)) return DbType.SByte;
            if (type == typeof (System.Char)) return DbType.String;
            if (type == typeof (System.Byte[])) return DbType.Binary;
            if (type == typeof (System.Guid)) return DbType.Guid;
            return DbType.Object;
        }

        private void ResetQueryBuilderMetadata()
        {
            queryBuilder1.MetadataProvider = null;
            queryBuilder1.ClearMetadata();
            queryBuilder1.MetadataContainer.ItemMetadataLoading -= way2ItemMetadataLoading;
        }

        public void ShowErrorBanner(Control control, String text)
        {
            // Destory banner if already showing
            {
                bool existBanner = false;
                Control[] banners = control.Controls.Find("ErrorBanner", true);

                if (banners.Length > 0)
                {
                    foreach (Control banner in banners)
                    {
                        if(Equals(text, banner.Text)) 
                        {
                            existBanner = true;
                            continue;
                        }
                        banner.Dispose();
                    }
                }

                if(existBanner) return;
            }

            // Show new banner if text is not empty
            if (!String.IsNullOrEmpty(text))
            {
                Label label = new Label
                {
                    Name = "ErrorBanner",
                    Text = text,
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.LightPink,
                    AutoSize =  true,
                    Visible = true
                };

                control.Controls.Add(label);
                label.Location = new Point(control.Width - label.Width - SystemInformation.VerticalScrollBarWidth - 6, 2);
                label.BringToFront();
                
                control.Focus();
            }
        }

        private void menuItemConnect_Click(object sender, EventArgs e)
        {
            var cf = new ConnectionForm() { Owner = this };

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
            finally
            {

               
            }
        }
    }
}
