//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.QueryView;

namespace CustomColumnsDemo
{
    public partial class CustomTextColumnDemoFrame : UserControl
    {
        private DataGridViewTextBoxColumn _customColumn;

        private readonly Dictionary<UnionSubQuery, Dictionary<QueryColumnListItem, string>> _dictionarySubQuery =
            new Dictionary<UnionSubQuery, Dictionary<QueryColumnListItem, string>>();

        public CustomTextColumnDemoFrame()
        {
            InitializeComponent();
            queryBuilder1.ActiveUnionSubQueryChanging += QueryBuilder1_ActiveUnionSubQueryChanging;
            queryBuilder1.ActiveUnionSubQueryChanged += QueryBuilder1_ActiveUnionSubQueryChanged;
            queryBuilder1.QueryColumnListItemChanging += QueryBuilder1_QueryColumnListItemChanging;

            // Fill query builder with demo data
            queryBuilder1.SyntaxProvider = new MSSQLSyntaxProvider();
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
            queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml");
            queryBuilder1.InitializeDatabaseSchemaTree();

            queryBuilder1.SQL = "select OrderID, CustomerID, OrderDate from Orders";
        }

        private void QueryBuilder1_QueryColumnListItemChanging(QueryColumnList queryColumnList, QueryColumnListItem queryColumnListItem, 
            QueryColumnListItemProperty property, int conditionIndex, object oldValue, ref object newValue, ref bool abort)
        {
            
        }

        private static string CountCharacter(QueryColumnListItem value)
        {
            return string.IsNullOrEmpty(value.ExpressionString)
                ? "Empty"
                : $" Length {value.ExpressionString.Length}";
        }

        private void QueryBuilder1_ActiveUnionSubQueryChanged(object sender, System.EventArgs e)
        {
            if (queryBuilder1.ActiveUnionSubQuery == null) return;

            var value = _dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery];

            foreach (var listItem in queryBuilder1.ActiveUnionSubQuery.QueryColumnList)
            {
                if (value.ContainsKey(listItem))
                {
                    value[listItem] = listItem.ExpressionString + CountCharacter(listItem);
                    continue;
                }

                value.Add(listItem, listItem.ExpressionString + CountCharacter(listItem));
            }

            _dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery] = value;
        }

        private void QueryColumnListOnElementRemoving(QueryElement sender, QueryElement child)
        {
            var queryColumnListItem = (QueryColumnListItem) child;
            queryColumnListItem.Updated -= QueryColumnListItem_Updated;

            if (_dictionarySubQuery.ContainsKey(queryBuilder1.ActiveUnionSubQuery))
            {
                if (_dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery].ContainsKey(queryColumnListItem))
                    _dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery].Remove(queryColumnListItem);
            }
            else
            {
                foreach (var key in _dictionarySubQuery.Keys)
                {
                    if (!_dictionarySubQuery[key].ContainsKey(queryColumnListItem)) continue;
                    
                    _dictionarySubQuery[key].Remove(queryColumnListItem);
                }
            }
        }

        private void QueryColumnList_ElementAdded(QueryElement sender, QueryElement child)
        {
            var queryColumnListItem = (QueryColumnListItem) child;
            queryColumnListItem.Updated += QueryColumnListItem_Updated;
        }

        private void QueryColumnListItem_Updated(object sender, System.EventArgs e)
        {
            var queryColumnListItem = (QueryColumnListItem)sender;
            if (_dictionarySubQuery.ContainsKey(queryBuilder1.ActiveUnionSubQuery))
            {
                var values = _dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery];

                if (values.ContainsKey(queryColumnListItem))
                    values[queryColumnListItem] =
                        queryColumnListItem.ExpressionString + CountCharacter(queryColumnListItem);
                else
                    values.Add(queryColumnListItem,
                        queryColumnListItem.ExpressionString + CountCharacter(queryColumnListItem));
            }
            else
            {
                _dictionarySubQuery.Add(queryBuilder1.ActiveUnionSubQuery, new Dictionary<QueryColumnListItem, string>
                {
                    {queryColumnListItem, queryColumnListItem.ExpressionString + queryColumnListItem.ExpressionString + CountCharacter(queryColumnListItem)}
                });
            }
        }

        private void QueryBuilder1_ActiveUnionSubQueryChanging(object sender,
            ActiveQueryBuilder.View.SubQueryChangingEventArgs e)
        {
            if (e.OldSubQuery != null && _dictionarySubQuery.ContainsKey(e.OldSubQuery))
            {
                _dictionarySubQuery.Remove(e.OldSubQuery);
                e.OldSubQuery.QueryColumnList.ElementAdded -= QueryColumnList_ElementAdded;
                e.OldSubQuery.QueryColumnList.ElementRemoving -= QueryColumnListOnElementRemoving;
            }

            if (e.NewSubQuery == null || _dictionarySubQuery.ContainsKey(e.NewSubQuery)) return;

            e.NewSubQuery.QueryColumnList.ElementAdded += QueryColumnList_ElementAdded;
            e.NewSubQuery.QueryColumnList.ElementRemoving += QueryColumnListOnElementRemoving;


            _dictionarySubQuery.Add(e.NewSubQuery, new Dictionary<QueryColumnListItem, string>());
        }

        private void queryBuilder1_QueryElementControlCreated(QueryElement queryElement,
            IQueryElementControl queryElementControl)
        {
            if (queryElementControl is IQueryColumnListControl)
            {
                var queryColumnListControl = (IQueryColumnListControl) queryElementControl;
                DataGridView dataGridView = (DataGridView) queryColumnListControl.DataGrid;

                _customColumn?.Dispose();

                // Create custom column
                _customColumn = new DataGridViewTextBoxColumn
                {
                    Name = "CustomColumn", HeaderText = "Custom Column", Width = 200, ValueType = typeof(string)
                };
                _customColumn.HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);

                // Insert custom column to specified position
                dataGridView.Columns.Insert(2, _customColumn);

                // Handle requierd events
                dataGridView.CellBeginEdit += DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded += DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed += DataGridView_CellValuePushed;
            }
        }

        private void queryBuilder1_QueryElementControlDestroying(QueryElement queryElement,
            IQueryElementControl queryElementControl)
        {
            if (queryElementControl is IQueryColumnListControl)
            {
                var queryColumnListControl = (IQueryColumnListControl) queryElementControl;
                DataGridView dataGridView = (DataGridView) queryColumnListControl.DataGrid;

                // remove event handlers to avoid memory leaking
                dataGridView.CellBeginEdit -= DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded -= DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed -= DataGridView_CellValuePushed;
            }
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var dataGrid = (DataGridView) sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            if (e.RowIndex < ((DataGridView) sender).RowCount - 1)
            {
                // Make cell editable
                e.Cancel = false; // Set true if you need read-only cell.			
            }
        }

        // This event handler allows you to display some custom value in you column
        private void DataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var dataGrid = (DataGridView) sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            if (e.RowIndex >= ((DataGridView) sender).RowCount - 1) return;
            Dictionary<QueryColumnListItem, string> data = _dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery];

            if (!data.ContainsKey(queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items[e.RowIndex])) return;

            // Set cell value
            e.Value = data[queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items[e.RowIndex]];

            // If you need to access to the low level data item, use the following:
            //QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
        }

        // This event handler allows you to store modified cell value (if your column is editable)
        private void DataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            var dataGrid = (DataGridView) sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            if (e.RowIndex >= ((DataGridView) sender).RowCount - 1) return;
            Dictionary<QueryColumnListItem, string> data = _dictionarySubQuery[queryBuilder1.ActiveUnionSubQuery];

            if (data.ContainsKey(queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items[e.RowIndex]))
            {
                // Store new cell value
                data[queryBuilder1.ActiveUnionSubQuery.QueryColumnList.Items[e.RowIndex]] = (string) e.Value;
            }

            // If you need to access to the low level data item, use the following:
            //QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
        }
    }
}
