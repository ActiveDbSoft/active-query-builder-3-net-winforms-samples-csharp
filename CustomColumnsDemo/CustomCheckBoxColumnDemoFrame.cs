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
using System.Windows.Forms;

using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms.QueryView;

namespace CustomColumnsDemo
{
    public partial class CustomCheckBoxColumnDemoFrame : UserControl
    {
        private readonly List<bool> _customValuesProvider = new List<bool>();

        public CustomCheckBoxColumnDemoFrame()
        {
            InitializeComponent();

            // Fill query builder with demo data
            queryBuilder1.SyntaxProvider = new MSSQLSyntaxProvider();
            queryBuilder1.MetadataLoadingOptions.OfflineMode = true;
            queryBuilder1.MetadataContainer.ImportFromXML("Northwind.xml");
            queryBuilder1.InitializeDatabaseSchemaTree();
            queryBuilder1.SQL = "select OrderID, CustomerID, OrderDate from Orders";

            // Fill custom values source (for demo purposes)
            for (int i = 0; i < 100; i++)
                _customValuesProvider.Add(Convert.ToBoolean(i % 2));
        }

        private void queryBuilder1_QueryElementControlCreated(QueryElement queryElement, IQueryElementControl queryElementControl)
        {
            if (queryElementControl is IQueryColumnListControl)
            {
                IQueryColumnListControl queryColumnListControl = (IQueryColumnListControl)queryElementControl;
                DataGridView dataGridView = (DataGridView)queryColumnListControl.DataGrid;

                // Create custom column
                DataGridViewCheckBoxColumn customColumn = new DataGridViewCheckBoxColumn();
                customColumn.Name = "CustomColumn";
                customColumn.HeaderText = "Custom Column";
                customColumn.Width = 100;
                customColumn.FlatStyle = FlatStyle.Standard;
                customColumn.ValueType = typeof(CheckState);
                customColumn.TrueValue = CheckState.Checked;
                customColumn.FalseValue = CheckState.Unchecked;
                customColumn.IndeterminateValue = CheckState.Indeterminate;
                customColumn.HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);

                // Insert custom column to specified position
                dataGridView.Columns.Insert(2, customColumn);

                // Handle requierd events
                dataGridView.CellBeginEdit += DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded += DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed += DataGridView_CellValuePushed;
            }
        }

        private void queryBuilder1_QueryElementControlDestroying(QueryElement queryElement, IQueryElementControl queryElementControl)
        {
            if (queryElementControl is IQueryColumnListControl)
            {
                IQueryColumnListControl queryColumnListControl = (IQueryColumnListControl)queryElementControl;
                DataGridView dataGridView = (DataGridView)queryColumnListControl.DataGrid;

                // remove event handlers to avoid memory leaking
                dataGridView.CellBeginEdit -= DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded -= DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed -= DataGridView_CellValuePushed;
            }
        }

		/// <summary>
        /// This handler determines whether a custom column should be editable or not.
        /// </summary>
        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex < ((DataGridView)sender).RowCount - 1)
            {
                // Make cell editable
                e.Cancel = false; // Set true if you need read-only cell.			
            }
        }

        // This event handler allows you to display some custom value in you column
        private void DataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 2 && e.RowIndex < ((DataGridView)sender).RowCount - 1)
            {
                // Set cell value
                e.Value = _customValuesProvider[e.RowIndex];

                // If you need to access to the low level data item, use the following:
                //				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
            }
        }

        // This event handler allows you to store modified cell value (if your column is editable)
        private void DataGridView_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                // Store new cell value
                _customValuesProvider[e.RowIndex] = ((CheckState)e.Value == CheckState.Checked);

                // If you need to access to the low level data item, use the following:
                //				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
            }
        }
    }
}
