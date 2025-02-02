//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;
using GeneralAssembly;
using GeneralAssembly.Forms.QueryInformationForms;


namespace SubQueryResultsPreview
{
    public partial class Form1 : Form
    {
        private int _errorPosition = -1;
        private string _lastValidSql;
        private ConnectionInfo _selectedConnection;

        public Form1()
        {
            InitializeComponent();

            queryBuilder.SyntaxProvider = new MSSQLSyntaxProvider();

            // Set a demo query
            queryBuilder.SQL = "Select Orders.OrderID, Orders.CustomerID, Orders.EmployeeID, Query1.Subtotal From Orders Inner Join (Select [Order Subtotals].Subtotal, [Order Subtotals].OrderID From [Order Subtotals]) Query1 On Query1.OrderID = Orders.OrderID Union Select [Orders Qry].OrderID, [Orders Qry].CustomerID, [Orders Qry].EmployeeID, Query2.Quantity * Query2.UnitPrice From [Orders Qry] Inner Join (Select [Order Details].OrderID, [Order Details].Quantity, [Order Details].UnitPrice From [Order Details]) Query2 On Query2.OrderID = [Orders Qry].OrderID Where ([Orders Qry].OrderID > 100) Or ([Orders Qry].OrderID < 1000)";
        }

        private void queryBuilder_SQLUpdated(object sender, EventArgs e)
        {
            // Hide error banner if any
            errorBox1.Show(null, queryBuilder.SyntaxProvider);

            QueryPartChanged(sender, e);
            //textBox1.Text =  queryBuilder.FormattedSQL;

            if (tabControl1.SelectedTab == tabPageResultsPreview)
                UpdateResultsGrid();
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Update the target query part with manually edited query text:
                queryBuilder.SQL = textBox1.Text;

                // Hide error banner if any
                errorBox1.Show(null, queryBuilder.SyntaxProvider);
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                _errorPosition = textBox1.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, queryBuilder.SyntaxProvider);
            }
        }

        private void QueryPartChanged(object sender, EventArgs e)
        {
            if (Disposing || queryBuilder.ActiveUnionSubQuery == null) return;

            if (rbQuery.Checked)
            {
                _lastValidSql = textBox1.Text = new SQLFormattingOptions(new SQLGenerationOptions()).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
            }
            else if (rbSubQuery.Checked)
            {
                _lastValidSql = textBox1.Text = new SQLFormattingOptions(new SQLGenerationOptions()).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.ParentSubQuery);
            }
            else if (rbUnionSubQuery.Checked)
            {
                _lastValidSql = textBox1.Text = new SQLFormattingOptions(new SQLGenerationOptions()).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery);
            }
        }

        public void ResetQueryBuilder()
        {
            queryBuilder.Clear();
            queryBuilder.MetadataProvider = null;
            queryBuilder.SyntaxProvider = null;
            queryBuilder.MetadataLoadingOptions.OfflineMode = false;
        }


        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            // Move the input focus to the query builder.
            // This will cause the validation in the text box and update the query builder with modified query text.
            queryBuilder.Focus();
            Application.DoEvents();

            UpdateResultsGrid();
        }

        private void UpdateResultsGrid()
        {
            // Check database connection
            if (queryBuilder.MetadataProvider == null || queryBuilder.MetadataProvider.Connection == null)
            {
                Label label = new Label();
                label.Text = "You should connect a database";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                dataGridView1.Controls.Add(label);
            }
            else if (queryBuilder.SQL.Length == 0) // check the query text is not empty
            {
                Label label = new Label();
                label.Text = "No query to execute";
                label.TextAlign = ContentAlignment.MiddleCenter;
                label.Dock = DockStyle.Fill;
                dataGridView1.Controls.Add(label);
            }
            else
                dataGridView1.Controls.Clear();

            var queryToExecute = "";

            // Limit query results to 10 rows for preview purposes
            
                //queryBuilder.SQLContext.LoadingOptions.OfflineMode = true;
                //queryBuilder.SQLContext.SyntaxProvider = queryBuilder.SyntaxProvider;
                //queryBuilder.SQLContext.MetadataProvider = queryBuilder.MetadataProvider;

                //var query = new SQLQuery(sqlContext) {SQL = queryToExecute};

                //tempQueryBuilder.SQL = queryToExecute;

                using (QueryTransformer queryTransformer = new QueryTransformer())
                {
                    queryTransformer.Query = queryBuilder.QueryView.Query;
                    queryTransformer.ResultCount = "10"; // select top 10 rows only
                    queryToExecute = queryTransformer.SQL;
                }
            
            // Try to execute the query using current database connection:

            if (tabControl1.SelectedTab == tabPageResultsPreview)
            {
                dataGridView1.DataSource = null;

                if (queryBuilder.MetadataProvider != null && queryBuilder.MetadataProvider.Connected)
                {
                    if (queryBuilder.MetadataProvider is MSSQLMetadataProvider)
                    {
                        SqlCommand command = (SqlCommand) queryBuilder.MetadataProvider.Connection.CreateCommand();
                        command.CommandText = queryToExecute;

                        // handle the query parameters
                        if (queryBuilder.Parameters.Count > 0)
                        {
                            for (int i = 0; i < queryBuilder.Parameters.Count; i++)
                            {
                                if (!command.Parameters.Contains(queryBuilder.Parameters[i].FullName))
                                {
                                    SqlParameter parameter = new SqlParameter();
                                    parameter.ParameterName = queryBuilder.Parameters[i].FullName;
                                    parameter.DbType = queryBuilder.Parameters[i].DataType;
                                    command.Parameters.Add(parameter);
                                }
                            }

                            using (QueryParametersForm qpf = new QueryParametersForm(command))
                            {
                                qpf.ShowDialog();
                            }
                        }

                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataSet dataset = new DataSet();

                        try
                        {
                            adapter.Fill(dataset, "QueryResult");
                            dataGridView1.DataSource = dataset.Tables["QueryResult"];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "SQL query error");
                        }
                    }
                    else if (queryBuilder.MetadataProvider is OLEDBMetadataProvider)
                    {
                        OleDbCommand command = (OleDbCommand) queryBuilder.MetadataProvider.Connection.CreateCommand();
                        command.CommandText = queryToExecute;

                        // handle the query parameters
                        if (queryBuilder.Parameters.Count > 0)
                        {
                            for (int i = 0; i < queryBuilder.Parameters.Count; i++)
                            {
                                if (!command.Parameters.Contains(queryBuilder.Parameters[i].FullName))
                                {
                                    OleDbParameter parameter = new OleDbParameter();
                                    parameter.ParameterName = queryBuilder.Parameters[i].FullName;
                                    parameter.DbType = queryBuilder.Parameters[i].DataType;
                                    command.Parameters.Add(parameter);
                                }
                            }

                            using (QueryParametersForm qpf = new QueryParametersForm(command))
                            {
                                qpf.ShowDialog();
                            }
                        }

                        OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                        DataSet dataset = new DataSet();

                        try
                        {
                            adapter.Fill(dataset, "QueryResult");
                            dataGridView1.DataSource = dataset.Tables["QueryResult"];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "SQL query error");
                        }
                    }
                    else if (queryBuilder.MetadataProvider is ODBCMetadataProvider)
                    {
                        OdbcCommand command = (OdbcCommand) queryBuilder.MetadataProvider.Connection.CreateCommand();
                        command.CommandText = queryToExecute;

                        // handle the query parameters
                        if (queryBuilder.Parameters.Count > 0)
                        {
                            for (int i = 0; i < queryBuilder.Parameters.Count; i++)
                            {
                                if (!command.Parameters.Contains(queryBuilder.Parameters[i].FullName))
                                {
                                    OdbcParameter parameter = new OdbcParameter();
                                    parameter.ParameterName = queryBuilder.Parameters[i].FullName;
                                    parameter.DbType = queryBuilder.Parameters[i].DataType;
                                    command.Parameters.Add(parameter);
                                }
                            }

                            using (QueryParametersForm qpf = new QueryParametersForm(command))
                            {
                                qpf.ShowDialog();
                            }
                        }

                        OdbcDataAdapter adapter = new OdbcDataAdapter(command);
                        DataSet dataset = new DataSet();

                        try
                        {
                            adapter.Fill(dataset, "QueryResult");
                            dataGridView1.DataSource = dataset.Tables["QueryResult"];
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "SQL query error");
                        }
                    }

                    // enable sorting
                    foreach (DataGridViewColumn column in dataGridView1.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.Automatic;
                    }
                }
            }
        }

        private void queryBuilder_ActiveUnionSubQueryChanged(object sender, EventArgs e)
        {
            QueryPartChanged(sender, e);
        }

        private void errorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox1.SelectionStart = _errorPosition;
                textBox1.SelectionLength = 0;
                textBox1.ScrollToCaret();
            }

            textBox1.Focus();
        }

        private void errorBox1_RevertValidText(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidSql;
            textBox1.Focus();
        }

        private void connectToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryBuilder.QueryView.HideInformationMessage();

            var cf = new ConnectionForm() { Owner = this };

            if (cf.ShowDialog() != DialogResult.OK) return;

            _selectedConnection = cf.SelectedConnection;

            InitializeSqlContext();
        }
        private void InitializeSqlContext()
        {
            try
            {
                queryBuilder.Clear();

                BaseMetadataProvider metadataProvider = null;

                if (_selectedConnection == null) return;

                // create new SqlConnection object using the connections string from the connection form
                if (!_selectedConnection.IsXmlFile)
                    metadataProvider = _selectedConnection.ConnectionDescriptor?.MetadataProvider;

                // setup the query builder with metadata and syntax providers
                queryBuilder.SQLContext.MetadataContainer.Clear();
                queryBuilder.MetadataProvider = metadataProvider;
                queryBuilder.SyntaxProvider = _selectedConnection.ConnectionDescriptor?.SyntaxProvider;
                queryBuilder.MetadataLoadingOptions.OfflineMode = metadataProvider == null;
                
                if (metadataProvider == null)
                {
                    queryBuilder.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString);
                }

                // Instruct the query builder to fill the database schema tree
                queryBuilder.InitializeDatabaseSchemaTree();

            }
            finally
            {

            }
        }
    }
}
