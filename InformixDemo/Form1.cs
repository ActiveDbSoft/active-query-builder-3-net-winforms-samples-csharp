//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2018 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using IBM.Data.Informix;

namespace InformixDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		
		private void connectMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Connect to Informix database

			// show the connection form
			using (InformixConnectionForm f = new InformixConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new SqlConnection object using the connections string from the connection form
					informixMetadataProvider1.Connection = new IfxConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.SyntaxProvider = informixSyntaxProvider1;
					queryBuilder1.MetadataProvider = informixMetadataProvider1;

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

			QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.MetadataLoadingOptions);
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
			ShowErrorBanner(textBox1, "");

			// update the text box
			textBox1.Text = queryBuilder1.SQL;
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
					IfxCommand command = (IfxCommand) queryBuilder1.MetadataProvider.Connection.CreateCommand();
					command.CommandText = queryBuilder1.SQL;

					// handle the query parameters
					if (queryBuilder1.Parameters.Count > 0)
					{
						for (int i = 0; i < queryBuilder1.Parameters.Count; i++)
						{
							if (!command.Parameters.Contains(queryBuilder1.Parameters[i].FullName))
							{
								IfxParameter parameter = new IfxParameter();
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

					IfxDataAdapter adapter = new IfxDataAdapter(command);
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
	}
}
