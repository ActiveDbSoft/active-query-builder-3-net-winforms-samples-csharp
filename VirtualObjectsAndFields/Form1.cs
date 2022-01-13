//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2022 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Diagnostics;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace VirtualObjectsAndFields
{
    public partial class Form1 : Form
    {
        private int _errorPosition = -1;
        private string _lastValidSql;

        private int _errorPositionReal = -1;
        private string _lastValidSqlReal;

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
            errorBox1.Show(null, queryBuilder.SyntaxProvider);
            errorBoxReal.Show(null, queryBuilder.SyntaxProvider);

            // has ExpandVirtualFields and ExpandVirtualObjects properties turned off.
            // Set the text of the first text box to the query text containing virtual objects.
            _lastValidSql = textBox1.Text = sqlFormattingOptions1.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
                //new SQLFormattingOptions(new SQLGenerationOptions
                //{
                //    ExpandVirtualObjects = false,
                //    ExpandVirtualFields = false
                //}).GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
            // has ExpandVirtualFields and ExpandVirtualObjects properties turned on.
            // Set the text of the second text box to the query text containing virtual objects expanded to theirs expressions.
            _lastValidSqlReal = textBox2.Text =
                sqlFormattingOptions2.GetSQLBuilder().GetSQL(queryBuilder.ActiveUnionSubQuery.QueryRoot);
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

        private void textBox2_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
                queryBuilder.SQL = textBox2.Text;

                // Hide error banner if any
                errorBoxReal.Show(null, queryBuilder.SyntaxProvider);
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                textBox2.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBoxReal.Show(ex.Message, queryBuilder.SyntaxProvider);
            }
        }

        private void editMetadataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Open the metadata container editor
            QueryBuilder.EditMetadataContainer(queryBuilder.SQLContext);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QueryBuilder.ShowAboutDialog();
        }

        private void ErrorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                textBox1.SelectionStart = _errorPosition;
                textBox1.SelectionLength = 0;
                textBox1.ScrollToCaret();
            }

            textBox1.Focus();
        }

        private void ErrorBox1_RevertValidText(object sender, EventArgs e)
        {
            textBox1.Text = _lastValidSql;
            textBox1.Focus();
        }

        private void ErrorBoxReal_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPositionReal != -1)
            {
                textBox2.SelectionStart = _errorPositionReal;
                textBox2.SelectionLength = 0;
                textBox2.ScrollToCaret();
            }

            textBox2.Focus();
        }

        private void ErrorBoxReal_RevertValidText(object sender, EventArgs e)
        {
            textBox2.Text = _lastValidSqlReal;
            textBox2.Focus();
        }
    }
}
