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
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.QueryView;

namespace QueryUIEventsDemo
{
    public partial class Form1 : Form
    {
        private int _errorPosition = -1;
        private string _lastValidSql;

        public Form1()
        {
            InitializeComponent();

            // set syntax provider
            QBuilder.SyntaxProvider = new MSSQLSyntaxProvider();

            // Fill metadata container from the XML file. (For demonstration purposes.)
            try
            {
                QBuilder.SQLQuery.QueryRoot.AllowSleepMode = false;
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

        private void QBuilder_DataSourceAdded(SQLQuery sender, DataSource addedObject)
        {
            if (CbDataSourceAdded.Checked != true) return;
            AddRowToReport("DataSourceAdded. Object caption \"" + addedObject.MetadataObject.Name + "\"");
        }

        /// <summary>
        /// Prompts the user if he/she really wants to add an object to the query.
        /// </summary>
        private void QBuilder_DataSourceAdding(MetadataObject fromObject, ref bool abort)
        {
            if (!CbDataSourceAdding.Checked) return;

            AddRowToReport("DataSourceAdding. Object caption \"" + fromObject.Name + "\"");

            var name = fromObject.Name;
            var msg = "Do you want to add the object \"" + name +
                         "\" on the diagram pane?";

            if (MessageBox.Show(msg, "DataSourceAdding event handler", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

		/// <summary>
        /// Displays a prompt on deleting an object from the query.
        /// </summary>
        private void QBuilder_DataSourceDeleting(DataSource dataSource, ref bool abort)
        {
            if (CbDataSourceDeleting.Checked != true) return;
            var name = dataSource.NameInQuery;
            var msg = "Do you want to remove the object \"" + name +
                         "\" on the diagram pane?";

            if (MessageBox.Show(msg, "DataSourceDeleting event handler", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        private void QBuilder_DataSourceFieldAdded(DataSource dataSource, MetadataField field, QueryColumnListItem queryColumnListItem, bool focusCondition)
        {
            if (CbDataSourceFieldAdded.Checked != true) return;
            AddRowToReport("DataSourceFieldAdded \"" + field.Name + "\"");
        }

        //
        // DatasourceFieldAdding event allows to prevent selecting of a field.
        //
        private void QBuilder_DataSourceFieldAdding(DataSource dataSource, MetadataField field, ref bool abort)
        {
            if (!CbDataSourceFieldAdding.Checked) return;

            AddRowToReport("DataSourceFieldAdding. Field name \"" + field.Name + "\"");
            var msg = "Do you want to add the field \"" + field.Name + "\" to the query?";

            if (MessageBox.Show(msg, "DatasourceFieldAdding event handler", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        private void QBuilder_DatasourceFieldRemoved(DataSource dataSource, MetadataField field)
        {
            if (CbDatasourceFieldRemoved.Checked != true) return;
            AddRowToReport("DatasourceFieldRemoved \"" + field.Name + "\"");
        }

        private void QBuilder_DataSourceFieldRemoving(DataSource dataSource, MetadataField field, ref bool abort)
        {
            if (CbDataSourceFieldRemoving.Checked != true) return;
            AddRowToReport("DataSourceFieldRemoving removing field \"" + field.Name + "\" form \"" +
                                dataSource.NameInQuery + "\"");

            var name = dataSource.NameInQuery;
            var msg = "Do you want to uncheck field \"" + field.Name + "\" in the object \"" + name +
                         "\"?";

            if (MessageBox.Show(msg, "DataSourceFieldRemoving event handler", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        private void QBuilder_QueryColumnListItemChanged(QueryColumnList queryColumnList, QueryColumnListItem queryColumnListItem, 
            QueryColumnListItemProperty property, int conditionIndex, object newValue)
        {
            if (CbQueryColumnListItemChanged.Checked != true) return;

            AddRowToReport("QueryColumnListItemChanged property \"" + property + "\" changed");
        }

        //
        // GridCellValueChanging event allows to prevent the cell value changing or modify the new cell value.
        // Note: Some columns hide/unhide dynamically but this does not affect the column index in the event parameters -
        //       it includes hidden columns.
        // private void queryBuilder1_GridCellValueChanging(UnionSubQuery unionSubQuery, QueryColumnList criteriaList, QueryColumnListItem criteriaItem, int column, int row, object oldValue, ref object newValue, ref bool abort)
        private void QBuilder_QueryColumnListItemChanging(QueryColumnList queryColumnList, QueryColumnListItem queryColumnListItem, 
            QueryColumnListItemProperty property, int conditionIndex, object oldValue, ref object newValue, ref bool abort)
        {
            if (!CbQueryColumnListItemChanging.Checked) return;

            AddRowToReport("QueryColumnListItemChanging. Changes column \"" + property + "\"");

            if (property == QueryColumnListItemProperty.Expression) // Prevent changes in the Expression column.
            {
                abort = true;
            }
            else if (property == QueryColumnListItemProperty.Alias) // Alias column. Lets add the underscore char in the beginning of all aliases, for example.
            {
                if (newValue != null && newValue is string)
                {
                    var s = (string)newValue;

                    if (s.Length > 0 && !s.StartsWith("_"))
                    {
                        s = "_" + s;
                        newValue = s;
                    }
                }
            }
        }

        private void QBuilder_LinkChanged(Link link)
        {
            if (CbLinkChanged.Checked != true) return;
            var value = string.Format("LinkChanging. Changing the link between {0}.{1} and {2}.{3}",
                                      link.LeftDataSource.MetadataObject.Name, link.LeftField, link.RightDataSource.MetadataObject.Name, link.RightField);
            AddRowToReport(value);
        }

        private void QBuilder_LinkChanging(Link link, ref bool abort)
        {
            if (CbLinkChanging.Checked == true)
            {
                AddRowToReport("\"LinkChanging\" deny");

                //deny changing properties of the Link
                abort = true;
                return;
            }

            AddRowToReport("\"LinkChanging\" allow");
        }

        private void QBuilder_LinkCreated(SQLQuery sender, Link link)
        {
            var value = string.Format("LinkCreated. Created the link between {0}.{1} and {2}.{3}",
                                      link.LeftDataSource.MetadataObject.Name, link.LeftField, link.RightDataSource.MetadataObject.Name, link.RightField);
            AddRowToReport(value);
        }

        //
        // LinkCreating event allows to prevent link creation
        //
        private void QBuilder_LinkCreating(DataSource fromDataSource, MetadataField fromField, DataSource toDataSource, MetadataField toField, 
            MetadataForeignKey correspondingMetadataForeignKey, ref bool abort)
        {
            if(!CbLinkCreating.Checked) return;

            var value = string.Format("LinkCreating. Creating the link between {0}.{1} and {2}.{3}",
                                      fromDataSource.MetadataObject.Name, fromField.Name, toDataSource.MetadataObject.Name, toField.Name);
            AddRowToReport(value);

            var msg = String.Format("Do you want to create the link between {0}.{1} and {2}.{3}?",
                                       fromDataSource.MetadataObject.Name, fromField.Name, toDataSource.MetadataObject.Name, toField.Name);

            if (MessageBox.Show(msg, "LinkCreating event handler", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        //
        // LinkDeleting event allows to prevent link deletion.
        //
        private void QBuilder_LinkDeleting(Link link, ref bool abort)
        {
            if (!CbLinkDeleting.Checked) return;

            var value = String.Format("LinkDeleting. Deleting the link between \"{2}.{0}\" and \"{3}.{1}\"",
                                       link.LeftField, link.RightField, link.LeftDataSource.MetadataObject.Name, link.RightDataSource.MetadataObject.Name);
            AddRowToReport(value);

            string msg = String.Format("Do you want to delete the link between \"{2}.{0}\" and \"{3}.{1}\"",
                                       link.LeftField, link.RightField, link.LeftDataSource.MetadataObject.Name, link.RightDataSource.MetadataObject.Name);

            if (MessageBox.Show(msg, "LinkDeleting event handler", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        private void QBuilder_SQLUpdated(object sender, EventArgs e)
        {
			// Update the text of SQL query when it's changed in the query builder.
            _lastValidSql = TextBoxSQL.Text = QBuilder.FormattedSQL;

            errorBox1.Show(null, QBuilder.SyntaxProvider);
        }

        private void AddRowToReport(string value)
        {
            TextBoxReport.Text = value + Environment.NewLine + TextBoxReport.Text;
        }

        private void TextBoxSQL_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
			// Feed the text from text editor to the query builder when user exits the editor.
            try
            {
                // Update the query builder with manually edited query text:
                QBuilder.SQL = TextBoxSQL.Text;

                // Hide error banner if any
                errorBox1.Show(null, QBuilder.SyntaxProvider);
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                _errorPosition = TextBoxSQL.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, QBuilder.SyntaxProvider);
            }
        }

        private void QBuilder_QueryColumnListItemAdded(object sender, QueryColumnListItem item)
        {
            var value = string.Format("QueryColumnListItemAdded. Added the [{0}]", item.ExpressionString);
            AddRowToReport(value);
        }

        private void QBuilder_QueryColumnListItemRemoving(object sender, QueryColumnListItem item, ref bool abort)
        {
            if(!cbQueryColumnListItemRemoving.Checked) return;

            var value = string.Format("QueryColumnListItemRemoving. Deleting the [{0}]", item.ExpressionString);
            AddRowToReport(value);

            var answer = MessageBox.Show(this,
                @"Do you want to delete the QueryColumnListItem [" + item.ExpressionString + @"]",
                @"QueryColumnListItemRemoving", MessageBoxButtons.YesNo);

            abort = answer == DialogResult.No;
        }

        private void ErrorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                TextBoxSQL.SelectionStart = _errorPosition;
                TextBoxSQL.SelectionLength = 0;
                TextBoxSQL.ScrollToCaret();
            }

            TextBoxSQL.Focus();
        }

        private void ErrorBox1_RevertValidText(object sender, EventArgs e)
        {
            TextBoxSQL.Text = _lastValidSql;
            TextBoxSQL.Focus();
        }
    }
}
