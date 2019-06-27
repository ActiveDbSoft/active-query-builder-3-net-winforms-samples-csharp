//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using Advantage.Data.Provider;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;


namespace AdvantageDemo
{
	public partial class Form1 : Form
    {
        private string _lastValidSql;
        private int _errorPosition = -1;

		public Form1()
		{
			InitializeComponent();

			// DEMO WARNING
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

			trialNoticePanel.Controls.Add(label);
			Controls.Add(trialNoticePanel);
		}
		
		private void connectMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to Advantage database

			// show the connection form
			using (AdvantageConnectionForm f = new AdvantageConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new SqlConnection object using the connections string from the connection form
					advantageMetadataProvider1.Connection = new AdsConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder.MetadataProvider = advantageMetadataProvider1;
					queryBuilder.SyntaxProvider = advantageSyntaxProvider1;

					// kick the query builder to initialize its metadata tree
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

			if (MessageBox.Show(@"Clear Metadata Container?", @"Confirmation", MessageBoxButtons.YesNo) ==
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
				queryBuilder.MetadataContainer.ImportFromXML(openMetadataFileDialog.FileName);
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
			// Handle the event raised by QueryBuilder that the text of SQL query is changed

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

			// Try to execute the query using current database connection

			if (e.TabPage == tabPageData)
			{
				dataGridView1.DataSource = null;

				if (queryBuilder.MetadataProvider != null && queryBuilder.MetadataProvider.Connected)
				{
					AdsCommand command = (AdsCommand) queryBuilder.MetadataProvider.Connection.CreateCommand();
					command.CommandText = queryBuilder.SQL;

					// handle the query parameters
					if (queryBuilder.Parameters.Count > 0)
					{
						for (int i = 0; i < queryBuilder.Parameters.Count; i++)
						{
							if (!command.Parameters.Contains(queryBuilder.Parameters[i].FullName))
							{
								AdsParameter parameter = new AdsParameter();
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

					AdsDataAdapter adapter = new AdsDataAdapter(command);
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

            errorBox1.Visible = false;
            textBox1.Focus();
        }

        private void ErrorBox1_RevertValidText(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidSql;
            textBox1.Focus();
        }
    }
}
