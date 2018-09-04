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
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.NavigationBar;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms.QueryView;

namespace InterfaceCustomizationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set syntax provider
            QBuilder.SyntaxProvider = new MSSQLSyntaxProvider();

            // Fill metadata container from the XML file. (For demonstration purposes.)
            try
            {
                QBuilder.MetadataLoadingOptions.OfflineMode = true;
                QBuilder.MetadataContainer.ImportFromXML("Northwind.xml");
                QBuilder.InitializeDatabaseSchemaTree();

                QBuilder.SQL = @"SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID,
										[Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount
									  FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
									  WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void QBuilder_SQLUpdated(object sender, EventArgs e)
        {
			// Update the text of SQL query when it's changed in the query builder.
            TextBoxSQL.Text = QBuilder.FormattedSQL;
        }

        private void QBuilder_QueryElementControlCreated(QueryElement owner, IQueryElementControl control)
        {
            if (QElementCreated.Checked != true) return;

            TextBoxReport.Text = "QueryElementControl Created \"" + control.GetType().Name + "\"" +
                                Environment.NewLine + TextBoxReport.Text;

            if (control is DataSourceControl)
            {
                var cont = (DataSourceControl)control;
                cont.FieldListDrawItem += cont_FieldListDrawItem;
            }
        }

        private void cont_FieldListDrawItem(object drawingContext, CRectangle rect, CDrawItemState state, MetadataField field, ref bool handled)
        {
            var context = (Graphics)drawingContext;
            if (field == null || !field.PrimaryKey) return;

            handled = true;

            context.FillRectangle(Brushes.White, new Rectangle(new Point((int) rect.X, (int) rect.Y), new Size((int) rect.Width, (int) rect.Height)));

            if (((CDrawItemState.Selected & state)) != 0 && (CDrawItemState.Focus & state) != 0)
            {
                context.FillRectangle(Brushes.DodgerBlue, new Rectangle(new Point((int) rect.X, (int) rect.Y), new Size((int) rect.Width, (int) rect.Height)));
                context.DrawRectangle(new Pen(Color.Black) { DashStyle = DashStyle.Dot },
                    new Rectangle(new Point((int) rect.X, (int) rect.Y), new Size((int) rect.Width, (int) rect.Height - 1)));
            }
            else
            {
                if ((CDrawItemState.Selected & state) != 0 && (CDrawItemState.Focus & state) == 0)
                    context.FillRectangle(Brushes.DodgerBlue, new Rectangle(new Point((int) rect.X, (int) rect.Y), new Size((int) rect.Width, (int) rect.Height)));
            }

            var imageKey = (Bitmap)QBuilder.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon;

            context.DrawImage(imageKey, new Point((int) rect.X + 3, (int) rect.Y));

            const TextFormatFlags textFormatFlags = TextFormatFlags.NoClipping | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPrefix;

            var colorText = (CDrawItemState.Selected & state) != 0 ? Color.White : Color.Gray;
            var font = new Font(DefaultFont.FontFamily, DefaultFont.Size);
            var text = "(" + field.FieldTypeName + ") " + field.Name;
            var textSize = TextRenderer.MeasureText(text, font);

            TextRenderer.DrawText(context, text, font, new Rectangle(new Point((int) rect.X + imageKey.Width + 2, (int) rect.Y), new Size(textSize.Width, (int) rect.Height)), colorText, textFormatFlags);
        }

        private void QBuilder_QueryElementControlDestroying(QueryElement owner, IQueryElementControl control)
        {
            if (QElementDestroying.Checked != true) return;
            TextBoxReport.Text = "QueryElementControl Destroying \"" + control.GetType().Name + "\"" +
                                Environment.NewLine + TextBoxReport.Text;

            if(!(control is DataSourceControl)) return;

            var cntr = (DataSourceControl) control;
            cntr.FieldListDrawItem -= cont_FieldListDrawItem;
        }

        /// <summary>
        /// ValidateContextMenu event allows to modify or hide any query builder context menu.
        /// </summary>
        private void QBuilder_ValidateContextMenu(object sender, QueryElement queryelement, ICustomContextMenu menu)
        {
            if (ValidateContextMenu.Checked != true) return;

            TextBoxReport.Text = "OnValidateContextMenu" + Environment.NewLine + TextBoxReport.Text;
            // Insert custom menu item to the top of any context menu
            menu.InsertItem(0, "Custom Item 1", CustomItem1EventHandler);
            menu.InsertSeparator(1); // separator

            if (queryelement is Link) // Link context menu
            {
                // Add another item in the Link's menu
                menu.AddSeparator(); // separator
                menu.AddItem("Custom Item 2", CustomItem2EventHandler);
            }
            else if (queryelement is DataSourceObject) // Datasource context menu
            {
            }
            else if (queryelement is UnionSubQuery)
            {
                if (sender is IDesignPaneControl) // diagram pane context menu
                {
                }
                else if (sender is NavigationPopupBase)
                {
                }
            }
            else if (queryelement is QueryColumnListItem) // QueryColumnListControl context menu
            {
                menu.ClearItems();
            }
        }

        private void QBuilder_CustomizeDataSourceCaption(DataSource dataSource, ref string caption)
        {
            if (CustomizeDataSourceCaption.Checked != true) return;

            TextBoxReport.Text = "CustomizeDataSourceCaption for \"" + caption + "\"" +
                                Environment.NewLine + TextBoxReport.Text;
            caption = caption.ToUpper(CultureInfo.CurrentCulture);
        }

        private void TextBoxSQL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
			// Feed the text from text editor to the query builder when user exits the editor.
            try
            {
                // Update the query builder with manually edited query text:
                QBuilder.SQL = TextBoxSQL.Text;

                // Hide error banner if any
                ShowErrorBanner(TextBoxSQL, "");
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                TextBoxSQL.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                ShowErrorBanner(TextBoxSQL, ex.Message);
            }
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

        private static void CustomItem1EventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Custom Item 1");
        }

        private static void CustomItem2EventHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Custom Item 2");
        }

        private void QBuilder_CustomizeDataSourceFieldList(DataSource dataSource, List<FieldListItemData> fieldList)
        {
            if (CustomizeDataSourceFieldList.Checked != true) return;

            TextBoxReport.Text = "CustomizeDataSourceFieldList" +
                                Environment.NewLine + TextBoxReport.Text;

            var comparer = new FieldComparerByName();
            fieldList.Sort(comparer);
        }
    }
    
    public class FieldComparerByName : IComparer<FieldListItemData>
    {
        public int Compare(FieldListItemData x, FieldListItemData y)
        {
            return string.Compare(x.Name.ToLower(CultureInfo.CurrentCulture), y.Name.ToLower(CultureInfo.CurrentCulture),
                StringComparison.Ordinal);
        }
    }
}
