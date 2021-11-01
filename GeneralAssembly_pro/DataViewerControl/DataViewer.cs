//*******************************************************************//
//       Active Query Builder Component Suite                        //
//                                                                   //
//       Copyright © 2006-2021 Active Database Software              //
//       ALL RIGHTS RESERVED                                         //
//                                                                   //
//       CONSULT THE LICENSE AGREEMENT FOR INFORMATION ON            //
//       RESTRICTIONS.                                               //
//*******************************************************************//

using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;
using GeneralAssembly.Forms.QueryInformationForms;

namespace GeneralAssembly.DataViewerControl
{
    public partial class DataViewer : UserControl
    {
        private string _textLoadedRows = "Query executed successfully. Loaded {0} rows.";
        public class ParameterInfo
        {
            public string Name { get; set; }
            public DbType DataType { get; set; }
            public object Value { get; set; }
        }

        public event EventHandler RowsLoaded;

        private string _currentTextSql;
        private bool _needCancelOperation;
        private Task<DataTable> _currentTask;
        private Task<DataTable> _nextTask;
        private QueryTransformer _queryTransformer;
        private SQLQuery _sqlQuery;

        private bool _IsVisiblePaginationPanel;

        public bool IsVisiblePaginationPanel
        {
            get => _IsVisiblePaginationPanel;
            set 
            {
                _IsVisiblePaginationPanel = value;
                paginationPanel1.Visible = value;
            }
        }

        public QueryTransformer QueryTransformer
        {
            set
            {
                if (_queryTransformer != null)
                    _queryTransformer.SQLUpdated -= QueryTransformerOnSqlUpdated;
                _queryTransformer = value; 
                if(_queryTransformer != null)
                    _queryTransformer.SQLUpdated += QueryTransformerOnSqlUpdated;
            }
            get { return _queryTransformer; }
        }

        public SQLQuery SqlQuery
        {
            set
            {
                _sqlQuery = value;

                if (_sqlQuery != null && QueryTransformer == null)
                    QueryTransformer = new QueryTransformer {QueryProvider = SqlQuery};
            }
            get { return _sqlQuery; }
        }

        [DefaultValue(true)]
        public bool EnabledSorting { set; get; }

        public int RowCount => dataGridView1.RowCount;

        public DataViewer()
        {
            EnabledSorting = true;
            InitializeComponent();
        }

        public void FillDataGrid(string sqlCommand, bool force = false)
        {
            infoPanel1.Message = string.Empty;
            bCancel.Enabled = true;

            if ((_currentTextSql == sqlCommand || string.IsNullOrWhiteSpace(sqlCommand)) && !force)
            {
                if (!string.IsNullOrWhiteSpace(sqlCommand)) return;

                dataGridView1.DataSource = null;
                OnRowsLoaded();
                return;
            }

            _currentTextSql = sqlCommand;

            dataGridView1.DataSource = null;

            var task = new Task<DataTable>(() => ExecuteSql(sqlCommand));

            if (_currentTask == null)
            {
                _currentTask = task;
                TryRunTask();
            }
            else
            {
                _nextTask = task;
                _needCancelOperation = true;
            }
        }

        public void Clear()
        {
            dataGridView1.DataSource = null;
        }

        private void QueryTransformerOnSqlUpdated(object sender, EventArgs e)
        {
            RefreshPaginationPanel();
        }

        private DbCommand CreateSqlCommand(string sqlCommand, SQLQuery sqlQuery)
        {
            DbCommand command = (DbCommand)sqlQuery.SQLContext.MetadataProvider.Connection.CreateCommand();
            command.CommandText = sqlCommand;

            // handle the query parameters
            if (sqlQuery.QueryParameters.Count == 0)
            {
                ClearParamsCache();
                return command;
            }

            var allApllied = ApplyParamsFromCache(command, sqlQuery);
            if (allApllied)
                return command;
            else
            {
                var qpf = new QueryParametersForm(command);
                if (qpf.ShowDialog() == DialogResult.OK)
                {
                    SaveParamsToCache(command);
                }
                else
                {
                    return null;
                }
            }

            return command;
        }

        public void ClearParamsCache()
        {
            Misc.ParamsCache.Clear();
        }

        private void SaveParamsToCache(DbCommand command)
        {
            ClearParamsCache();
            foreach (DbParameter parameter in command.Parameters)
            {
                if (parameter.Value != null)
                    Misc.ParamsCache.Add(new ParameterInfo
                    {
                        Name = parameter.ParameterName,
                        DataType = parameter.DbType,
                        Value = parameter.Value
                    });
            }
        }

        private static bool ApplyParamsFromCache(DbCommand command, SQLQuery query)
        {
            var result = true;
            foreach (var parameter in query.QueryParameters)
            {
                var cached =
                    Misc.ParamsCache.FirstOrDefault(x => x.Name == parameter.FullName && x.DataType == parameter.DataType);

                var param = command.CreateParameter();
                param.ParameterName = parameter.FullName;
                param.DbType = parameter.DataType;
                if (cached != null)
                    param.Value = cached.Value;
                else
                    result = false;

                command.Parameters.Add(param);
            }

            return result;
        }

        public DataTable ExecuteSql(string sqlCommand)
        {
            if (string.IsNullOrEmpty(sqlCommand)) return null;

            if (SqlQuery.SQLContext.MetadataProvider == null)
                return null;

            if (!SqlQuery.SQLContext.MetadataProvider.Connected)
                SqlQuery.SQLContext.MetadataProvider.Connect();

            if (string.IsNullOrEmpty(sqlCommand)) return null;

            if (!SqlQuery.SQLContext.MetadataProvider.Connected)
                SqlQuery.SQLContext.MetadataProvider.Connect();

            var command = CreateSqlCommand(sqlCommand, SqlQuery);
            if (command == null)
                return null;

            var table = new DataTable("result");

            try
            {
                using (var dbReader = command.ExecuteReader())
                {
                    for (var i = 0; i < dbReader.FieldCount; i++)
                        table.Columns.Add(dbReader.GetName(i));

                    while (dbReader.Read() && !_needCancelOperation)
                    {
                        var values = new object[dbReader.FieldCount];
                        dbReader.GetValues(values);
                        table.Rows.Add(values);
                    }

                    Invoke((Action) delegate
                    {
                        lQueryExecuted.Text = string.Format(_textLoadedRows, table.Rows.Count);
                        pRowCounter.Visible = true;
                    });
                    
                    return table;
                }
            }
            catch (Exception ex)
            {
                Invoke((Action) delegate
                {
                    pRowCounter.Visible = false;
                });
                Misc.ParamsCache.Clear();
                ShowException(ex);
            }

            return null;
        }

        private Control _usedParamsPanel;
        private void ShowUsedParams()
        {
            HideUsedParams();

            _usedParamsPanel = new Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.LightGoldenrodYellow,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top,
                Padding = new Padding(2, 2, 2, 2)
            };

            var parameters = Misc.ParamsCache.Select(x => string.Format("{0} = {1}", x.Name, x.Value));
            var paramsString = "Used parameters: " + string.Join(", ", parameters);

            Label label = new Label
            {
                AutoSize = true,
                Padding = new Padding(4, 3, 1, 0),
                Text = paramsString,
                Dock = DockStyle.Fill,
                UseCompatibleTextRendering = true
            };

            var button = new Button
            {
                Text = "Edit",
                Dock = DockStyle.Right,
                BackColor = SystemColors.Control,
                Margin = new Padding(5)
            };

            button.Click += EditParamsButtonOnClick;

            _usedParamsPanel.Controls.Add(button);
            _usedParamsPanel.Controls.Add(label);
            _usedParamsPanel.Visible = true;
            Controls.Add(_usedParamsPanel);
        }

        private void EditParamsButtonOnClick(object sender, EventArgs eventArgs)
        {
            Misc.ParamsCache.Clear();
            FillDataGrid(_currentTextSql, true);
        }

        private void HideUsedParams()
        {
            if (_usedParamsPanel != null)
            {
                _usedParamsPanel.Visible = false;
                if (_usedParamsPanel.Parent != null)
                    _usedParamsPanel.Parent.Controls.Remove(_usedParamsPanel);
                _usedParamsPanel.Dispose();
                _usedParamsPanel = null;
            }
        }

        private void TryRunTask()
        {
            if (_currentTask != null && (_currentTask.Status == TaskStatus.Running ||
                                         _currentTask.Status == TaskStatus.WaitingToRun))
                return;

            if (_currentTask != null)
            {
                Invoke((Action) delegate
                {
                    pLoading.Visible = true;
                });

                _currentTask.ContinueWith(TaskCompleted);

                try
                {
                    _currentTask.Start();
                }
                catch
                {
                    _currentTask = null;
                }

                return;
            }

            if (_nextTask == null) return;
            _currentTask = _nextTask;
            _nextTask = null;

            TryRunTask();
        }

        private void TaskCompleted(Task<DataTable> obj)
        {
            _currentTask = null;
            _needCancelOperation = false;

            Invoke((Action)delegate
            {
                dataGridView1.DataSource = obj.Result;

                if (Misc.ParamsCache.Count != 0 && dataGridView1.DataSource != null)
                    ShowUsedParams();
                else
                    HideUsedParams();

                pLoading.Visible = _currentTask != null;

                OnRowsLoaded();
            });
            TryRunTask();
        }

        private void ShowException(Exception ex)
        {
            Invoke((Action)delegate
            {
                infoPanel1.Message = ex.Message;
            });
        }

        private void ButtonCancelExecutingSql_OnClick(object sender, EventArgs e)
        {
            if (_currentTask == null || _currentTask.Status != TaskStatus.Running) return;

            bCancel.Enabled = false;
            _needCancelOperation = true;
            _nextTask = null;
        }

        protected virtual void OnRowsLoaded()
        {
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                column.SortMode = EnabledSorting
                    ? DataGridViewColumnSortMode.Programmatic
                    : DataGridViewColumnSortMode.NotSortable;
            }

            RowsLoaded?.Invoke(this, EventArgs.Empty);

            AdjustRowCounter();
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1 || e.ColumnIndex == -1 || !EnabledSorting)
                return;

            SortedColumn sorting = QueryTransformer.Sortings
                .FirstOrDefault(sort => sort.Column.OriginalName == dataGridView1.Columns[e.ColumnIndex].HeaderText);
            if (sorting == null)
            {
                return;
            }

            switch (sorting.SortType)
            {
                case ItemSortType.None:
                    dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.None;
                    break;
                case ItemSortType.Asc:
                    dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    break;
                case ItemSortType.Desc:
                    dataGridView1.Columns[e.ColumnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            e.Paint(e.ClipBounds, e.PaintParts);
            int sortIndex = QueryTransformer.Sortings.IndexOf(sorting) + 1;
            var format = new StringFormat
            {
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(sortIndex.ToString(), dataGridView1.Font, SystemBrushes.ControlText, new Rectangle(e.CellBounds.X + e.CellBounds.Width - 25, e.CellBounds.Y, 25, e.CellBounds.Height), format);
            e.Handled = true;
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(!EnabledSorting) return;

            var nameColumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;
            var nativeColumnForSorting = dataGridView1.Columns[e.ColumnIndex];
            var currentDirectionSorting = nativeColumnForSorting.HeaderCell.SortGlyphDirection;

            if (ModifierKeys != Keys.Control)
            {
                QueryTransformer.Sortings.Clear();
            }

            var columnForSorting = QueryTransformer.Columns.FindColumnByResultName(nameColumn);

            switch (currentDirectionSorting)
            {
                case SortOrder.Ascending:
                    QueryTransformer.Sortings.Add(columnForSorting.Desc());
                    break;
                case SortOrder.Descending:
                    QueryTransformer.Sortings.Remove(columnForSorting);
                    break;
                case SortOrder.None:
                    QueryTransformer.Sortings.Add(columnForSorting.Asc());
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            FillDataGrid(QueryTransformer.SQL);
        }

        private void paginationPanel1_EnabledPaginationChanged(object sender, EventArgs e)
        {
            // Turn paging on and off

            if (paginationPanel1.PaginationEnabled)
            {
                QueryTransformer.Take(paginationPanel1.PageSize.ToString());
            }
            else
            {
                paginationPanel1.Clear();

                QueryTransformer.BeginUpdate();
                try
                {
                    QueryTransformer.Take("");
                    QueryTransformer.Skip("");
                }
                finally
                {
                    QueryTransformer.EndUpdate();
                }
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);

            AdjustRowCounter();
        }

        private void AdjustRowCounter()
        {
            var vScroll = dataGridView1.Controls.OfType<VScrollBar>().FirstOrDefault();
            var hScroll = dataGridView1.Controls.OfType<HScrollBar>().FirstOrDefault();

            var x = dataGridView1.ClientSize.Width - pRowCounter.Width - 5;
            var x1 = (vScroll != null && vScroll.Visible) ? SystemInformation.VerticalScrollBarWidth : 0;
            var xResult = x - x1;

            var y = dataGridView1.ClientSize.Height - pRowCounter.Height - 5;
            var y1 = (hScroll != null && hScroll.Visible) ? SystemInformation.HorizontalScrollBarHeight : 0;
            var yResult = y - y1;

            pRowCounter.Location = new Point(xResult, yResult);
        }

        private void RefreshPaginationPanel()
        {
            paginationPanel1.Enabled =
                (QueryTransformer.IsSupportLimitCount || QueryTransformer.IsSupportLimitOffset) && IsVisiblePaginationPanel;
            paginationPanel1.IsSupportLimitCount = QueryTransformer.IsSupportLimitCount;
            paginationPanel1.IsSupportLimitOffset = QueryTransformer.IsSupportLimitOffset;

            AdjustRowCounter();
        }

        private void paginationPanel1_CurrentPageChanged(object sender, EventArgs e)
        {
            if (paginationPanel1.CurrentPage == 1)
            {
                QueryTransformer.Skip("");
                return;
            }

            // Setting the current page number
            QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString());
        }

        private void paginationPanel1_PageSizeChanged(object sender, EventArgs e)
        {
            // Setting the number of records per page
            QueryTransformer.Take(paginationPanel1.PageSize.ToString());
            if (paginationPanel1.CurrentPage > 1)
            {
                QueryTransformer.Skip((paginationPanel1.PageSize * (paginationPanel1.CurrentPage - 1)).ToString());
            }
        }

        private void linkLabelClose_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Invoke((Action)delegate
            {
                pRowCounter.Visible = false;   
            });
        }
    }
}
