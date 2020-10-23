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
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.View.WinForms;
using ActiveQueryBuilder.Core.QueryTransformer;
using ActiveQueryBuilder.View;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms.ExpressionEditor;
using ActiveQueryBuilder.View.WinForms.QueryView;
using FullFeaturedMdiDemo.Common;
using FullFeaturedMdiDemo.Reports;
using GeneralAssembly;
using GeneralAssembly.Dailogs;
using GeneralAssembly.Forms.QueryInformationForms;
using SqlHelpers = GeneralAssembly.SqlHelpers;
using Timer = System.Threading.Timer;

namespace FullFeaturedMdiDemo
{
    public partial class ChildForm : Form
    {
        public enum SourceType
        {
            File,
            New,
            UserQuery
        }

        private int _errorPosition = -1;
        private string _lastValidSql;

        private int _errorPositionCurrent = -1;
        private string _lastValidSqlCurrent;

        private readonly QueryTransformer _queryTransformerTop10;
        private readonly Timer _timerForFastResult;

        private readonly SQLContext _sqlContext;
        private readonly ConnectionInfo _connectionInfo;
        private SQLFormattingOptions _sqlFormattingOptions;
        private NoConnectionLabel _noConnectionLabel;

        public event CancelEventHandler SaveQueryEvent;
        public event CancelEventHandler SaveAsInFileEvent;
        public event CancelEventHandler SaveAsNewUserQueryEvent;

        public SourceType SqlSourceType { set; get; }
        public string FileSourcePath { get; set; }
        public MetadataStructureItem UserMetadataStructureItem { get; set; }

        public QueryView QueryView => QView;

        public MetadataLoadingOptions MetadataLoadingOptions
        {
            get { return _sqlContext.LoadingOptions; }
            set { _sqlContext.LoadingOptions = value; }
        }

        public MetadataStructureOptions MetadataStructureOptions
        {
            get { return _sqlContext.MetadataStructureOptions; }
            set { _sqlContext.MetadataStructureOptions = value; }
        }

        public SQLFormattingOptions SqlFormattingOptions
        {
            set
            {
                if (_sqlFormattingOptions != null)
                    _sqlFormattingOptions.Updated -= _sqlFormattingOptions_Updated;

                _sqlFormattingOptions = value;

                if (_sqlFormattingOptions != null)
                    _sqlFormattingOptions.Updated += _sqlFormattingOptions_Updated;
                CBuilder.QueryTransformer.SQLGenerationOptions = _sqlFormattingOptions;
            }
            get
            {
                return _sqlFormattingOptions;
            }
        }

        public SQLGenerationOptions SqlGenerationOptions
        {
            get { return QueryView.SQLGenerationOptions; }
            set { QueryView.SQLGenerationOptions = value; }
        }

        public BehaviorOptions BehaviorOptions
        {
            get { return SqlQuery.BehaviorOptions; }
            set { SqlQuery.BehaviorOptions = value; }
        }

        public ExpressionEditorOptions ExpressionEditorOptions
        {
            get { return expressionEditor1.Options; }
            set { expressionEditor1.Options = value; }
        }

        public TextEditorOptions TextEditorOptions
        {
            get { return rtbQueryText.Options; }
            set
            {
                expressionEditor1.TextEditorOptions = value;
                rtbQueryText.Options = value;
                TextBoxCurrentSubQuerySql.Options = value;
            }
        }

        public SqlTextEditorOptions TextEditorSqlOptions
        {
            get { return rtbQueryText.SqlOptions; }
            set
            {
                expressionEditor1.TextEditorSqlOptions = value;
                rtbQueryText.SqlOptions = value;
                TextBoxCurrentSubQuerySql.SqlOptions = value;
            }
        }

        public DataSourceOptions DataSourceOptions
        {
            get { return (DataSourceOptions) designPaneControl1.DataSourceOptions; }
            set { designPaneControl1.DataSourceOptions = value; }
        }

        public DesignPaneOptions DesignPaneOptions
        {
            get { return designPaneControl1.Options; }
            set { designPaneControl1.Options = value; }
        }

        public QueryNavBarOptions QueryNavBarOptions
        {
            get { return NavBar.Options; }
            set
            {
                NavBar.Options.Assign(value);
                subQueryNavBar1.Options.Assign((IQueryNavigationBarOptions)NavBar.Options);
            }
        }

        public AddObjectDialogOptions AddObjectDialogOptions
        {
            get { return addObjectDialog1.Options; }
            set { addObjectDialog1.Options = value; }
        }

        public UserInterfaceOptions UserInterfaceOptions
        {
            get { return QView.UserInterfaceOptions; }
            set { QView.UserInterfaceOptions = value; }
        }

        public VisualOptions VisualOptions
        {
            get { return dockManager1.Options; }
            set { dockManager1.Options = value; }
        }

        public QueryColumnListOptions QueryColumnListOptions
        {
            get { return queryColumnListControl1.Options; }
            set { queryColumnListControl1.Options = value;}
        }

        public SQLQuery SqlQuery { get; }

        public MainForm MainForm => MdiParent as MainForm;

        public Options GetOptions()
        {
            return new Options
            {
                AddObjectDialogOptions = AddObjectDialogOptions,
                BehaviorOptions = BehaviorOptions,
                DatabaseSchemaViewOptions = MainForm.DBView.Options,
                DataSourceOptions = DataSourceOptions,
                DesignPaneOptions = DesignPaneOptions,
                ExpressionEditorOptions = ExpressionEditorOptions,
                QueryColumnListOptions = QueryColumnListOptions,
                QueryNavBarOptions = QueryNavBarOptions,
                SqlFormattingOptions = SqlFormattingOptions,
                SqlGenerationOptions = SqlGenerationOptions,
                TextEditorOptions = TextEditorOptions,
                TextEditorSqlOptions = TextEditorSqlOptions,
                UserInterfaceOptions = UserInterfaceOptions,
                VisualOptions = VisualOptions
            };
        }

        public void SetOptions(Options options)
        {
            AddObjectDialogOptions.Assign(options.AddObjectDialogOptions);
            BehaviorOptions.Assign(options.BehaviorOptions);
            MainForm.DBView.Options.Assign(options.DatabaseSchemaViewOptions);
            DataSourceOptions.Assign(options.DataSourceOptions);
            DesignPaneOptions.Assign(options.DesignPaneOptions);
            ExpressionEditorOptions.Assign(options.ExpressionEditorOptions);
            QueryColumnListOptions.Assign(options.QueryColumnListOptions);
            QueryNavBarOptions.Assign(options.QueryNavBarOptions);
            SqlFormattingOptions.Assign(options.SqlFormattingOptions);
            SqlGenerationOptions.Assign(options.SqlGenerationOptions);
            TextEditorOptions.Assign(options.TextEditorOptions);
            TextEditorSqlOptions.Assign(options.TextEditorSqlOptions);
            UserInterfaceOptions.Assign(options.UserInterfaceOptions);
            VisualOptions.Assign(options.VisualOptions);
        }

        public string QueryText
        {
            get
            {
                return SqlQuery.SQL;
            }
            set
            {
                SqlQuery.SQL = value;
            }
        }

        public string SqlEditorText
        {
            get { return rtbQueryText.Text; }
            set
            {
                rtbQueryText.Text = value;
                rtbQueryText_Validating(this, null);
            }
        }

        public string FormattedQueryText => FormattedSQLBuilder.GetSQL(SqlQuery.QueryRoot, _sqlFormattingOptions);

        public ChildForm(SQLContext sqlContext, ConnectionInfo connectionInfo)
        {
            InitializeComponent();

            _queryTransformerTop10 = new QueryTransformer();
            Debug.Assert(sqlContext != null);
            SqlSourceType = SourceType.New;
            
            _sqlContext = sqlContext;
            _connectionInfo = connectionInfo;
            SqlQuery = new SQLQuery(_sqlContext);
            SqlQuery.QueryRoot.AllowSleepMode = true;
            
            SqlQuery.SleepModeChanged += SqlQuery_SleepModeChanged;
            SqlQuery.QueryAwake += SqlQuery_QueryAwake;
            _timerForFastResult = new Timer(TimerForFastResult_Elapsed);            

            CBuilder.QueryTransformer = new QueryTransformer
            {
                Query = SqlQuery
            };
            SqlFormattingOptions = new SQLFormattingOptions();

            CBuilder.QueryTransformer.SQLUpdated += CBuilder_SQLUpdated;

            rtbQueryText.QueryProvider = SqlQuery;
            TextBoxCurrentSubQuerySql.QueryProvider = SqlQuery;
            resultGrid1.SqlQuery = SqlQuery;
            resultGrid2.SqlQuery = SqlQuery;
            resultGrid1.QueryTransformer = CBuilder.QueryTransformer;
            
            QView.Query = SqlQuery;
            NavBar.QueryView = QView;
            NavBar.Query = SqlQuery;

            RepairImageLists();            
            toolStripStatusLabel1.Text = "Query builder state: " + ((SqlQuery.SleepMode) ? "Inactive" : "Active");

            Application.Idle += Application_Idle;
            
            SqlQuery.SQLUpdated += query_SQLUpdated;
            QueryView.ActiveUnionSubQueryChanged += QueryViewOnActiveUnionSubQueryChanged;

            rtbQueryText.ExpressionContext = QView.ActiveUnionSubQuery;
            TextBoxCurrentSubQuerySql.ExpressionContext = QView.ActiveUnionSubQuery;
            QueryNavBarOptions.Updated += QueryNavBarOptions_Updated;
        }

        private void QueryNavBarOptions_Updated(object sender, EventArgs e)
        {
            subQueryNavBar1.Options.Assign((IQueryNavigationBarOptions)QueryNavBarOptions);
        }

        private void QueryViewOnActiveUnionSubQueryChanged(object sender, EventArgs eventArgs)
        {
            if (QueryView.ActiveUnionSubQuery?.ParentSubQuery != null)
                TextBoxCurrentSubQuerySql.Text = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetResultSQL(_sqlFormattingOptions);

            rtbQueryText.ExpressionContext = QView.ActiveUnionSubQuery;
            TextBoxCurrentSubQuerySql.ExpressionContext = QView.ActiveUnionSubQuery;
        }

        private void TimerForFastResult_Elapsed(object state)
        {
            Invoke((Action)delegate
            {
                resultGrid2.QueryTransformer = _queryTransformerTop10;
                resultGrid2.FillDataGrid(_queryTransformerTop10.Take("10").SQL);
            });
        }

        private void ChildForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !Save(true);
        }

        public bool Save(bool showQuery)
        {
            if(SqlSourceType == SourceType.New)
            {
                SaveAsForm dialog = new SaveAsForm(Text);
                switch(dialog.ShowDialog())
                {
                    case DialogResult.Cancel:
                        return false;
                    case DialogResult.No:
                        return true;
                }
                if(dialog.SaveAsFile)
                {
                    return SaveInFile();
                }
                return SaveAsNewUserQuery();
            }
            if(_oldSql != FormattedQueryText)
            {
                if(showQuery)
                {
                    SaveForm saveDialog = new SaveForm();
                    if(saveDialog.ShowDialog() != DialogResult.OK)
                    {
                        return false;
                    }
                    if(saveDialog.IsSave)
                    {
                        return SaveQuery();
                    }
                } else {
                    return SaveQuery();
                }
            }
            return true;
        }

	    private string _oldSql;
        private bool _hasError;

	    private void _sqlFormattingOptions_Updated(object sender, EventArgs e)
	    {
	        rtbQueryText.Text = FormattedQueryText;
        }

	    protected override void OnClosing(CancelEventArgs e)
	    {
	        if (_sqlContext.MetadataProvider != null && _sqlContext.MetadataProvider.Connection != null)
	        {
	            _sqlContext.MetadataProvider.Connection.Close();
	        }

	        base.OnClosing(e);
	    }

	    protected override void OnClosed(EventArgs e)
	    {
	        base.OnClosed(e);
            
            Dispose();
	    }

	    protected override void OnLoad(EventArgs e)
	    {
	        Application.DoEvents();

	        // Expand form to client rectangle of main form
	        MdiClient mdiClient = MdiParent.Controls.OfType<MdiClient>().FirstOrDefault();

            if(mdiClient == null) return;

	        Bounds = mdiClient.ClientRectangle;	        

	        if (_sqlContext.MetadataProvider != null)
	        {
	            // load from cache

	            if (!String.IsNullOrEmpty(_connectionInfo.CacheFile) && File.Exists(_connectionInfo.CacheFile))
	            {
	                String message = @"Cached metadata is found.
Do you want to load database structure from cache?";

	                if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
	                {
	                    Cursor = Cursors.WaitCursor;

	                    try
	                    {
	                        _sqlContext.MetadataContainer.ImportFromXML(_connectionInfo.CacheFile);
	                    }
	                    catch (Exception ex)
	                    {
	                        MessageBox.Show("Invalid cache file: \n" + ex.Message);
	                    }
	                    finally
	                    {
	                        Cursor = Cursors.Default;
	                    }

	                    return;
	                }

	                if (MessageBox.Show(@"Delete cached data?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
	                {
	                    try
	                    {
	                        File.Delete(_connectionInfo.CacheFile);
	                    }
	                    catch
	                    {
                            //ignore
	                    }
	                }
	            }

	            //load from database server

	            Cursor = Cursors.WaitCursor;

	            try
	            {
	                DateTime start = DateTime.Now;

	                // ask for caching
	                if ((DateTime.Now - start).TotalSeconds > 60)
	                {
	                    String message = "Do you want to cache the database structure to quicken further loading?";

	                    if (MessageBox.Show(message, "", MessageBoxButtons.YesNo) == DialogResult.Yes)
	                    {
	                        String dir = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\FullFeaturedMdiDemo\";
	                        String cacheFile = dir + _connectionInfo.GetHashCode().ToString() + ".xml";

	                        if (!Directory.Exists(dir))
	                        {
	                            Directory.CreateDirectory(dir);
	                        }

	                        // pre-load database databases/schemas/objects for export, but skip params/fields/foreign keys
	                        _sqlContext.MetadataContainer.LoadAll(false);
	                        _sqlContext.MetadataContainer.ExportToXML(cacheFile);
	                        _connectionInfo.CacheFile = cacheFile;
	                    }
	                }
	            }
	            catch (Exception ex)
	            {
	                MessageBox.Show(ex.Message);
	            }
	            finally
	            {
	                Cursor = Cursors.Default;
	            }
	        }

	        base.OnLoad(e);
	    }

	    protected override void Dispose(bool disposing)
	    {
	        if (disposing)
	        {
	            Application.Idle -= Application_Idle;

                components?.Dispose();
            }

	        base.Dispose(disposing);
	    }

	    public bool CanCopy()
	    {
	        if (rtbQueryText.ContainsFocus)
	        {
	            if (rtbQueryText.SelectionLength > 0)
	            {
	                return true;
	            }
	        }

	        return false;
	    }

	    public bool CanCut()
	    {
	        if (rtbQueryText.ContainsFocus)
	        {
	            if (!String.IsNullOrEmpty(rtbQueryText.SelectedText))
	            {
	                return true;
	            }
	        }

	        return false;
	    }

	    public bool CanPaste()
	    {
	        if (rtbQueryText.ContainsFocus)
	        {
	            return Clipboard.ContainsText();
	        }

	        return false;
	    }

	    public bool CanUndo()
	    {
	        if (rtbQueryText.ContainsFocus)
	        {
	            return rtbQueryText.CanUndo;
	        }

	        return false;
	    }

	    public bool CanRedo()
	    {
	        if (rtbQueryText.ContainsFocus)
	        {
	            return rtbQueryText.CanRedo;
	        }

	        return false;
	    }

	    public bool CanSelectAll()
	    {
	        return (rtbQueryText.ContainsFocus && rtbQueryText.TextLength > 0);
	    }

	    public bool CanShowProperties()
	    {
	        return NavBar.ActiveUnionSubQuery != null;
	    }

	    public bool CanAddUnionSubQuery()
	    {
	        if (NavBar.ActiveUnionSubQuery == null)
	            return false;

	        if (NavBar.ActiveUnionSubQuery.QueryRoot.IsSubQuery)
	        {
	            return _sqlContext.SyntaxProvider.IsSupportSubQueryUnions();
	        }

	        return _sqlContext.SyntaxProvider.IsSupportUnions();
	    }

	    public bool CanCopyUnionSubQuery()
	    {
	        return CanAddUnionSubQuery();
	    }

        public bool CanAddDerivedTable()
        {
            if (NavBar.ActiveSubQuery != null && NavBar.ActiveUnionSubQuery.QueryRoot.IsMainQuery)
            {
                return _sqlContext.SyntaxProvider.IsSupportDerivedTables();
            }

            return _sqlContext.SyntaxProvider.IsSupportSubQueryDerivedTables();
        }

        public bool CanAddObject()
	    {
	        return QView.AddObjectDialog != null;
	    }

	    public void UpdateLanguage()
	    {
	        QView.Language = Program.Settings.Language;

	        tsbQueryProperties.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strEdit", "Properties");
	        tsbAddObject.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddObject", "Add object");
	        tsbAddDerivedTable.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddSubQuery", "Add derived table");
	        tsbAddUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strNewUnionSubQuery", "New union sub-query");
	        tsbCopyUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strCopyToNewUnionSubQuery", "Copy union sub-query");
        }

	    public void ParseQuery()
	    {
	        try
	        {
	            SqlQuery.SQL = rtbQueryText.Text;
	        }
	        catch (Exception ex)
	        {
	            MessageBox.Show(ex.Message);
	        }
	    }

	    public void ActivateBuildQueryTab()
	    {
	        tabControl1.SelectTab(0);
	        rtbQueryText.Focus();
	    }

	    public void ActivateRunQueryTab()
	    {
	        tabControl1.SelectTab(1);
	    }

	    public void ShowQueryStatistics()
	    {
	        QueryStatistics qs = SqlQuery.QueryStatistics;

	        var stats = "Used Objects (" + qs.UsedDatabaseObjects.Count + "):\r\n";
	        stats = qs.UsedDatabaseObjects.Aggregate(stats, (current, t) => current + ("\r\n" + t.ObjectName.QualifiedName));

	        stats += "\r\n\r\n" + "Used Columns (" + qs.UsedDatabaseObjectFields.Count + "):\r\n";
	        stats = qs.UsedDatabaseObjectFields.Aggregate(stats, (current, t) => current + ("\r\n" + t.ObjectName.QualifiedName));

	        stats += "\r\n\r\n" + "Output Expressions (" + qs.OutputColumns.Count + "):\r\n";
	        stats = qs.OutputColumns.Aggregate(stats, (current, t) => current + ("\r\n" + t.Expression));

	        using (QueryStatisticsForm f = new QueryStatisticsForm())
	        {
	            f.textBox.Text = stats;
	            f.ShowDialog();
	        }
	    }

	    public void Undo()
	    {
	        rtbQueryText.Undo();
	    }

	    public void Redo()
	    {
	        rtbQueryText.Undo();
	    }

	    public void Cut()
	    {
	        rtbQueryText.Cut();
	    }

	    public void Copy()
	    {
	        rtbQueryText.Copy();
	    }

	    public void Paste()
	    {
	        rtbQueryText.Paste();
	    }

	    public void SelectAll()
	    {
	        rtbQueryText.SelectAll();
	    }

	    public void AddObject()
        {
            QView.AddObjectDialog?.ShowModal();
        }

	    public void AddDerivedTable()
	    {
            using (new UpdateRegion(NavBar.ActiveUnionSubQuery.FromClause))
            {
                var sqlContext = NavBar.ActiveUnionSubQuery.SQLContext;

                var fq = new SQLFromQuery(sqlContext)
                {
                    Alias = new SQLAliasObjectAlias(sqlContext)
                    {
                        Alias = NavBar.ActiveUnionSubQuery.QueryRoot.CreateUniqueSubQueryName()
                    },
                    SubQuery = new SQLSubSelectStatement(sqlContext)
                };

                var sqse = new SQLSubQuerySelectExpression(sqlContext);
                fq.SubQuery.Add(sqse);
                sqse.SelectItems = new SQLSelectItems(sqlContext);
                sqse.From = new SQLFromClause(sqlContext);

                NavBar.Query.AddObject(NavBar.ActiveUnionSubQuery, fq, typeof(DataSourceQuery));
            }
        }

	    public void AddUnionSubQuery()
	    {
            NavBar.ActiveUnionSubQuery = QView.ActiveUnionSubQuery.ParentGroup.Add();
        }

	    public void CopyUnionSubQuery()
	    {
            // add empty UnionSubQuery
            var usq = QView.ActiveUnionSubQuery.ParentGroup.Add();

            // copy content
            var usqAst = QView.ActiveUnionSubQuery.ResultQueryAST;
            usqAst.RestoreColumnPrefixRecursive(true);

            var lCte = new List<SQLWithClauseItem>();
            var lFromObj = new List<SQLFromSource>();
            QView.ActiveUnionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, false);
            usqAst.PrepareAndFixupRecursive(lCte, lFromObj);

            usq.LoadFromAST(usqAst);
            NavBar.ActiveUnionSubQuery = usq;
        }

	    public void PropertiesQuery()
	    {
            QView.ShowActiveUnionSubQueryProperties();
	    }

	    public void RefreshMetadata()
	    {
	        if (_sqlContext.MetadataProvider != null && _sqlContext.MetadataProvider.Connected)
	        {
	            // to refresh metadata, just clear already loaded items
	            _sqlContext.MetadataContainer.Clear();
                _sqlContext.MetadataContainer.LoadAll(true);
	        }
	    }

	    public void EditMetadata()
	    {
	        QueryBuilder.EditMetadataContainer(_sqlContext);
	    }

	    public void ClearMetadata()
	    {
	        _sqlContext.MetadataContainer.Clear();
	    }

	    public void LoadMetadataFromXml()
	    {
	        OpenFileDialog fileDialog = new OpenFileDialog
	        {
	            Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*"
	        };

	        if (fileDialog.ShowDialog() == DialogResult.OK)
	        {
	            _sqlContext.MetadataContainer.LoadingOptions.OfflineMode = true;
	            _sqlContext.MetadataContainer.ImportFromXML(fileDialog.FileName);
	        }
	    }

	    public void SaveMetadataToXml()
	    {
	        SaveFileDialog fileDialog = new SaveFileDialog
	        {
	            Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*",
	            FileName = "Metadata.xml"
	        };
            if (fileDialog.ShowDialog() == DialogResult.OK)
	        {
	            _sqlContext.MetadataContainer.LoadAll(true);
	            _sqlContext.MetadataContainer.ExportToXML(fileDialog.FileName);
	        }
	    }

        private void SqlQuery_QueryAwake(QueryRoot sender, ref bool abort)
	    {
	        if (MessageBox.Show(@"You had typed something that is not a SELECT statement in the text editor and continued with visual query building." +
                                @"Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", @"Active Query Builder .NET Demo", MessageBoxButtons.YesNo) == DialogResult.No)
	        {
	            abort = true;
	        }
	    }

        private TabPage _tempTabCurrentSubquery;
        private TabPage _tempTabPreviewResult;

        private void SqlQuery_SleepModeChanged(object sender, EventArgs e)
	    {
	        labelSleepMode.Visible = SqlQuery.SleepMode;

	        if (SqlQuery.SleepMode)
	        {
	            _tempTabCurrentSubquery = tabControl2.TabPages[1];
	            _tempTabPreviewResult = tabControl2.TabPages[2];

	            tabControl2.TabPages.Remove(_tempTabCurrentSubquery);
	            tabControl2.TabPages.Remove(_tempTabPreviewResult);
	        }
	        else
	        {
	            tabControl2.TabPages.Add(_tempTabCurrentSubquery);
	            tabControl2.TabPages.Add(_tempTabPreviewResult);
	        }

            //  panelTextInfo.Height = SqlQuery.SleepMode ? 60 : 0;
            toolStripStatusLabel1.Text = @"Query builder state: " + ((SqlQuery.SleepMode) ? "Inactive" : "Active");
	    }

	    // Workaround for the old Microsoft's bug: ImageList damages the alpha channel of 32-bit ICO and PNG files.
	    // Clear all images from designed image lists and reload all images manually.
	    private void RepairImageLists()
	    {
	        imageList1.Images.Clear();
	        imageList1.Images.Add(Properties.Resources.bricks);
	        imageList1.Images.Add(Properties.Resources.database_go);

	        imageList2.Images.Clear();
	        imageList2.Images.Add(Properties.Resources.table);
	        imageList2.Images.Add(Properties.Resources.table_lightning);
	        imageList2.Images.Add(Properties.Resources.table_gear);
	        imageList2.Images.Add(Properties.Resources.table_sort);
	        imageList2.Images.Add(Properties.Resources.folder);
	        imageList2.Images.Add(Properties.Resources.table_multiple);
	        imageList2.Images.Add(Properties.Resources.database);

	        imageList3.Images.Clear();
	        imageList3.Images.Add(Properties.Resources.chart_organisation);
	        imageList3.Images.Add(Properties.Resources.folder_table);
	        imageList3.Images.Add(Properties.Resources.database_table);
	        imageList3.Images.Add(Properties.Resources.folder_bullet_green);
	        imageList3.Images.Add(Properties.Resources.bullet_green);
	    }

	    private void query_SQLUpdated(object sender, EventArgs e)
	    {
	        errorBox1.Show(null, _sqlContext.SyntaxProvider);
	        errorBoxCurrent.Show(null, _sqlContext.SyntaxProvider);

            _lastValidSql = rtbQueryText.Text = SqlQuery.SleepMode
	            ? SqlQuery.SQL
	            : FormattedQueryText;
	        if(_oldSql == null)
	        {
	            _oldSql = rtbQueryText.Text;
	        }

            buttonExportCsv.Enabled = buttonExportExcel.Enabled = buttonGenerateReport.Enabled =
                !string.IsNullOrEmpty(FormattedQueryText) && _sqlContext.MetadataProvider != null;

	        if (QueryView.ActiveUnionSubQuery == null || SqlQuery.SleepMode) return;
	        _lastValidSqlCurrent = TextBoxCurrentSubQuerySql.Text = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetResultSQL(_sqlFormattingOptions);
	        CheckParameters();
	    }

        private void CheckParameters()
        {
            if (SqlHelpers.CheckParameters(_sqlContext.MetadataProvider, _sqlContext.SyntaxProvider, SqlQuery.QueryParameters))
                HideParametersErrorPanel();
            else
            {
                var acceptableFormats =
                    SqlHelpers.GetAcceptableParametersFormats(_sqlContext.MetadataProvider, _sqlContext.SyntaxProvider);
                ShowParametersErrorPanel(acceptableFormats);
            }
        }

        private Control _parametersErrorPanel;
        private void ShowParametersErrorPanel(List<string> acceptableFormats)
        {
            HideParametersErrorPanel();
            _parametersErrorPanel = new Panel
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                BackColor = Color.LightPink,
                BorderStyle = BorderStyle.FixedSingle,
                Dock = DockStyle.Top,
                Padding = new Padding(6, 5, 3, 0),
            };

            var formats = acceptableFormats.Select(x =>
            {
                var s = x.Replace("n", "<number>");
                return s.Replace("s", "<name>");
            });

            string formatsString = string.Join(", ", formats);

            Label label = new Label
            {
                AutoSize = true,
                Margin = new Padding(0),
                Text = @"Unsupported parameter notation detected. For this type of connection and database server use " + formatsString,
                Dock = DockStyle.Fill,
                UseCompatibleTextRendering = true
            };

            _parametersErrorPanel.Controls.Add(label);
            _parametersErrorPanel.Visible = true;
            Controls.Add(_parametersErrorPanel);
        }

        private void HideParametersErrorPanel()
        {
            if (_parametersErrorPanel == null) return;
            _parametersErrorPanel.Visible = false;
            _parametersErrorPanel.Parent?.Controls.Remove(_parametersErrorPanel);
            _parametersErrorPanel.Dispose();
            _parametersErrorPanel = null;
        }

        private bool IsRecursionLoopInQueryText(string sql)
        {
            using (var query = _sqlContext.GetNewSqlQuery())
            {
                query.QueryRoot.AllowSleepMode = true;
                query.SQL = sql;

                return !query.SleepMode &&
                    UserMetadataStructureItem != null &&
                    query.QueryStatistics.UsedDatabaseObjects.Any(
                        x => x.MetadataObject == UserMetadataStructureItem.MetadataItem);
            }
        }

	    private void rtbQueryText_Validating(object sender, CancelEventArgs e)
	    {
			// We need to check that the new text doesn't have references to itself to avoid recursion on generating a query for the server.
	        try
	        {
                if (IsRecursionLoopInQueryText(rtbQueryText.Text))
                {
                    var message = "Recursion loop in virtual objects definition detected for object:\n" +
                         UserMetadataStructureItem.MetadataItem.GetQualifiedNameSQL(null, SqlGenerationOptions);

                    MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    rtbQueryText.Text = FormattedQueryText;
                    return;
                }
                // Update the query builder with manually edited query text:
                SqlQuery.SQL = rtbQueryText.Text;
	            errorBox1.Show(null, _sqlContext.SyntaxProvider);
	        }
	        catch (SQLParsingException ex)
	        {
	            // Set caret to error position
	            _errorPosition= rtbQueryText.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, _sqlContext.SyntaxProvider);
            }
	    }

	    private void Application_Idle(object sender, EventArgs e)
	    {
	        bool supportsDerivedTable = false;
	        bool supportsUnion = false;

	        if (_sqlContext.SyntaxProvider != null  && NavBar.ActiveUnionSubQuery != null)
	        {
	            if (NavBar.ActiveUnionSubQuery.QueryRoot.IsMainQuery)
	            {
	                supportsDerivedTable = _sqlContext.SyntaxProvider.IsSupportDerivedTables();
	            }
	            else
	            {
	                supportsDerivedTable = _sqlContext.SyntaxProvider.IsSupportSubQueryDerivedTables();
	            }
                supportsUnion = NavBar.ActiveUnionSubQuery.QueryRoot.IsSubQuery 
                    ? _sqlContext.SyntaxProvider.IsSupportSubQueryUnions() 
                    : _sqlContext.SyntaxProvider.IsSupportUnions();
	        }

	        tsbAddDerivedTable.Enabled = supportsDerivedTable;
	        tsbAddUnionSubquery.Enabled = supportsUnion;
	        tsbCopyUnionSubquery.Enabled = supportsUnion;
	    }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Execute a query on switching to the Data tab
            if (e.TabPage != pageQueryResult || SqlQuery.SleepMode)
            {
                return;
            }
            if (_hasError)
            {
                e.Cancel = true;
                return;
            }

            CBuilder.QueryTransformer.BeginUpdate();
            try
            {
                CBuilder.QueryTransformer.Skip(string.Empty);
                CBuilder.QueryTransformer.Take(string.Empty);
                CBuilder.QueryTransformer.NotifyUpdated();
            }
            finally
            {
                CBuilder.QueryTransformer.EndUpdate();
            }

            var sql = CBuilder.QueryTransformer.SQL;
         
            resultGrid1.FillDataGrid(sql);

            RefreshNoConnectionLabel();
        }

        private void contextMenuStripForRichTextBox_Opening(object sender, CancelEventArgs e)
	    {
	        tsmiUndo.Enabled = CanUndo();
	        tsmiRedo.Enabled = CanRedo();
	        tsmiCut.Enabled = CanCut();
	        tsmiCopy.Enabled = CanCopy();
	        tsmiPaste.Enabled = CanPaste();
	        tsmiSelectAll.Enabled = CanSelectAll();
	    }

	    private void tsmiUndo_Click(object sender, EventArgs e)
	    {
	        Undo();
	    }

	    private void tsmiRedo_Click(object sender, EventArgs e)
	    {
	        Redo();
	    }

	    private void tsmiCut_Click(object sender, EventArgs e)
	    {
	        Cut();
	    }

	    private void tsmiCopy_Click(object sender, EventArgs e)
	    {
	        Copy();
	    }

	    private void tsmiPaste_Click(object sender, EventArgs e)
	    {
	        Paste();
	    }

	    private void tsmiSelectAll_Click(object sender, EventArgs e)
	    {
	        SelectAll();
	    }

	    internal bool IsOfflineMode()
	    {
	        return _sqlContext.MetadataContainer.LoadingOptions.OfflineMode;
	    }

	    private void tsbQueryProperties_Click(object sender, EventArgs e)
	    {
	        PropertiesQuery();
	    }

	    private void tsbAddObject_Click(object sender, EventArgs e)
	    {
	        AddObject();
	    }

	    private void tsbAddDerivedTable_Click(object sender, EventArgs e)
	    {
	        AddDerivedTable();
	    }

	    private void tsbAddUnionSubquery_Click(object sender, EventArgs e)
	    {
	        AddUnionSubQuery();
	    }

	    private void tsbCopyUnionSubquery_Click(object sender, EventArgs e)
	    {
	        CopyUnionSubQuery();
	    }

	    private void CBuilder_SQLUpdated(object sender, EventArgs e)
	    {
			 if (Disposing) return;

            // Handle the event raised by Criteria Builder object that the text of SQL query is changed
            // update the text box
            if (tabControl1.SelectedTab != pageQueryResult)
            {
                return;
            }
            try
            {
                string sql = CBuilder.SQL;
                richTextBox1.Text = sql;

                resultGrid1.FillDataGrid(sql);
            }
            catch
            {
                //ignore
            }
	    }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            SaveQuery();
        }

        private void tsbSaveInFile_Click(object sender, EventArgs e)
        {
            SaveInFile();
        }        

        private void tsbSaveNewUserQuery_Click(object sender, EventArgs e)
        {
            SaveAsNewUserQuery();
        }

        private bool SaveQuery()
        {
            CancelEventArgs args = new CancelEventArgs();
            SaveQueryEvent?.Invoke(this, args);
            if(!args.Cancel)
            {
                _oldSql = FormattedQueryText;
            }
            return !args.Cancel;
        }

        private bool SaveAsNewUserQuery()
        {
            CancelEventArgs args = new CancelEventArgs();
            SaveAsNewUserQueryEvent?.Invoke(this, args);
            if (!args.Cancel)
            {
                _oldSql = FormattedQueryText;
                Text = FileSourcePath;
            }
            return !args.Cancel;
        }

        private bool SaveInFile()
        {
            CancelEventArgs args = new CancelEventArgs();
            SaveAsInFileEvent?.Invoke(this, args);
            if (!args.Cancel)
            {
                _oldSql = FormattedQueryText;
                Text = FileSourcePath;
            }
            return !args.Cancel;
        }

       
      

        private void RefreshNoConnectionLabel()
        {
            if (_connectionInfo != null)
            {
                if (_noConnectionLabel != null)
                {
                    resultGrid1.SizeChanged -= DataGridView1_SizeChanged;
                    _noConnectionLabel.Parent = null;
                    _noConnectionLabel = null;
                }
            }
            else if (_noConnectionLabel == null)
            {
                _noConnectionLabel = new NoConnectionLabel();
                resultGrid1.SizeChanged += DataGridView1_SizeChanged;
                resultGrid1.Controls.Add(_noConnectionLabel);
            }
        }

        private void DataGridView1_SizeChanged(object sender, EventArgs e)
        {
            Control parent = (Control)sender;
            int x = parent.Width / 2 - _noConnectionLabel.Width / 2;
            int y = parent.Height / 2 - _noConnectionLabel.Height / 2;
            _noConnectionLabel.Location = new Point(x > 0 ? x : 0, y > 0 ? y : 0);
        }

		/// <summary>
        /// Checking for loops on adding an object to the query
        /// </summary>
        private void QView_DataSourceAdding(MetadataObject fromObject, ref bool abort)
        {
            if (UserMetadataStructureItem == null) return;

            if (fromObject != UserMetadataStructureItem.MetadataItem) return;

            abort = true;

            var message = "Recursion loop in virtual objects definition detected for object:\n" +
                          UserMetadataStructureItem.MetadataItem.GetQualifiedNameSQL(null, SqlGenerationOptions);

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void OpenExecuteTab()
        {
            tabControl1.SelectedIndex = 1;
        }

        private void TextBoxCurrentSubQuerySql_TextChanged(object sender, EventArgs e)
        {
            if (!tabPageFastResult.Visible || string.IsNullOrEmpty(TextBoxCurrentSubQuerySql.Text) ||
                QView.ActiveUnionSubQuery == null)
            {
                errorBoxCurrent.Show(null, _sqlContext.SyntaxProvider);
                return;
            }
            
            FillFastViewDataGrid();
        }

        private void FillFastViewDataGrid()
        {
            if (tabControl2.SelectedTab != tabPageFastResult) return;

            try
            {                
                _queryTransformerTop10.Query =
                    new SQLQuery(QueryView.ActiveUnionSubQuery.ParentSubQuery.SQLContext) { SQL = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetSqlForDataPreview() };

                _timerForFastResult.Change(400, Timeout.Infinite);
            }
            catch
            {
               //ignore
            }
        }

        private void tabControl2_Selected(object sender, TabControlEventArgs e)
        {
            if (e.Action == TabControlAction.Selected && e.TabPage == tabPageFastResult)
            {
                FillFastViewDataGrid();
            }
        }


        private void TextBoxCurrentSubQuerySql_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                errorBoxCurrent.Show(null, _sqlContext.SyntaxProvider);

                // save active subquery
                var parent = QueryView.ActiveUnionSubQuery.ParentSubQuery;
                var items = QueryView.ActiveUnionSubQuery.ParentSubQuery.GetUnionSubQueryList();
                var idx = items.IndexOf(QueryView.ActiveUnionSubQuery);

                QueryView.ActiveUnionSubQuery.ParentSubQuery.SQL = TextBoxCurrentSubQuerySql.Text;

                // restore active subquery
                items = parent.GetUnionSubQueryList();
                QueryView.ActiveUnionSubQuery = idx != -1 ? items[idx] : items.First();
            }
            catch (SQLParsingException ex)
            {
                errorBoxCurrent.Show(ex.Message, _sqlContext.SyntaxProvider);
                _errorPositionCurrent = ex.ErrorPos.pos;
            }
        }

       

        private void errorBox1_RevertValidText(object sender, EventArgs e)
        {
            rtbQueryText.Text = _lastValidSql;
            rtbQueryText.Focus();
        }

        private void errorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                rtbQueryText.SelectionStart = _errorPosition;
                rtbQueryText.SelectionLength = 0;
                rtbQueryText.ScrollToPosition(_errorPosition);
            }

            rtbQueryText.Focus();
        }

        private void errorBoxCurrent_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                TextBoxCurrentSubQuerySql.SelectionStart = _errorPositionCurrent;
                TextBoxCurrentSubQuerySql.SelectionLength = 0;
                TextBoxCurrentSubQuerySql.ScrollToPosition(_errorPositionCurrent);
            }

            TextBoxCurrentSubQuerySql.Focus();
        }

        private void errorBoxCurrent_RevertValidText(object sender, EventArgs e)
        {
            TextBoxCurrentSubQuerySql.Text = _lastValidSql;
            TextBoxCurrentSubQuerySql.Focus();
        }

        private void CreateFastReport(DataTable dataTable)
        {
            if (dataTable == null)
                throw new ArgumentException(@"Argument cannot be null or empty.", "DataTable");

            var reportWindow =
                new FastReportForm(dataTable) { Owner = this };

            reportWindow.ShowDialog();
        }

        private void CreateStimulsoftReport(DataTable dataTable)
        {
            if (dataTable == null)
                throw new ArgumentException(@"Argument cannot be null or empty.", "DataTable");

            var reportWindow =
                new StimulsoftForm(dataTable) { Owner = this };

            reportWindow.ShowDialog();
        }

        private void CreateActiveReport(DataTable dataTable)
        {
            if (dataTable == null)
                throw new ArgumentException(@"Argument cannot be null or empty.", "DataTable");

            var reportWindow =
                new ActiveReportsForm(dataTable) { Owner = this };

            reportWindow.ShowDialog();
        }

        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            var window = new CreateReportForm { Owner = this };

            DialogResult result = window.ShowDialog();

            if (result != DialogResult.OK || window.SelectedReportType == null) return;
            var dataTable = SqlHelpers.GetDataTable(CBuilder.SQL, SqlQuery);

            switch (window.SelectedReportType)
            {
                case ReportType.ActiveReports14:
                    CreateActiveReport(dataTable);
                    break;
                case ReportType.Stimulsoft:
                    CreateStimulsoftReport(dataTable);
                    break;
                case ReportType.FastReport:
                    CreateFastReport(dataTable);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            var dt = SqlHelpers.GetDataTable(CBuilder.SQL, SqlQuery);

            var saveDialog = new SaveFileDialog { AddExtension = true, DefaultExt = "xlsx", FileName = "Export.xlsx" };
            if (saveDialog.ShowDialog(this) != DialogResult.OK) return;

            ExportHelpers.ExportToExcel(dt, saveDialog.FileName);
        }

        private void buttonExportCsv_Click(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog { AddExtension = true, DefaultExt = "csv", FileName = "Data.csv" };
            var result = saveDialog.ShowDialog(this);
            if (result != DialogResult.OK) return;

            var dt = SqlHelpers.GetDataTable(CBuilder.SQL, SqlQuery);
            ExportHelpers.ExportToCSV(dt, saveDialog.FileName);
        }
    }
}
