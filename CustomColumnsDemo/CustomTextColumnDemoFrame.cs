//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2019 Active Database Software              //
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
		private readonly List<string> _customValuesProvider = new List<string>();
        private DataGridViewTextBoxColumn _customColumn;


        public CustomTextColumnDemoFrame()
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
				_customValuesProvider.Add("Some Value " + i);
        }

        private void queryBuilder1_QueryElementControlCreated(QueryElement queryElement, IQueryElementControl queryElementControl)
		{
            if (queryElementControl is IQueryColumnListControl)
            {
                var queryColumnListControl = (IQueryColumnListControl)queryElementControl;
                DataGridView dataGridView = (DataGridView)queryColumnListControl.DataGrid;

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

		private void queryBuilder1_QueryElementControlDestroying(QueryElement queryElement, IQueryElementControl queryElementControl)
		{
            if (queryElementControl is IQueryColumnListControl)
            {
                var queryColumnListControl = (IQueryColumnListControl)queryElementControl;
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
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            if (e.RowIndex < ((DataGridView) sender).RowCount - 1)
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
            var dataGrid = (DataGridView) sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            // Store new cell value
            _customValuesProvider[e.RowIndex] = (string) e.Value;

            // If you need to access to the low level data item, use the following:
//				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];

        }
    }
}
