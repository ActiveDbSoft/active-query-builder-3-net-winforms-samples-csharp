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
using System.Data;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using GeneralAssembly.Forms.QueryInformationForms;
using VistaDB.Provider;

namespace VistaDB5demo
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
			// Connect to VistaDB database

			// show the connection form
			using (VistaDB5ConnectionForm f = new VistaDB5ConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new SqlConnection object using the connections string from the connection form
					vistaDb5MetadataProvider1.Connection = new VistaDBConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = vistaDb5MetadataProvider1;
					queryBuilder1.SyntaxProvider = vistaDbSyntaxProvider1;

					// kick the query builder to retrieve metadata from new connection
					queryBuilder1.InitializeDatabaseSchemaTree(); 
				}
			}
		}

		private void refreshMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Force the query builder to refresh metadata from current connection

			queryBuilder1.ClearMetadata();
			queryBuilder1.InitializeDatabaseSchemaTree();
		}

		private void editMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open the metadata container editor

			QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext);
		}

		private void clearMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Clear the metadata

			if (MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) ==
				DialogResult.Yes)
			{
				queryBuilder1.ClearMetadata();
			}
		}

		private void loadFromXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Load metadata from XML file

			if (openMetadataFileDialog.ShowDialog() == DialogResult.OK &&
				openMetadataFileDialog.FileName != "")
			{
				queryBuilder1.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName);
			}
		}

		private void saveToXMLToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Save metadata to XML file

			if (saveMetadataFileDialog.ShowDialog() == DialogResult.OK &&
				saveMetadataFileDialog.FileName != "")
			{
				queryBuilder1.MetadataContainer.ExportToXML(saveMetadataFileDialog.FileName);
			}
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
		}

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
		{
			// Handle the event raised by SQL builder object that the text of SQL query is changed

			// Hide error banner if any
			errorBox1.Show(null, queryBuilder1.SyntaxProvider);

			// update the text box
			_lastValidSql = textBox1.Text = queryBuilder1.FormattedSQL;
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
				_errorPosition = textBox1.SelectionStart = ex.ErrorPos.pos;

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
				dataGridView1.DataSource = null;

				if (queryBuilder1.MetadataProvider != null && queryBuilder1.MetadataProvider.Connected)
				{
					VistaDBCommand command = (VistaDBCommand) queryBuilder1.MetadataProvider.Connection.CreateCommand();
					command.CommandText = queryBuilder1.SQL;

					// handle the query parameters
					if (queryBuilder1.Parameters.Count > 0)
					{
						for (int i = 0; i < queryBuilder1.Parameters.Count; i++)
						{
							if (!command.Parameters.Contains(queryBuilder1.Parameters[i].FullName))
							{
								VistaDBParameter parameter = new VistaDBParameter();
								parameter.ParameterName = queryBuilder1.Parameters[i].FullName;
								parameter.DbType = queryBuilder1.Parameters[i].DataType;
								command.Parameters.Add(parameter);
							}
						}

						using (QueryParametersForm qpf = new QueryParametersForm(command))
						{
							qpf.ShowDialog();
						}
					}

					VistaDBDataAdapter adapter = new VistaDBDataAdapter(command);
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
			}
		}

		private void queryStatisticsMenuItem_Click(object sender, EventArgs e)
		{
			string stats = "";

			QueryStatistics qs = queryBuilder1.QueryStatistics;

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
