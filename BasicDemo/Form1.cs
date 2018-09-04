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
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace BasicDemo
{
	public partial class Form1 : Form
	{
	    private Control _parametersErrorPanel;
        public Form1()
		{
			InitializeComponent();

		    queryBuilder1.ActiveUnionSubQueryChanged += delegate
		    {
		        sqlTextEditor1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery;
		    };
            
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

		    var buttonClose = new PictureBox { Image = Properties.Resources.cancel, SizeMode = PictureBoxSizeMode.AutoSize, Cursor = Cursors.Hand };
		    buttonClose.Click += delegate { Controls.Remove(trialNoticePanel); };

		    trialNoticePanel.Controls.Add(buttonClose);

		    trialNoticePanel.Resize += delegate
		    {
		        buttonClose.Location = new Point(trialNoticePanel.Width - buttonClose.Width - 10, trialNoticePanel.Height / 2 - buttonClose.Height / 2);
		    };

		    trialNoticePanel.Controls.Add(label);
		    Controls.Add(trialNoticePanel);

		    Controls.SetChildIndex(trialNoticePanel, 2);
            Load += Form1_Load;
		}

        private void Form1_Load(object sender, EventArgs e)
        {
            Load -= Form1_Load;
            queryBuilder1.SyntaxProvider = genericSyntaxProvider1;
            sqlTextEditor1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery;
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
		    QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.SQLContext.LoadingOptions);
		}

		private void clearMetadataMenuItem_Click(object sender, EventArgs e)
		{
			// Clear the metadata
			if (MessageBox.Show(@"Clear Metadata Container?", @"Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
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
		    CheckParameters();
		}

	    private void CheckParameters()
	    {
	        if (Misc.CheckParameters(queryBuilder1))
	            HideParametersErrorPanel();
	        else
	        {
	            var acceptableFormats =
	                Misc.GetAcceptableParametersFormats(queryBuilder1.MetadataProvider, queryBuilder1.SyntaxProvider);
	            ShowParametersErrorPanel(acceptableFormats);
	        }
	    }

	    private void ShowParametersErrorPanel(List<string> acceptableFormats)
	    {
	        HideParametersErrorPanel();
            _parametersErrorPanel = new Panel
	        {
	            AutoSize = true,
	            AutoSizeMode = AutoSizeMode.GrowAndShrink,
	            BackColor = Color.LightPink,
	            BorderStyle = BorderStyle.FixedSingle,
	            Dock = DockStyle.Top,
	            Padding = new Padding(6, 5, 3, 0),
	        };

	        var formats = acceptableFormats.Select(x =>
	        {
	            var s = x.Replace("n", "<number>");
	            return s.Replace("s", "<name>");
	        });

	        string formatsString = string.Join(", ", formats);

	        Label label = new Label
	        {
	            AutoSize = true,
	            Margin = new Padding(0),
	            Text = @"Unsupported parameter notation detected. For this type of connection and database server use " + formatsString,
	            Dock = DockStyle.Fill,
	            UseCompatibleTextRendering = true
	        };

	        _parametersErrorPanel.Controls.Add(label);
	        _parametersErrorPanel.Visible = true;
	        Controls.Add(_parametersErrorPanel);
	    }

	    private void HideParametersErrorPanel()
	    {
	        if (_parametersErrorPanel != null)
	        {
	            _parametersErrorPanel.Visible = false;
                if (_parametersErrorPanel.Parent != null)
	                _parametersErrorPanel.Parent.Controls.Remove(_parametersErrorPanel);
                _parametersErrorPanel.Dispose();
	            _parametersErrorPanel = null;
	        }
	    }

        public void ResetQueryBuilder()
		{
			queryBuilder1.ClearMetadata();
			queryBuilder1.MetadataProvider = null;
			queryBuilder1.SyntaxProvider = null;
			queryBuilder1.MetadataLoadingOptions.OfflineMode = false;
		}

	    private void menuItem5_Click(object sender, EventArgs e)
	    {
	        ResetQueryBuilder();

	        using (var connectionForm = new ConnectionForm())
	        {
	            if (connectionForm.ShowDialog() == DialogResult.OK)
	            {
	                try
	                {
	                    var context = connectionForm.Connection.GetSqlContext();
	                    queryBuilder1.SQLContext.Assign(context);
                    }
	                catch (Exception ex)
	                {
	                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
	                }                    
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
			    ExecuteQuery();
			}
		}

        private void ExecuteQuery()
        {
            dataGridView1.DataSource = null;

            if (queryBuilder1.MetadataProvider != null && queryBuilder1.MetadataProvider.Connected)
            {
                try
                {
                    dataGridView1.DataSource = Misc.ExecuteSql(queryBuilder1.SQL, queryBuilder1.SQLQuery);
                    if (Misc.ParamsCache.Count != 0 && dataGridView1.DataSource != null)
                        ShowUsedParams();
                    else
                        HideUsedParams();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "SQL query error");
                }

                // enable sorting
                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.Automatic;
                }
            }
        }

        private Control _usedParamsPanel;
        private void ShowUsedParams()
        {
            HideUsedParams();

            _usedParamsPanel = new Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.LightGoldenrodYellow,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top,
                Padding = new Padding(2, 2, 2, 2)
            };

            var parameters = Misc.ParamsCache.Select(x => string.Format("{0} = {1}", x.Name, x.Value));
            var paramsString = "Used parameters: " + string.Join(", ", parameters);

            Label label = new Label
            {
                AutoSize = true,
                Padding = new Padding(4, 3, 1, 0),
                Text = paramsString,
                Dock = DockStyle.Fill,
                UseCompatibleTextRendering = true
            };

            var button = new Button
            {
                Text = "Edit",
                Dock = DockStyle.Right,
                BackColor = SystemColors.Control,
                Margin = new Padding(5)
            };

            button.Click += EditParamsButtonOnClick;

            _usedParamsPanel.Controls.Add(button);
            _usedParamsPanel.Controls.Add(label);
            _usedParamsPanel.Visible = true;
            tabPageData.Controls.Add(_usedParamsPanel);
        }

        private void EditParamsButtonOnClick(object sender, EventArgs eventArgs)
        {
            Misc.ParamsCache.Clear();
            if (tabControl1.SelectedTab == tabPageData)
                ExecuteQuery();
        }

        private void HideUsedParams()
        {
            if (_usedParamsPanel != null)
            {
                _usedParamsPanel.Visible = false;
                if (_usedParamsPanel.Parent != null)
                    _usedParamsPanel.Parent.Controls.Remove(_usedParamsPanel);
                _usedParamsPanel.Dispose();
                _usedParamsPanel = null;
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
				    {
                        if(Equals(text, banner.Text)) continue;
				        banner.Dispose();
				    }
				}

                if(banners.Any(banner=> !banner.Disposing)) return;
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
