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
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;

namespace FullFeaturedMdiDemo.Common
{
    public partial class ResultGrid : UserControl
    {
        public class ParameterInfo
        {
            public string Name { get; set; }
            public DbType DataType { get; set; }
            public object Value { get; set; }
        }

        public readonly List<ParameterInfo> ParamsCache = new List<ParameterInfo>();

        public event EventHandler RowsLoaded;

        private string _currentTextSql;
        private bool _needCancelOperation;
        private Task<DataTable> _currentTask;
        private Task<DataTable> _nextTask;

        public QueryTransformer QueryTransformer { set; get; }

        public SQLQuery SqlQuery { set; get; }

        [DefaultValue(true)]
        public bool EnabledSortings { set; get; }

        public int RowCount
        {
            get { return dataGridView1.RowCount; }
        }

        public ResultGrid()
        {
            EnabledSortings = true;
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

        public DbCommand CreateSqlCommand(string sqlCommand, SQLQuery sqlQuery)
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
            ParamsCache.Clear();
        }

        private void SaveParamsToCache(DbCommand command)
        {
            ClearParamsCache();
            foreach (DbParameter parameter in command.Parameters)
            {
                if (parameter.Value != null)
                    ParamsCache.Add(new ParameterInfo
                    {
                        Name = parameter.ParameterName,
                        DataType = parameter.DbType,
                        Value = parameter.Value
                    });
            }
        }

        private bool ApplyParamsFromCache(DbCommand command, SQLQuery query)
        {
            var result = true;
            foreach (var parameter in query.QueryParameters)
            {
                var cached =
                    ParamsCache.FirstOrDefault(x => x.Name == parameter.FullName && x.DataType == parameter.DataType);

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
            {
                return null;
            }

            if (!SqlQuery.SQLContext.MetadataProvider.Connected)
            {
                SqlQuery.SQLContext.MetadataProvider.Connect();
            }

            if (string.IsNullOrEmpty(sqlCommand)) return null;

            if (!SqlQuery.SQLContext.MetadataProvider.Connected)
                SqlQuery.SQLContext.MetadataProvider.Connect();

            var command = CreateSqlCommand(sqlCommand, SqlQuery);
            if (command == null)
                return null;

            DataTable table = new DataTable("result");

            try
            {
                using (var dbReader = command.ExecuteReader())
                {
                    for (int i = 0; i < dbReader.FieldCount; i++)
                    {
                        table.Columns.Add(dbReader.GetName(i));
                    }
                    while (dbReader.Read() && !_needCancelOperation)
                    {
                        object[] values = new object[dbReader.FieldCount];
                        dbReader.GetValues(values);
                        table.Rows.Add(values);
                    }

                    return table;
                }
            }
            catch (Exception ex)
            {
                ParamsCache.Clear();
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

            var parameters = ParamsCache.Select(x => string.Format("{0} = {1}", x.Name, x.Value));
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
            ParamsCache.Clear();
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
                Invoke((Action)delegate
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

                if (ParamsCache.Count != 0 && dataGridView1.DataSource != null)
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
                column.SortMode = EnabledSortings
                    ? DataGridViewColumnSortMode.Programmatic
                    : DataGridViewColumnSortMode.NotSortable;
            }
            if (RowsLoaded != null) RowsLoaded(this, EventArgs.Empty);
        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex != -1 || e.ColumnIndex == -1 || !EnabledSortings)
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
            StringFormat format = new StringFormat
            {
                LineAlignment = StringAlignment.Center
            };
            e.Graphics.DrawString(sortIndex.ToString(), dataGridView1.Font, SystemBrushes.ControlText, new Rectangle(e.CellBounds.X + e.CellBounds.Width - 25, e.CellBounds.Y, 25, e.CellBounds.Height), format);
            e.Handled = true;
        }

        void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(!EnabledSortings) return;

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
    }
}
