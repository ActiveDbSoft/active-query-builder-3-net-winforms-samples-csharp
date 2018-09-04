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
    public partial class CustomTextWithButtonColumnDemoFrame : UserControl
    {
        private List<string> _customValuesProvider = new List<string>();

        public CustomTextWithButtonColumnDemoFrame()
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
                DataGridView dataGridView = (DataGridView)queryColumnListControl.DataGrid;

                // Create custom column
                TextBoxWithButtonColumn customColumn = new TextBoxWithButtonColumn();
                customColumn.Name = "CustomColumn";
                customColumn.HeaderText = "Custom Column";
                customColumn.Width = 200;
                customColumn.ValueType = typeof(string);
                customColumn.HeaderCell.Style.Font = new Font("Tahoma", 8, FontStyle.Bold);
                customColumn.ShowButton = true;

                // Insert custom column to specified position
                dataGridView.Columns.Insert(2, customColumn);

                // Handle requierd events
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
                DataGridView dataGridView = (DataGridView)queryColumnListControl.DataGrid;

                // remove event handlers to avoid memory leaking
                dataGridView.CellBeginEdit -= DataGridView_CellBeginEdit;
                dataGridView.CellValueNeeded -= DataGridView_CellValueNeeded;
                dataGridView.CellValuePushed -= DataGridView_CellValuePushed;
                dataGridView.EditingControlShowing -= DataGridView_EditingControlShowing;
            }
        }

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
                _customValuesProvider[e.RowIndex] = (string)e.Value;

                // If you need to access to the low level data item, use the following:
                //				QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[e.RowIndex];
            }
        }

        private void DataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is TextBoxWithButtonEditingControl)
            {
                // Handle the button click
                TextBoxWithButtonEditingControl twb = (TextBoxWithButtonEditingControl)e.Control;
                twb.ButtonClicked -= EditingControl_ButtonClicked; // remove the handler added in previous event occurrence
                twb.ButtonClicked += EditingControl_ButtonClicked;
            }
        }

        private void EditingControl_ButtonClicked(object sender, EventArgs e)
        {
            DataGridView dataGridView = ((TextBoxWithButtonEditingControl)sender).EditingControlDataGridView;

            // commit the editing before dispatching the click
            dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
            dataGridView.RefreshEdit();

            MessageBox.Show(string.Format("Button at row {0} clicked.", dataGridView.CurrentCell.RowIndex));

            // If you need to access to the low level data item, use the following:
            //			QueryColumnListItem item = queryBuilder1.ActiveUnionSubQuery.QueryColumnList[dataGridView.CurrentCell.RowIndex];
        }
    }
}
