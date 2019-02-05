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
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;


namespace AlternateNames
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

        protected override void OnLoad(EventArgs e)
        {
            // set required syntax provider
            queryBuilder1.SyntaxProvider = new DB2SyntaxProvider();

            try
            {
				// Load demo metadata from XML file
                queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
                queryBuilder1.MetadataContainer.ImportFromXML("db2_sample_with_alt_names.xml");
                queryBuilder1.InitializeDatabaseSchemaTree();

				// set example query text
	            queryBuilder1.SQL = "Select DEPARTMENT.DEPTNO, DEPARTMENT.DEPTNAME, DEPARTMENT.MGRNO From DEPARTMENT";
            }
            catch (QueryBuilderException ex)
            {
                MessageBox.Show(ex.Message);
            }

            base.OnLoad(e);
        }

		private void queryBuilder_SQLUpdated(object sender, EventArgs e)
		{
			// Text of SQL query has been updated.

			// To get the formatted query text with alternate object names just use FormattedSQL property
			textBox1.Text = queryBuilder1.FormattedSQL;

			// To get the query text, ready for execution on SQL server with real object names just use SQL property.
			textBox2.Text = queryBuilder1.SQL;

			// The query text containing in SQL property is unformatted. If you need the formatted text, but with real object names, 
			// do the following:
			//			SQLFormattingOptions formattingOptions = new SQLFormattingOptions();
			//			formattingOptions.Assign(queryBuilder1.SQLFormattingOptions); // copy actual formatting options from the QueryBuilder
			//			formattingOptions.UseAltNames = false; // disable alt names
			//			textBox2.Text = FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, formattingOptions);
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

		private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				queryBuilder1.SQL = textBox2.Text;

				// Hide error banner if any
				ShowErrorBanner(textBox2, "");
			}
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				textBox2.SelectionStart = ex.ErrorPos.pos;

				// Show banner with error text
				ShowErrorBanner(textBox2, ex.Message);
			}
		}

		private void editMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open the metadata container editor
			QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext, queryBuilder1.MetadataLoadingOptions);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
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
	                    if (Equals(text, banner.Text)) continue;
	                    banner.Dispose();
	                }
	            }

	            if (banners.Any(banner => !banner.Disposing)) return;
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
	                AutoSize = true,
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
