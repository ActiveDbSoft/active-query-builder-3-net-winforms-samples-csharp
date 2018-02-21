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
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;

namespace DatasourceFieldsLinkingDragnDropDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // set syntax provider
            QBuilder.SyntaxProvider = new MSSQLSyntaxProvider { ServerVersion = MSSQLServerVersion.MSSQL2012 };

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

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
        {
			// Update the text of SQL query when it's changed in the query builder.
            TextBoxSQL.Text = QBuilder.FormattedSQL;
        }

		/// <summary>
        /// The handler checks if the dragged field is a part of the primary key and denies dragging if it's not the case.
        /// </summary>
        private void QBuilder_BeforeDatasourceFieldDrag(DataSource dataSource, MetadataField field, ref bool abort)
        {
            if (CheckBoxBeforeDsFieldDrag.Checked != true) return;

			// deny dragging if a field isn't a part of the primary key
            if (!field.PrimaryKey)
            {
                TextBoxReport.Text = "OnBeforeDatasourceFieldDrag for field \"" + field.Name + " \" deny" +
                                    Environment.NewLine + TextBoxReport.Text;
                abort = true;
                return;
            }

            TextBoxReport.Text = "OnBeforeDatasourceFieldDrag for field \"" + field.Name + " \" allow" +
                                Environment.NewLine + TextBoxReport.Text;
        }

		/// <summary>
        /// Checking the feasibility of creating a link between the given fields.
        /// </summary>
        private void QBuilder_LinkDragOver(DataSource fromDataSource, MetadataField fromField, DataSource toDataSource, MetadataField toField, 
            MetadataForeignKey correspondingMetadataForeignKey, ref bool abort)
        {
            if (CheckBoxLinkDragOver.Checked != true) return;

			// Allow creation of links between fields of the same data type.
            if (fromField.FieldType == toField.FieldType)
            {
                TextBoxReport.Text = "OnLinkDragOver from field \"" + fromField.Name + "\" to field \"" + toField.Name +
                                    "\" allow" +
                                    Environment.NewLine + TextBoxReport.Text;
                return;
            }

            TextBoxReport.Text = "OnLinkDragOver from field \"" + fromField.Name + "\" to field \"" + toField.Name +
                                "\" deny" +
                                Environment.NewLine + TextBoxReport.Text;

            abort = true;
        }

        private void TextBoxSQL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
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

        private void ShowErrorBanner(Control control, String text)
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
