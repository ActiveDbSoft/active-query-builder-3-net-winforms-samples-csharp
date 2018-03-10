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
using System.Data.Odbc;
using System.Data.OleDb;
using Oracle.ManagedDataAccess.Client;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace BasicDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			// DEMO WARNING
			Panel trialNoticePanel = new Panel
			{
				AutoSize = true,
				AutoSizeMode = AutoSizeMode.GrowAndShrink,
				BackColor = Color.LightPink,
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
            Load += Form1_Load;
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            Load -= Form1_Load;
            queryBuilder1.SyntaxProvider = genericSyntaxProvider1;
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
			QueryBuilder.EditMetadataContainer(queryBuilder1.MetadataContainer, queryBuilder1.MetadataStructure, queryBuilder1.MetadataLoadingOptions);
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
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
				queryBuilder1.MetadataContainer.ImportFromXML(openFileDialog.FileName);
				queryBuilder1.InitializeDatabaseSchemaTree();
			}
		}

		private void saveMetadataToXMLMenuItem_Click(object sender, EventArgs e)
		{
			// Save metadata to XML file
			saveFileDialog.FileName = "Metadata.xml";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				queryBuilder1.MetadataContainer.LoadAll(true);
				queryBuilder1.MetadataContainer.ExportToXML(saveFileDialog.FileName);
			}
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
		}

		private void queryBuilder_SQLUpdated(object sender, EventArgs e)
		{
			// Handle the event raised by SQL Builder object that the text of SQL query is changed

			// Hide error banner if any
			ShowErrorBanner(sqlTextEditor1, "");

			// update the text box
			sqlTextEditor1.Text = queryBuilder1.FormattedSQL;
		}

		public void ResetQueryBuilder()
		{
			queryBuilder1.ClearMetadata();
			queryBuilder1.MetadataProvider = null;
			queryBuilder1.SyntaxProvider = null;
			queryBuilder1.MetadataLoadingOptions.OfflineMode = false;
		}

		private void connectToMSSQLServerMenuItem_Click(object sender, EventArgs e)
		{
			ResetQueryBuilder();

			// Connect to MS SQL Server

			// show the connection form
			using (MSSQLConnectionForm f = new MSSQLConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new SqlConnection object using the connections string from the connection form
					mssqlMetadataProvider1.Connection = new SqlConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = mssqlMetadataProvider1;
					queryBuilder1.SyntaxProvider = mssqlSyntaxProvider1;

					// kick the query builder to fill metadata tree
					queryBuilder1.InitializeDatabaseSchemaTree();
				}
			}
		}

		private void connectToOracleServerMenuItem_Click(object sender, EventArgs e)
		{
			ResetQueryBuilder();

            // Connect to Oracle Server.
            // Connect using a metadata provider based on the native Oracle Data Provider for .NET (Oracle.DataAccess.Client).

            // show the connection form
            using (OracleConnectionForm f = new OracleConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OracleConnection object using the connections string from the connection form
					oracleMetadataProvider1.Connection = new OracleConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = oracleMetadataProvider1;
					queryBuilder1.SyntaxProvider = oracleSyntaxProvider1;

					// kick the query builder to fill metadata tree
					queryBuilder1.InitializeDatabaseSchemaTree();
				}
			}
		}

		private void connectToAccessDatabaseMenuItem_Click(object sender, EventArgs e)
		{
			ResetQueryBuilder();

			// Connect to MS Access database using OLE DB provider

			// show the connection form
			using (AccessConnectionForm f = new AccessConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OleDbConnection object using the connections string from the connection form
					oledbMetadataProvider1.Connection = new OleDbConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = oledbMetadataProvider1;
					queryBuilder1.SyntaxProvider = msaccessSyntaxProvider1;

					// kick the query builder to fill metadata tree
					queryBuilder1.InitializeDatabaseSchemaTree();
				}
			}
		}

		private void connectOleDbMenuItem_Click(object sender, EventArgs e)
		{
			ResetQueryBuilder();

			// Connect to a database through the OLE DB provider

			// show the connection form
			using (OLEDBConnectionForm f = new OLEDBConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OleDbConnection object using the connections string from the connection form
					oledbMetadataProvider1.Connection = new OleDbConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = oledbMetadataProvider1;
					queryBuilder1.SyntaxProvider = genericSyntaxProvider1;

					// kick the query builder to fill metadata tree
					queryBuilder1.InitializeDatabaseSchemaTree();

					WarnAboutGenericSyntaxProvider(); // show warning (just for demonstration purposes)
				}
			}
		}

		private void connectODBCMenuItem_Click(object sender, EventArgs e)
		{
			ResetQueryBuilder();

			// Connect to a database through the ODBC provider

			// show the connection form
			using (ODBCConnectionForm f = new ODBCConnectionForm())
			{
				if (f.ShowDialog() == DialogResult.OK)
				{
					// create new OdbcConnection object using the connections string from the connection form
					odbcMetadataProvider1.Connection = new OdbcConnection(f.ConnectionString);

					// setup the query builder with metadata and syntax providers
					queryBuilder1.MetadataProvider = odbcMetadataProvider1;
					queryBuilder1.SyntaxProvider = genericSyntaxProvider1;

					// kick the query builder to fill metadata tree
					queryBuilder1.InitializeDatabaseSchemaTree();

					WarnAboutGenericSyntaxProvider(); // show warning (just for demonstration purposes)
				}
			}
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

		private void sqlTextEditor1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				queryBuilder1.SQL = sqlTextEditor1.Text;

				// Hide error banner if any
				ShowErrorBanner(sqlTextEditor1, "");
			}
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				sqlTextEditor1.SelectionStart = ex.ErrorPos.pos;

				// Show banner with error text
				ShowErrorBanner(sqlTextEditor1, ex.Message);
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
					if (queryBuilder1.MetadataProvider is MSSQLMetadataProvider)
					{
						SqlCommand command = (SqlCommand) queryBuilder1.MetadataProvider.Connection.CreateCommand();
						command.CommandText = queryBuilder1.SQL;

						// handle the query parameters
						if (queryBuilder1.Parameters.Count > 0)
						{
							for (int i = 0; i < queryBuilder1.Parameters.Count; i++)
							{
								if (!command.Parameters.Contains(queryBuilder1.Parameters[i].FullName))
								{
									SqlParameter parameter = new SqlParameter();
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
					else if (queryBuilder1.MetadataProvider is OracleNativeMetadataProvider)
					{
						OracleCommand command = (OracleCommand) queryBuilder1.MetadataProvider.Connection.CreateCommand();
						command.CommandText = queryBuilder1.SQL;

						// handle the query parameters
						if (queryBuilder1.Parameters.Count > 0)
						{
							for (int i = 0; i < queryBuilder1.Parameters.Count; i++)
							{
								if (!command.Parameters.Contains(queryBuilder1.Parameters[i].FullName))
								{
									OracleParameter parameter = new OracleParameter();
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

						OracleDataAdapter adapter = new OracleDataAdapter(command);
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
					else if (queryBuilder1.MetadataProvider is OLEDBMetadataProvider)
					{
						OleDbCommand command = (OleDbCommand) queryBuilder1.MetadataProvider.Connection.CreateCommand();
						command.CommandText = queryBuilder1.SQL;

						// handle the query parameters
						if (queryBuilder1.Parameters.Count > 0)
						{
							for (int i = 0; i < queryBuilder1.Parameters.Count; i++)
							{
								if (!command.Parameters.Contains(queryBuilder1.Parameters[i].FullName))
								{
									OleDbParameter parameter = new OleDbParameter();
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
					else if (queryBuilder1.MetadataProvider is ODBCMetadataProvider)
					{
						OdbcCommand command = (OdbcCommand) queryBuilder1.MetadataProvider.Connection.CreateCommand();
						command.CommandText = queryBuilder1.SQL;

						// handle the query parameters
						if (queryBuilder1.Parameters.Count > 0)
						{
							for (int i = 0; i < queryBuilder1.Parameters.Count; i++)
							{
								if (!command.Parameters.Contains(queryBuilder1.Parameters[i].FullName))
								{
									OdbcParameter parameter = new OdbcParameter();
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
				Timer timer = new System.Windows.Forms.Timer();
				timer.Tick += TimerEvent;
				timer.Interval = 10000;
				timer.Start();
			}
		}

		private void TimerEvent(Object source, EventArgs args)
		{
			panel1.Visible = false;
			((Timer) source).Stop();
			((Timer) source).Dispose();
		}

		public void ShowErrorBanner(Control control, String text)
		{
			// Destory banner if already showing
			{
				Control[] banners = control.Controls.Find("ErrorBanner", true);

				if (banners.Length > 0)
				{
					foreach (Control banner in banners)
						banner.Dispose();
				}
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
