//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using GeneralAssembly;
using GeneralAssembly.Forms.QueryInformationForms;
using GeneralAssembly.QueryBuilderProperties;
using BuildInfo = ActiveQueryBuilder.Core.BuildInfo;

namespace BasicDemo
{
    public partial class Form1 : Form
    {
        private int _errorPosition = -1;
        private string _lastValidSql;

        public Form1()
        {
            InitializeComponent();

            Icon = ResourceHelpers.GetResourceIcon("App");

            // DEMO WARNING
            if (BuildInfo.GetEdition() == BuildInfo.Edition.Trial)
            {
                Panel trialNoticePanel = new Panel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    BackColor = Color.LightGreen,
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Top,
                    Padding = new Padding(6, 5, 3, 0),
                };

                Label label = new Label
                {
                    AutoSize = true,
                    Margin = new Padding(0),
                    Text = @"Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.",
                    Dock = DockStyle.Fill,
                    UseCompatibleTextRendering = true
                };

                var buttonClose = new PictureBox
                {
                    Image = GeneralAssembly.Properties.Resources.cancel, SizeMode = PictureBoxSizeMode.AutoSize, Cursor = Cursors.Hand
                };
                buttonClose.Click += delegate { Controls.Remove(trialNoticePanel); };

                trialNoticePanel.Controls.Add(buttonClose);

                trialNoticePanel.Resize += delegate
                {
                    buttonClose.Location = new Point(trialNoticePanel.Width - buttonClose.Width - 10,
                        trialNoticePanel.Height / 2 - buttonClose.Height / 2);
                };

                trialNoticePanel.Controls.Add(label);
                Controls.Add(trialNoticePanel);

                Controls.SetChildIndex(trialNoticePanel, 2);
            }

            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load -= Form1_Load;
            queryBuilder1.SyntaxProvider = genericSyntaxProvider1;
            queryBuilder1.SQLQuery.QueryRoot.AllowSleepMode = true;
        }

        private void refreshMetadataMenuItem_Click(object sender, EventArgs e)
        {
            // Force the query builder to refresh metadata from current connection
            // to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

            if (queryBuilder1.MetadataProvider != null && queryBuilder1.MetadataProvider.Connected)
            {
                queryBuilder1.ClearMetadata();
                queryBuilder1.InitializeDatabaseSchemaTree();
            }
        }

        private void editMetadataMenuItem_Click(object sender, EventArgs e)
        {
            // Open the metadata container editor
            QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext);
        }

        private void clearMetadataMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the metadata
            if (MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                queryBuilder1.ClearMetadata();
            }
        }

        private void loadMetadataFromXMLMenuItem_Click(object sender, EventArgs e)
        {
            // Load metadata from XML file
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
            if (queryBuilder1.SyntaxProvider == null)
                queryBuilder1.SyntaxProvider = genericSyntaxProvider1;
            queryBuilder1.MetadataContainer.ImportFromXML(openFileDialog.FileName);
            queryBuilder1.InitializeDatabaseSchemaTree();
        }

        private void saveMetadataToXMLMenuItem_Click(object sender, EventArgs e)
        {
            // Save metadata to XML file
            saveFileDialog.FileName = "Metadata.xml";

            if (saveFileDialog.ShowDialog() != DialogResult.OK) return;

            queryBuilder1.MetadataContainer.LoadAll(true);
            queryBuilder1.MetadataContainer.ExportToXML(saveFileDialog.FileName);
        }

        private void aboutMenuItem_Click(object sender, EventArgs e)
        {
            QueryBuilder.ShowAboutDialog();
        }

        private void queryBuilder_SQLUpdated(object sender, EventArgs e)
        {
            // Handle the event raised by SQL Builder object that the text of SQL query is changed
            
            // Hide error banner if any
            errorBox1.Show(null, queryBuilder1.SyntaxProvider);

            // update the text box
            _lastValidSql = textBox1.Text = queryBuilder1.FormattedSQL;

            // Try to execute the query using current database connection:

            if (tabControl1.SelectedTab == tabPageData)
                ExecuteQuery();
        }

        public void ResetQueryBuilder()
        {
            queryBuilder1.ClearMetadata();
            queryBuilder1.MetadataProvider = null;
            queryBuilder1.SyntaxProvider = null;
            queryBuilder1.MetadataLoadingOptions.OfflineMode = false;
        }

        private void fillProgrammaticallyMenuItem_Click(object sender, EventArgs e)
        {
            ResetQueryBuilder();

            // Fill the query builder metadata programmatically
                
            // setup the query builder with metadata and syntax providers
            queryBuilder1.SyntaxProvider = genericSyntaxProvider1;
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true; // prevent querying obejects from database

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

            WarnAboutGenericSyntaxProvider(); // show warning (just for demonstration purposes)
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
                queryBuilder1.SQL = textBox1.Text;
                
                // Hide error banner if any
                errorBox1.Show(null, queryBuilder1.SyntaxProvider);
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                textBox1.SelectionStart = ex.ErrorPos.pos;
                _errorPosition = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider);
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            // Move the input focus to the query builder.
            // This will fire Leave event in the text box and update the query builder
            // with modified query text.
            queryBuilder1.Focus();
            Application.DoEvents();

            // Try to execute the query using current database connection:

            if (e.TabPage == tabPageData)
            {
                ExecuteQuery();
            }
        }

        private void ExecuteQuery()
        {
            dataGridView1.FillDataGrid(queryBuilder1.SQL);
        }

        private ConnectionInfo _selectedConnection;

        private void propertiesMenuItem_Click(object sender, EventArgs e)
        {
            // Show Properties form
            using (QueryBuilderPropertiesForm f = new QueryBuilderPropertiesForm(queryBuilder1))
            {
                f.ShowDialog();
            }

            WarnAboutGenericSyntaxProvider(); // show warning (just for demonstration purposes)
        }

        private void queryStatisticsMenuItem_Click(object sender, EventArgs e)
        {
            QueryStatistics queryStatistics = queryBuilder1.QueryStatistics;
            StringBuilder builder = new StringBuilder();

            builder.Append("Used Objects (").Append(queryStatistics.UsedDatabaseObjects.Count).AppendLine("):");
            builder.AppendLine();

            for (int i = 0; i < queryStatistics.UsedDatabaseObjects.Count; i++)
                builder.AppendLine(queryStatistics.UsedDatabaseObjects[i].ObjectName.QualifiedName);

            builder.AppendLine().AppendLine();
            builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):");
            builder.AppendLine();

            for (int i = 0; i < queryStatistics.UsedDatabaseObjectFields.Count; i++)
                builder.AppendLine(queryStatistics.UsedDatabaseObjectFields[i].FullName.QualifiedName);

            builder.AppendLine().AppendLine();
            builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):");
            builder.AppendLine();

            for (int i = 0; i < queryStatistics.OutputColumns.Count; i++)
                builder.AppendLine(queryStatistics.OutputColumns[i].Expression);

            using (QueryStatisticsForm f = new QueryStatisticsForm())
            {
                f.textBox.Text = builder.ToString();
                f.ShowDialog();
            }
        }

        // show warning (just for demonstration purposes)

        private void WarnAboutGenericSyntaxProvider()
        {
            if (queryBuilder1.SyntaxProvider is GenericSyntaxProvider)
            {
                panel1.Visible = true;

                // setup the panel to hide automatically
                Timer timer = new Timer();
                timer.Tick += TimerEvent;
                timer.Interval = 10000;
                timer.Start();
            }
        }

        private void TimerEvent(object source, EventArgs args)
        {
            panel1.Visible = false;
            ((Timer) source).Stop();
            ((Timer) source).Dispose();
        }

        private void queryBuilder1_QueryAwake(QueryRoot sender, ref bool abort)
        {
            if (MessageBox.Show(@"You had typed something that is not a SELECT statement in the text editor and continued with visual query building." +
                                @"Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", @"Active Query Builder .NET Demo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        private void queryBuilder1_SleepModeChanged(object sender, EventArgs e)
        {
            labelSleepMode.Visible = queryBuilder1.SleepMode;
            tabPageData.Enabled = !queryBuilder1.SleepMode;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            errorBox1.Visible = false;
        }

        private void errorBox1_SyntaxProviderChanged(object sender, EventArgs e)
        {
            var oldSql = textBox1.Text;
            queryBuilder1.SyntaxProvider = errorBox1.CurrentSyntaxProvider;
            textBox1.Text = oldSql;
            textBox1.SelectionLength = 0;
            errorBox1.Visible = false;
            textBox1.Focus();
        }

        private void errorBox1_GoToErrorPositionEvent(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox1.SelectionStart = _errorPosition;
                textBox1.SelectionLength = 0;
                textBox1.ScrollToCaret();
            }

            textBox1.Focus();
        }

        private void errorBox1_RevertValidTextEvent(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidSql;
            textBox1.Focus();
        }

        private void ConnectTo_Click(object sender, EventArgs e)
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

                dataGridView1.SqlQuery = queryBuilder1.SQLQuery;
            }
        }
    }
}
