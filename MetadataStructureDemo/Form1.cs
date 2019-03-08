//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

//*******************************************************************
// This sample demonstrates using of various Query Builder events.
//
//*******************************************************************

using System;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace MetadataStructureDemo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			// set syntax provider
			queryBuilder.SyntaxProvider = new MSSQLSyntaxProvider();

			// Fill metadata container from the XML file. (For demonstration purposes.)
			try
			{
				queryBuilder.MetadataLoadingOptions.OfflineMode = true;
				queryBuilder.MetadataContainer.ImportFromXML("Northwind.xml");
				queryBuilder.SQL = @"SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID,
										[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount
									  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
									  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0";

				// Disable the automatic metadata structure creation
				queryBuilder.MetadataStructure.AllowChildAutoItems = false;
				
				MetadataFilterItem filter;

                // Create a top-level folder containing all objects
			    var allObjects = new MetadataStructureItem
			    {
			        Caption = "All objects",
			        ImageIndex = queryBuilder.DatabaseSchemaViewOptions.ImageIndices.FolderImageIndex
			    };
			    filter = allObjects.MetadataFilter.Add();
                filter.ObjectTypes = MetadataType.All;
                queryBuilder.MetadataStructure.Items.Add(allObjects);

                // Create "Favorites" folder
			    var favorites = new MetadataStructureItem
			    {
			        Caption = "Favorites",
			        ImageIndex = queryBuilder.DatabaseSchemaViewOptions.ImageIndices.FolderImageIndex
			    };
			    queryBuilder.MetadataStructure.Items.Add(favorites);


			    // Add some metadata objects to "Favorites" folder
				var metadataItem = queryBuilder.MetadataContainer.FindItem<MetadataItem>("Orders");
			    var item1 = new MetadataStructureItem
			    {
			        MetadataItem = metadataItem,
			    };
			    favorites.Items.Add(item1);

				metadataItem = queryBuilder.MetadataContainer.FindItem<MetadataItem>("Order Details");
			    var item2 = new MetadataStructureItem
			    {
			        MetadataItem = metadataItem,
			    };
			    favorites.Items.Add(item2);

				// Create folder with filter
			    MetadataStructureItem filteredFolder = new MetadataStructureItem
			    {
			        Caption = "Filtered by 'Prod%'",
			        ImageIndex = queryBuilder.DatabaseSchemaViewOptions.ImageIndices.FolderImageIndex
			    }; // creates dynamic node
			    filter = filteredFolder.MetadataFilter.Add();
				filter.ObjectTypes = MetadataType.Table | MetadataType.View;
				filter.Object = "Prod%";
				queryBuilder.MetadataStructure.Items.Add(filteredFolder);

				queryBuilder.InitializeDatabaseSchemaTree(); 
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			base.OnLoad(e);
		}

        private void queryBuilder_SQLUpdated(object sender, EventArgs e)
		{
			// Text of SQL query has been updated by the query builder.
			
			// Hide error banner if any
			ShowErrorBanner(textBox1, "");
			
			textBox1.Text = queryBuilder.FormattedSQL;
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

        private void tsbMetadataEditor_Click(object sender, EventArgs e)
        {
            QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext);
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
