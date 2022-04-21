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
using System.Data;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using GeneralAssembly.Forms.QueryInformationForms;
using MySql.Data.MySqlClient;

namespace MySqlDemo
{
    public partial class Form1 : Form
    {
        private int _errorPosition = -1;
        private string _lastValidSql;

        public Form1()
        {
            InitializeComponent();
        }

        private void connectMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryBuilder.QueryView.HideInformationMessage();

            // Connect to MySQL database

            // show the connection form
            using (MySQLConnectionForm f = new MySQLConnectionForm())
            {
                if (f.ShowDialog() == DialogResult.OK)
                {
                    // create new SqlConnection object using the connections string from the connection form
                    mySQLMetadataProvider1.Connection = new MySqlConnection(f.ConnectionString);

                    // setup the query builder with metadata and syntax providers
                    queryBuilder.MetadataProvider = mySQLMetadataProvider1;
                    queryBuilder.SyntaxProvider = mySQLSyntaxProvider1;

                    // kick the query builder to retrieve metadata from new connection
                    queryBuilder.InitializeDatabaseSchemaTree(); 
                }
            }
        }

        private void refreshMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Force the query builder to refresh metadata from current connection

            queryBuilder.ClearMetadata();
            queryBuilder.InitializeDatabaseSchemaTree();
        }

        private void editMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the metadata container editor

            QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext);
        }

        private void clearMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Clear the metadata

            if (MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) ==
                DialogResult.Yes)
            {
                queryBuilder.ClearMetadata();
            }
        }

        private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Load metadata from XML file

            if (openMetadataFileDialog.ShowDialog() == DialogResult.OK &&
                openMetadataFileDialog.FileName != "")
            {
                queryBuilder.MetadataLoadingOptions.OfflineMode = true;
                queryBuilder.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName);
                queryBuilder.InitializeDatabaseSchemaTree(); 
            }
        }

        private void saveToXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Save metadata to XML file

            if (saveMetadataFileDialog.ShowDialog() == DialogResult.OK &&
                saveMetadataFileDialog.FileName != "")
            {
                queryBuilder.MetadataContainer.ExportToXML(saveMetadataFileDialog.FileName);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryBuilder.ShowAboutDialog();
        }

        private void queryBuilder_SQLUpdated(object sender, EventArgs e)
        {
            // Handle the event raised by SQL builder object that the text of SQL query is changed

            // Hide error banner if any
            errorBox1.Show(null, queryBuilder.SyntaxProvider);

            // update the text box
            _lastValidSql = textBox1.Text = queryBuilder.FormattedSQL;
        }

        private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
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

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            // Move the input focus to the query builder.
            // This will fire Leave event in the text box and update the query builder 
            // with modified query text.
            queryBuilder.Focus();
            Application.DoEvents();

            // Try to execute the query using current database connection:

            if (e.TabPage == tabPageData)
            {
                dataGridView1.DataSource = null;

                if (queryBuilder.MetadataProvider != null && queryBuilder.MetadataProvider.Connected)
                {
                    MySqlCommand command = (MySqlCommand) queryBuilder.MetadataProvider.Connection.CreateCommand();
                    command.CommandText = queryBuilder.SQL;

                    // handle the query parameters
                    if (queryBuilder.Parameters.Count > 0)
                    {
                        for (int i = 0; i < queryBuilder.Parameters.Count; i++)
                        {
                            if (!command.Parameters.Contains(queryBuilder.Parameters[i].FullName))
                            {
                                MySqlParameter parameter = new MySqlParameter();
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

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataSet dataset = new DataSet();

                    try
                    {
                        adapter.Fill(dataset, "QueryResult");
                        dataGridView1.DataSource = dataset.Tables["QueryResult"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "SQL query error.");
                    }
                }
            }
        }

        private void queryStatisticsMenuItem_Click(object sender, EventArgs e)
        {
            string stats = "";

            QueryStatistics qs = queryBuilder.QueryStatistics;

            stats = "Used Objects (" + qs.UsedDatabaseObjects.Count + "): ";
            for (int i = 0; i < qs.UsedDatabaseObjects.Count; i++)
                stats += "\n" + qs.UsedDatabaseObjects[i].ObjectName.QualifiedName;

            stats += "\n\n" + "Used Columns (" + qs.UsedDatabaseObjectFields.Count + "): ";
            for (int i = 0; i < qs.UsedDatabaseObjectFields.Count; i++)
                stats += "\n" + qs.UsedDatabaseObjectFields[i].FullName.QualifiedName;

            stats += "\n\n" + "Output Expressions (" + qs.OutputColumns.Count + "): ";
            for (int i = 0; i < qs.OutputColumns.Count; i++)
            {
                stats += "\n" + qs.OutputColumns[i].Expression;
            }

            MessageBox.Show(stats);
        }

        private void ErrorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox1.SelectionStart = _errorPosition;
                textBox1.SelectionLength = 0;
                textBox1.ScrollToCaret();
            }

            textBox1.Focus();
        }

        private void ErrorBox1_RevertValidText(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidSql;
            textBox1.Focus();
        }
    }
}
