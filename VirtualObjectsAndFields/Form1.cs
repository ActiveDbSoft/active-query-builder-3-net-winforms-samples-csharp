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
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace VirtualObjectsAndFields
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// Set required syntax provider
			queryBuilder.SyntaxProvider = new MSSQLSyntaxProvider();

			try
			{
				// Load metadata from XML file (for demonstration purposes)
				queryBuilder.MetadataLoadingOptions.OfflineMode = true;
				queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml");

				// ===========================================================================
				// CREATE VIRTUAL DATABASE OBJECTS AND FIELDS
				// ===========================================================================

				queryBuilder.MetadataContainer.BeginUpdate();

			    MetadataObject o;
				MetadataField f;

				// Virtual fields for real object
				// ===========================================================================

				o = queryBuilder.MetadataContainer.FindItem<MetadataObject>("Orders");
				Debug.Assert(o != null);

				// first test field - simple expression
				f = o.AddField("_OrderId_plus_1");
				f.Expression = "orders.OrderId + 1";

				// second test field - correlated sub-query
				f = o.AddField("_CustomerName");
				f.Expression = "(select c.CompanyName from Customers c where c.CustomerId = orders.CustomerId)";

				// Virtual object (table) with virtual fields
				// ===========================================================================

                // find parent "dbo" node 
                MetadataNamespace dboSchemaNode = queryBuilder.MetadataContainer.FindItem<MetadataNamespace>("dbo", MetadataType.Namespaces);

                o = dboSchemaNode.AddTable("Orders_tbl");
				o.Expression = "Orders";

				// first test field - simple expression
				f = o.AddField("_tbl_OrderId_plus_1");
				f.Expression = "Orders_tbl.OrderId + 1";

				// second test field - correlated sub-query
				f = o.AddField("_tbl_CustomerName");
				f.Expression = "(select c.CompanyName from Customers c where c.CustomerId = Orders_tbl.CustomerId)";

				// Virtual object (sub-query) with virtual fields
				// ===========================================================================

                o = dboSchemaNode.AddTable("Orders_qry");
				o.Expression = "(select OrderId, CustomerId, OrderDate from Orders) as dummy_alias";

				// first test field - simple expression
				f = o.AddField("_qry_OrderId_plus_1");
				f.Expression = "Orders_qry.OrderId + 1";

				// second test field - correlated sub-query
				f = o.AddField("_qry_CustomerName");
				f.Expression = "(select c.CompanyName from Customers c where c.CustomerId = Orders_qry.CustomerId)";

				// kick queryBuilder to initialize its metadata tree
				queryBuilder.InitializeDatabaseSchemaTree();

				queryBuilder.SQL = "SELECT dummy_alias._qry_OrderId_plus_1, dummy_alias._qry_CustomerName FROM Orders_qry dummy_alias";
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				queryBuilder.MetadataContainer.EndUpdate();
			}

			base.OnLoad(e);
		}

        private void queryBuilder_SQLUpdated(object sender, EventArgs e)
		{
			// Text of SQL query has been updated.
			
			// Hide error banner if any
			ShowErrorBanner(textBox1, "");
            ShowErrorBanner(textBox2, "");
			
			// has ExpandVirtualFields and ExpandVirtualObjects properties turned off.
			// Set the text of the first text box to the query text containing virtual objects.
            textBox1.Text = sqlFormattingOptions1.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
                //new SQLFormattingOptions(new SQLGenerationOptions
                //{
                //    ExpandVirtualObjects = false,
                //    ExpandVirtualFields = false
                //}).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
            // has ExpandVirtualFields and ExpandVirtualObjects properties turned on.
            // Set the text of the second text box to the query text containing virtual objects expanded to theirs expressions.
            textBox2.Text =
                sqlFormattingOptions2.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
		}

		private void textBox1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				queryBuilder.SQL = textBox1.Text;

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
				queryBuilder.SQL = textBox2.Text;

				// Hide error banner if any
				ShowErrorBanner(textBox2, "");
			}
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				textBox1.SelectionStart = ex.ErrorPos.pos;

				// Show banner with error text
				ShowErrorBanner(textBox2, ex.Message);
			}
		}

		private void editMetadataToolStripMenuItem_Click(object sender, EventArgs e)
		{
			// Open the metadata container editor
			QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext, queryBuilder.MetadataLoadingOptions);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
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
