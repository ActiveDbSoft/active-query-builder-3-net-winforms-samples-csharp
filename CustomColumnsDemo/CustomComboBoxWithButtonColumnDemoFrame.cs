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
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms.QueryView;

namespace CustomColumnsDemo
{
    public partial class CustomComboBoxWithButtonColumnDemoFrame : UserControl
    {
        private readonly List<string> _customValuesProvider = new List<string>();
        private ComboBoxWithButtonColumn _customColumn;

        public CustomComboBoxWithButtonColumnDemoFrame()
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
                IQueryColumnListControl queryColumnListControl = (IQueryColumnListControl)queryElementControl;
                DataGridView dataGridView = (DataGridView) queryColumnListControl.DataGrid;

                _customColumn?.Dispose();

                // Create custom column
                _customColumn = new ComboBoxWithButtonColumn
                {
                    Name = "CustomColumn",
                    HeaderText = "Custom Column",
                    Width = 200,
                    DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing, // hide the combobox if cell is not focused
                    ValueType = typeof(string)
                };

                _customColumn.HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                _customColumn.ShowButton = true;

                // Insert custom column to specified position
                dataGridView.Columns.Insert(2, _customColumn);

                // Handle requierd events
                dataGridView.CellEnter += DataGridView_CellEnter;
                dataGridView.CellLeave += DataGridView_CellLeave;
                dataGridView.CellBeginEdit += DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded += DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed += DataGridView_CellValuePushed;
                dataGridView.EditingControlShowing += DataGridView_EditingControlShowing;
            }
        }

        private void queryBuilder1_QueryElementControlDestroying(QueryElement queryElement, IQueryElementControl queryElementControl)
        {
            if (queryElementControl is IQueryColumnListControl)
            {
                IQueryColumnListControl queryColumnListControl = (IQueryColumnListControl)queryElementControl;
                DataGridView dataGridView =(DataGridView) queryColumnListControl.DataGrid;

                // remove event handlers to avoid memory leaking
                dataGridView.CellEnter -= DataGridView_CellEnter;
                dataGridView.CellLeave -= DataGridView_CellLeave;
                dataGridView.CellBeginEdit -= DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded -= DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed -= DataGridView_CellValuePushed;
                dataGridView.EditingControlShowing -= DataGridView_EditingControlShowing;
            }
        }

        private void DataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;
            {
                // Make the combobox visible when a cell got the focus
                DataGridView dataGridView = (DataGridView) sender;
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell) dataGridView[e.ColumnIndex, e.RowIndex];
                comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            }
        }

        private void DataGridView_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;
            {
                // Make the combobox invisible when a cell lost the focus
                DataGridView dataGridView = (DataGridView) sender;
                DataGridViewComboBoxCell comboBoxCell = (DataGridViewComboBoxCell) dataGridView[e.ColumnIndex, e.RowIndex];
                comboBoxCell.DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing;
            }
        }

        private void DataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            if ( e.RowIndex < ((DataGridView) sender).RowCount - 1)
            {
                // Make cell editable
                e.Cancel = false; // Set true if you need read-only cell.            
            }
        }

        // This event handler allows you to provide cell values for your column
        private void DataGridView_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            var dataGrid = (DataGridView)sender;

            if (dataGrid.Columns[e.ColumnIndex] != _customColumn) return;

            if (e.RowIndex < ((DataGridView) sender).RowCount - 1)
            {
                DataGridView dataGridView = (DataGridView) sender;

                // Set cell value
                e.Value = _customValuesProvider[e.RowIndex];

                // Ensure the comobox list contains the value, otherwise the combobox will not show it.
                DataGridViewComboBoxColumn cb = (DataGridViewComboBoxColumn) dataGridView.Columns[2];
                if (!cb.Items.Contains(e.Value))
                    cb.Items.Add(e.Value);

                // If you need to access to the low level data item, use the following:
                // QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
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
            // QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];

        }

        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView) sender;
            int currentColumn = dataGridView.CurrentCell.ColumnIndex;
            int currentRow = dataGridView.CurrentCell.RowIndex;

            if (dataGridView.CurrentCell.ColumnIndex == 2 &&
                e.Control is DataGridViewComboBoxEditingControl)
            {
                DataGridViewComboBoxEditingControl comboBox = (DataGridViewComboBoxEditingControl) e.Control;
                comboBox.DropDownStyle = ComboBoxStyle.DropDown;

                // Fill the combobox dropdown list with possible values
                comboBox.Items.Clear();
                for (int i = 0; i < 100; i++)
                    comboBox.Items.Add("Some Value " + i);

                // Select current value
                comboBox.SelectedIndex = comboBox.FindStringExact((string) dataGridView[currentColumn, currentRow].Value);
            }

            // Handle the button click
            if (e.Control is ComboBoxWithButtonEditingControl)
            {
                ComboBoxWithButtonEditingControl twb = (ComboBoxWithButtonEditingControl) e.Control;
                twb.ButtonClicked -= EditingControlButtonClickedEventHandler; // remove the handler added in previous event occurrence
                twb.ButtonClicked += EditingControlButtonClickedEventHandler;
            }
        }

        private void EditingControlButtonClickedEventHandler(object sender, EventArgs e)
        {
            DataGridView dataGridView = ((ComboBoxWithButtonEditingControl) sender).EditingControlDataGridView;

            // commit the editing before dispatching the click
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dataGridView.RefreshEdit();

            MessageBox.Show("Button at row " + dataGridView.CurrentCell.RowIndex + " clicked.");

            // If you need to access to the low level data item, use the following:
            // QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[dataGridView.CurrentCell.RowIndex];
        }
    }
}
