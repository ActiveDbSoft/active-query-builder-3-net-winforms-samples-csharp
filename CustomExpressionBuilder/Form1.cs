//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

/********************************************************************
 * This sample forms demonstrates using of custom expression builder.
 * When implementing this in your project don't forget to set the
 * UseCustomExpressionBuilder property of the query builder to true.
 ********************************************************************/

using System;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms;

namespace CustomExpressionBuilder
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
                queryBuilder.InitializeDatabaseSchemaTree();
                queryBuilder.SQLUpdated += queryBuilder_SQLUpdated;
                queryBuilder.SQL = @"SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID,
                                        [Order Details].UnitPrice, [Order Details].Quantity, [Order Details].Discount
                                      FROM Orders INNER JOIN [Order Details] ON Orders.OrderID = [Order Details].OrderID
                                      WHERE Orders.OrderID > 0 AND [Order Details].Discount > 0";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            base.OnLoad(e);
        }

        void queryBuilder_SQLUpdated(object sender, EventArgs e)
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


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryBuilder.ShowAboutDialog();
        }

        private void queryBuilder_CustomExpressionBuilder(object sender, ExpressionEditorParameters expressionEditorParameters)
        {
            using (CustomExpressionEditor f = new CustomExpressionEditor())
            {
                f.textBox.Text = expressionEditorParameters.OldExpression;

                if (f.ShowDialog() == DialogResult.OK)
                    expressionEditorParameters.NewExpression = f.textBox.Text;
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
    }
}
