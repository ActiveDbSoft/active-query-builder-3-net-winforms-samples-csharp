//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2025 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;

namespace QueryTransformerCoreDemo
{
    public partial class Form1 : Form
    {

        private SQLContext _sqlContext;
        private SQLQuery _sqlQuery;
        private QueryTransformer _queryTransformer;

        // List of query output columns of the current SQL query used for turning their visibility on and off
        private readonly List<string> _sourceCodeTransformer = new List<string>();
        
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load -= Form1_Load;

            _sqlContext = new SQLContext
            {
                SyntaxProvider = new MSSQLSyntaxProvider { ServerVersion = MSSQLServerVersion.MSSQL2012 },
                LoadingOptions = { OfflineMode = true }
            };
            _sqlContext.MetadataContainer.ImportFromXML("Northwind.xml");

            var sqlText = new StringBuilder();
            sqlText.AppendLine("Select Categories.CategoryName,");
            sqlText.AppendLine("Products.QuantityPerUnit");
            sqlText.AppendLine("From Categories");
            sqlText.AppendLine("Inner Join Products On Categories.CategoryID = Products.CategoryID");

            _sqlQuery = new SQLQuery(_sqlContext);

            _sqlQuery.SQLUpdated += _sqlQuery_SQLUpdated;

            _sqlQuery.SQL = sqlText.ToString();

            _queryTransformer = new QueryTransformer { Query = _sqlQuery };

            _queryTransformer.SQLUpdated += _queryTransformer_SQLUpdated;
            LoadData();
        }

        private void ClearFieldsSorting()
        {
            ComboBoxSortingColumns.SelectedItem = null;
            ComboBoxSortings.SelectedItem = null;
        }

        private void ClearFieldsAggregate()
        {
            ComboBoxAggregateColumns.SelectedItem = null;
            ComboBoxAggregations.SelectedItem = null;
        }

        private void ClearFieldsWhere()
        {
            ComboBoxWhereColumns.SelectedItem = null;
            ComboBoxAggregations.SelectedItem = null;
            ComboBoxConditions.SelectedItem = null;
            TextBoxWhereValue.Text = string.Empty;
        }

        private void LoadData()
        {
            // Clear the input fields
            ClearFieldsSorting();
            ClearFieldsAggregate();
            ClearFieldsWhere();

            ListBoxVisibleFields.Items.Clear();
            ComboBoxSortingColumns.Items.Clear();
            ComboBoxAggregateColumns.Items.Clear();
            ComboBoxWhereColumns.Items.Clear();

            _queryTransformer.Filters.Clear();
            _queryTransformer.Aggregations.Clear();
            _queryTransformer.Sortings.Clear();

            _sourceCodeTransformer.Clear();
            _sourceCodeTransformer.Add("_queryTransformer");

            // Set counter values
            CounterSortings.Text = _queryTransformer.Sortings.Count.ToString();
            CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString();
            CounterFilters.Text = _queryTransformer.Filters.Count.ToString();

            // Load a query into the SQLQuery object. 
            _sqlQuery.SQL = BoxSourceSql.Text;

            // Fill the list of output columns to be used as ItemsSource for a combobox
            foreach (var column in _queryTransformer.Columns)
            {
                var columnSource = new CustomColumn(column);
                ListBoxVisibleFields.Items.Add(columnSource);
                ListBoxVisibleFields.SetItemChecked(_queryTransformer.Columns.IndexOf(column), true);

                ComboBoxSortingColumns.Items.Add(columnSource);
                ComboBoxAggregateColumns.Items.Add(columnSource);
                ComboBoxWhereColumns.Items.Add(columnSource);

            }

            CounterVisibleColumns.Text = ListBoxVisibleFields.CheckedIndices.Count.ToString();
        }

        private void _queryTransformer_SQLUpdated(object sender, EventArgs e)
        {
            // Get the transformed SQL query text
            BoxResultSql.Text = _queryTransformer.SQL;
        }

        private void _sqlQuery_SQLUpdated(object sender, EventArgs e)
        {
            BoxSourceSql.Text = new SQLFormattingOptions(new SQLGenerationOptions()).GetSQLBuilder().GetSQL(_sqlQuery.QueryRoot);
        }

        private void ListBoxVisibleFields_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var column = (CustomColumn)ListBoxVisibleFields.Items[e.Index];

            if (column.Column.Visible == (e.NewValue == CheckState.Checked)) return;

            column.Column.Visible = e.NewValue == CheckState.Checked;

            CounterVisibleColumns.Text = _queryTransformer.Columns.Count(item => item.Visible).ToString();
        }

        private void ButtonLoad_Click(object sender, EventArgs e)
        {
            // Load a query and updating the form controls
            LoadData();
        }

        private void ButtonAddSorting_Click(object sender, EventArgs e)
        {
            var column = ((CustomColumn)ComboBoxSortingColumns.SelectedItem).Column;
            if (!column.IsSupportSorting) return;

            SortedColumn sortedColumn = null;
            switch (ComboBoxSortings.SelectedItem.ToString())
            {
                case "Asc":
                    sortedColumn = column.Asc();
                    break;
                case "Desc":
                    sortedColumn = column.Desc();
                    break;
            }

            var text = string.Format("\t.OrderBy(_queryTransformer.Columns[{0}], {1})",
                _queryTransformer.Columns.IndexOf(column),
                (ComboBoxSortings.SelectedItem.ToString() == "Asc").ToString().ToLower());

            // Add sorting to the query - the sort order of original query will be overridden.
            _queryTransformer.OrderBy(sortedColumn);

            CounterSortings.Text = _queryTransformer.Sortings.Count.ToString();
            BoxResultSql.Text = _queryTransformer.SQL;

            ClearFieldsSorting();
            _sourceCodeTransformer.Add(text);
        }

        private void ButtonClearSortings_Click(object sender, EventArgs e)
        {
            // Remove the added sortings from the query - the original sort order will be restored.
            _queryTransformer.Sortings.Clear();
            
            ClearFieldsSorting();
            
            CounterSortings.Text = _queryTransformer.Sortings.Count.ToString();

            for (var i = 0; i < _sourceCodeTransformer.Count; i++)
            {
                var line = _sourceCodeTransformer[i];
                if (!line.Contains("OrderBy")) continue;

                _sourceCodeTransformer.RemoveAt(i);
                i = 0;
            }
        }

        private void ButtonAddAggregate_Click(object sender, EventArgs e)
        {
            var column = ((CustomColumn)ComboBoxAggregateColumns.SelectedItem).Column;

            AggregatedColumn aggregatedColumn = null;
            switch (ComboBoxAggregations.SelectedItem.ToString())
            {
                case "Count":
                    aggregatedColumn = column.Count();
                    break;
                case "Avg":
                    aggregatedColumn = column.Avg();
                    break;
                case "Sum":
                    aggregatedColumn = column.Sum();
                    break;
                case "Min":
                    aggregatedColumn = column.Min();
                    break;
                case "Max":
                    aggregatedColumn = column.Max();
                    break;
            }
            var text = string.Format("\t.Select(_queryTransformer.Columns[{0}].{1}())",
                _queryTransformer.Columns.IndexOf(column), ComboBoxAggregations.SelectedItem);
            _sourceCodeTransformer.Add(text);
            
            // Add an aggregate to the query - if any aggregates are added, all other columns will be removed from the query.
            _queryTransformer.Aggregations.Add(aggregatedColumn);
            CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString();

            ClearFieldsAggregate();
        }

        private void ButtonClearAggregates_Click(object sender, EventArgs e)
        {
            // Clear all aggregates from the query - the columns of original query will be restored.
            ClearFieldsAggregate();
            _queryTransformer.Aggregations.Clear();
            CounterAggregations.Text = _queryTransformer.Aggregations.Count.ToString();

            for (var i = 0; i < _sourceCodeTransformer.Count; i++)
            {
                var line = _sourceCodeTransformer[i];
                if (!line.Contains("Select")) continue;

                _sourceCodeTransformer.RemoveAt(i);
                i = 0;
            }
        }

        private void ButtonAddWhere_Click(object sender, EventArgs e)
        {
            var column = ((CustomColumn)ComboBoxWhereColumns.SelectedItem).Column;

            var indexColumn = _queryTransformer.Columns.IndexOf(column);

            var expression = "";

            FilterCondition condition = null;
            switch (ComboBoxConditions.SelectedItem.ToString())
            {
                case "Equal":
                    condition = column.Equal(TextBoxWhereValue.Text);
                    expression = string.Format("Equal(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not Equal":
                    condition = column.Not_Equal(TextBoxWhereValue.Text);
                    expression = string.Format("Not_Equal(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Greater":
                    condition = column.Greater(TextBoxWhereValue.Text);
                    expression = string.Format("Greater(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "GreaterEqual":
                    condition = column.GreaterEqual(TextBoxWhereValue.Text);
                    expression = string.Format("GreaterEqual(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not Grater":
                    condition = column.Not_Greater(TextBoxWhereValue.Text);
                    expression = string.Format("Not_Greater(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not GreaterEqual":
                    condition = column.Not_GreaterEqual(TextBoxWhereValue.Text);
                    expression = string.Format("Not_GreaterEqual(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "IsNull":
                    condition = column.IsNull();
                    expression = "IsNull()";
                    break;
                case "Not IsNull":
                    condition = column.Not_IsNull();
                    expression = "Not_IsNull()";
                    break;
                case "IsNotNull":
                    condition = column.IsNotNull();
                    expression = "IsNotNull()";
                    break;
                case "Less":
                    condition = column.Less(TextBoxWhereValue.Text);
                    expression = string.Format("Less(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "LessEqual":
                    condition = column.LessEqual(TextBoxWhereValue.Text);
                    expression = string.Format("LessEqual(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not Less":
                    condition = column.Not_Less(TextBoxWhereValue.Text);
                    expression = string.Format("Not_Less(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not LessEqual":
                    condition = column.Not_LessEqual(TextBoxWhereValue.Text);
                    expression = string.Format("Not_LessEqual(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "In":
                    condition = column.In(TextBoxWhereValue.Text);
                    expression = string.Format("In(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not In":
                    condition = column.Not_In(TextBoxWhereValue.Text);
                    expression = string.Format("Not_In(\"{0}\")", TextBoxWhereValue.Text);

                    break;
                case "Like":
                    condition = column.Like(TextBoxWhereValue.Text);
                    expression = string.Format("Like(\"{0}\")", TextBoxWhereValue.Text);
                    break;
                case "Not Like":
                    condition = column.Not_Like(TextBoxWhereValue.Text);
                    expression = string.Format("Not_Like(\"{0}\")", TextBoxWhereValue.Text);
                    break;
            }

            // Add new filter to the query - the filter will be added to the WHERE clause of original query.
            _queryTransformer.Filters.Add(condition);
            CounterFilters.Text = _queryTransformer.Filters.Count.ToString();

            ClearFieldsWhere();

            var text = string.Format("\t.Where(_queryTransformer.Columns[{0}].{1})", indexColumn, expression);

            _sourceCodeTransformer.Add(text);
        }

        private void ButtonClearWhere_Click(object sender, EventArgs e)
        {
            ClearFieldsWhere();
            
            // Remove all additional filters from query - the original WHERE clause will be restored.
            _queryTransformer.Filters.Clear();
            
            CounterFilters.Text = _queryTransformer.Filters.Count.ToString();

            for (var i = 0; i < _sourceCodeTransformer.Count; i++)
            {
                var line = _sourceCodeTransformer[i];
                if (!line.Contains("Where")) continue;

                _sourceCodeTransformer.RemoveAt(i);
                i = 0;
            }
        }

        private void ButtonCodeBehindShow_Click(object sender, EventArgs e)
        {
            using (var formCode = new CodeBehindForm())
            {
                formCode.StartPosition = FormStartPosition.CenterParent;
                var builder = new StringBuilder();

                foreach (var line in _sourceCodeTransformer)
                    builder.AppendLine(line);

                formCode.TextContent = GetCodeBehind();
                formCode.ShowDialog(this);
            }
        }

        private string GetCodeBehind()
        {
            var builder = new StringBuilder();
            builder.AppendLine("_queryTransformer");

            foreach (var sorting in _queryTransformer.Sortings)
            {
                var text = string.Format("\t.OrderBy(_queryTransformer.Columns[{0}], {1})",
                 _queryTransformer.Columns.IndexOf(sorting.Column),
                 (sorting.SortType == ItemSortType.Asc).ToString().ToLower(CultureInfo.CurrentCulture));
                builder.AppendLine(text);
            }

            var reg = new Regex("([A-Z])\\w+");
            foreach (var aggregation in _queryTransformer.Aggregations)
            {
                var result = reg.Match(aggregation.Expression);
                if (!result.Success) continue;

                var text = string.Format("\t.Select(_queryTransformer.Columns[{0}].{1}())",
                    _queryTransformer.Columns.IndexOf(aggregation.Column), result.Value);
                builder.AppendLine(text);
            }

            foreach (var filter in _queryTransformer.Filters)
            {

                var text = string.Format("\t.Where(\"{0}\")", filter.Condition);
                builder.AppendLine(text);
            }

            return builder.ToString();
        }
    }

    public class CustomColumn
    {
        public OutputColumn Column { get; private set; }

        public CustomColumn(OutputColumn column)
        {
            Column = column;
        }

        public override string ToString()
        {
            return Column.Column.Expression;
        }
    }
}
