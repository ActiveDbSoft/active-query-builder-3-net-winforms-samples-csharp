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
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;

namespace SeparatedComponents
{
	public partial class Form1 : Form
	{
        private int _errorPosition = -1;
        private string _lastValidSql;

        public Form1()
		{
			InitializeComponent();
		}

		protected override void OnLoad(EventArgs e)
		{
			try
			{
				// Fill metadata container from the XML file (for demonstration purposes).
				sqlContext1.LoadingOptions.OfflineMode = true;
				sqlContext1.MetadataContainer.ImportFromXML("Northwind.xml");
				
				databaseSchemaView1.InitializeDatabaseSchemaTree();
				
				sqlQuery1.SQL = @"SELECT Orders.OrderID, Orders.CustomerID, Orders.OrderDate, [Order Details].ProductID,
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

		private void refreshMetadataMenuItem_Click(object sender, EventArgs e)
		{
			// Force the query builder to refresh metadata from current connection
			// to refresh metadata, just clear MetadataContainer and reinitialize metadata tree

			if (sqlContext1.MetadataProvider != null && sqlContext1.MetadataProvider.Connected)
			{
				sqlContext1.ClearMetadata();
				databaseSchemaView1.InitializeDatabaseSchemaTree();
			}
		}

		private void editMetadataMenuItem_Click(object sender, EventArgs e)
		{
			// Open the metadata container editor

			QueryBuilder.EditMetadataContainer(sqlContext1);
		}

		private void clearMetadataMenuItem_Click(object sender, EventArgs e)
		{
			// Clear the metadata

			if (MessageBox.Show("Clear Metadata Container?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
			{
				sqlContext1.ClearMetadata();
			}
		}

		private void loadMetadataFromXMLMenuItem_Click(object sender, EventArgs e)
		{
			// Load metadata from XML file
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				sqlContext1.LoadingOptions.OfflineMode = true;
				sqlContext1.MetadataContainer.ImportFromXML(openFileDialog.FileName);
				databaseSchemaView1.InitializeDatabaseSchemaTree();
			}
		}

		private void saveMetadataToXMLMenuItem_Click(object sender, EventArgs e)
		{
			// Save metadata to XML file
			saveFileDialog.FileName = "Metadata.xml";

			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				sqlContext1.MetadataContainer.LoadAll(true);
				sqlContext1.MetadataContainer.ExportToXML(saveFileDialog.FileName);
			}
		}

		private void aboutMenuItem_Click(object sender, EventArgs e)
		{
			QueryBuilder.ShowAboutDialog();
		}

		private void sqlQuery_SQLUpdated(object sender, EventArgs e)
		{
			// Handle the event raised by SQL Builder object that the text of SQL query is changed
			
			// Hide error banner if any
			errorBox1.Show(null, sqlContext1.SyntaxProvider);

			// update the text box with formatted query text created with default formatting options
			_lastValidSql = sqlTextEditor1.Text = FormattedSQLBuilder.GetSQL(sqlQuery1.QueryRoot, new SQLFormattingOptions());
		}

		public void ResetQueryBuilder()
		{
			sqlContext1.ClearMetadata();
			sqlContext1.MetadataProvider = null;
			sqlContext1.SyntaxProvider = null;
			sqlContext1.LoadingOptions.OfflineMode = false;
		}

		private void sqlTextEditor1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
		{
			try
			{
				// Update the query builder with manually edited query text:
				sqlQuery1.SQL = sqlTextEditor1.Text;

                // Hide error banner if any
                errorBox1.Show(null, sqlContext1.SyntaxProvider);
            }
			catch (SQLParsingException ex)
			{
				// Set caret to error position
				_errorPosition = sqlTextEditor1.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, sqlContext1.SyntaxProvider);
            }
		}

		private void queryStatisticsMenuItem_Click(object sender, EventArgs e)
		{
			StringBuilder builder = new StringBuilder();

			QueryStatistics queryStatistics = sqlQuery1.QueryStatistics;

			builder.Append("Used Objects (").Append(queryStatistics.UsedDatabaseObjects.Count).AppendLine("):");
			builder.AppendLine();

			for (int i = 0; i < queryStatistics.UsedDatabaseObjects.Count; i++)
				builder.AppendLine(queryStatistics.UsedDatabaseObjects[i].ObjectName.QualifiedName);

			builder.AppendLine().AppendLine();
			builder.Append("Used Columns (").Append(queryStatistics.UsedDatabaseObjectFields.Count).AppendLine("):");
			builder.AppendLine();

			for (int i = 0; i < queryStatistics.UsedDatabaseObjectFields.Count; i++)
				builder.AppendLine(queryStatistics.UsedDatabaseObjectFields[i].FullName.QualifiedName);

			builder.AppendLine().AppendLine();
			builder.Append("Output Expressions (").Append(queryStatistics.OutputColumns.Count).AppendLine("):");
			builder.AppendLine();

			for (int i = 0; i < queryStatistics.OutputColumns.Count; i++)
				builder.AppendLine(queryStatistics.OutputColumns[i].Expression);

			MessageBox.Show(builder.ToString());
		}

        private void ErrorBox1_GoToErrorPositionEvent(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                sqlTextEditor1.SelectionStart = _errorPosition;
                sqlTextEditor1.SelectionLength = 0;
                sqlTextEditor1.ScrollToPosition(_errorPosition);
            }

            sqlTextEditor1.Focus();
        }

        private void ErrorBox1_RevertValidTextEvent(object sender, EventArgs e)
        {
            sqlTextEditor1.Text = _lastValidSql;
            sqlTextEditor1.Focus();
        }
    }
}
