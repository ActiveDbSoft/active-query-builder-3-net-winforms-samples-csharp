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
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ActiveQueryBuilder.Core;
using ActiveQueryBuilder.Core.QueryTransformer;
using ActiveQueryBuilder.View.QueryView;
using ActiveQueryBuilder.View.WinForms;
using GeneralAssembly;
using GeneralAssembly.Dailogs;
using GeneralAssembly.Forms;
using GeneralAssembly.Forms.QueryInformationForms;
using GeneralAssembly.QueryBuilderProperties;
using AboutForm = GeneralAssembly.Forms.AboutForm;
using Helpers = ActiveQueryBuilder.Core.Helpers;
using BuildInfo = ActiveQueryBuilder.Core.BuildInfo;

namespace FullFeaturedDemo
{
    public partial class MainForm : Form
    {
        private int _errorPosition = -1;
        private string _lastValidSql;

        private ConnectionInfo _selectedConnection;
        private readonly SQLFormattingOptions _sqlFormattingOptions;
        
        private string _fileSourcePath;
        private string _oldSql;
        private NoConnectionLabel _noConnectionLabel;

        public MainForm()
        {
            InitializeComponent();

            // DEMO WARNING
            if (BuildInfo.GetEdition() == BuildInfo.Edition.Trial)
            {
                Panel trialNoticePanel = new Panel
                {
                    AutoSize = true,
                    AutoSizeMode = AutoSizeMode.GrowAndShrink,
                    BackColor = Color.LightGreen,
                    BorderStyle = BorderStyle.FixedSingle,
                    Dock = DockStyle.Top,
                    Padding = new Padding(6, 5, 3, 0),
                };

                Label label = new Label
                {
                    AutoSize = true,
                    Margin = new Padding(0),
                    Text =
                        @"Generation of random aliases for the query output columns is the limitation of the trial version. The full version is free from this behavior.",
                    Dock = DockStyle.Fill,
                    UseCompatibleTextRendering = true
                };

                var buttonClose = new PictureBox
                {
                    Image = Properties.Resources.cancel, SizeMode = PictureBoxSizeMode.AutoSize, Cursor = Cursors.Hand
                };
                buttonClose.Click += delegate { Controls.Remove(trialNoticePanel); };

                trialNoticePanel.Controls.Add(buttonClose);

                trialNoticePanel.Resize += delegate
                {
                    buttonClose.Location = new Point(trialNoticePanel.Width - buttonClose.Width - 10,
                        trialNoticePanel.Height / 2 - buttonClose.Height / 2);
                };

                trialNoticePanel.Controls.Add(label);
                Controls.Add(trialNoticePanel);

                Controls.SetChildIndex(trialNoticePanel, 2);
            }

            // Options to present the formatted SQL query text to end-user
            // Use names of virtual objects, do not replace them with appropriate derived tables
            _sqlFormattingOptions = new SQLFormattingOptions();
            _sqlFormattingOptions.Updated += _sqlFormattingOptions_Updated;

            // Options to generate the SQL query text for execution against a database server
            // Replace virtual objects with derived tables
            queryBuilder1.SQLGenerationOptions = new SQLGenerationOptions { ExpandVirtualObjects = true };

            if (Program.Settings.WindowPlacement == Rectangle.Empty)
                StartPosition = FormStartPosition.WindowsDefaultLocation;
            else
                Bounds = Program.Settings.WindowPlacement;

            if (Program.Settings.IsMaximized)
                WindowState = FormWindowState.Maximized;

            queryBuilder1.SyntaxProvider = new GenericSyntaxProvider();
            queryBuilder1.SQLQuery.QueryRoot.AllowSleepMode = true;
            CBuilder.QueryTransformer = new QueryTransformer
            {
                Query = queryBuilder1.SQLQuery,
                SQLGenerationOptions = _sqlFormattingOptions
            };
            CBuilder.QueryTransformer.SQLUpdated += CBuilder_SQLUpdated;

            LoadLanguages();

            queryBuilder1.SleepModeChanged += SqlQuery_SleepModeChanged;
            queryBuilder1.QueryAwake += SqlQuery_QueryAwake;
            SizeChanged += MainForm_SizeChanged;
            LocationChanged += MainForm_LocationChanged;
            Application.Idle += Application_Idle;
            UpdateLanguage();

            dataViewer.SqlQuery = queryBuilder1.SQLQuery;
            dataViewer.QueryTransformer = CBuilder.QueryTransformer;
        }

        public string FormattedQueryText => FormattedSQLBuilder.GetSQL(queryBuilder1.SQLQuery.QueryRoot, _sqlFormattingOptions);

        private void LoadMetadataFromXml()
        {
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = true;
                queryBuilder1.MetadataContainer.ImportFromXML(fileDialog.FileName);
                queryBuilder1.InitializeDatabaseSchemaTree();
            }
        }

        private void SaveMetadataToXml()
        {
            SaveFileDialog fileDialog = new SaveFileDialog
            {
                Filter = @"XML files (*.xml)|*.xml|All files (*.*)|*.*",
                FileName = "Metadata.xml"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                queryBuilder1.MetadataContainer.LoadAll(true);
                queryBuilder1.MetadataContainer.ExportToXML(fileDialog.FileName);
            }
        }

        public void UpdateLanguage()
        {
            queryBuilder1.Language = Program.Settings.Language;
            tsbQueryProperties.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strEdit", "Properties");
            tsbAddObject.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddObject", "Add object");
            tsbAddDerivedTable.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strAddSubQuery", "Add derived table");
            tsbAddUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strNewUnionSubQuery", "New union sub-query");
            tsbCopyUnionSubquery.ToolTipText = ActiveQueryBuilder.View.Helpers.Localizer.GetString("strCopyToNewUnionSubQuery", "Copy union sub-query");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // ReSharper disable once MergeSequentialChecks
                queryBuilder1?.MetadataProvider?.Connection?.Close();
                Application.Idle -= Application_Idle;
                components?.Dispose();
            }

            base.Dispose(disposing);
        }

        private void LoadLanguages()
        {
            foreach (string language in Helpers.Localizer.Languages)
            {
                string lang = language.ToLower();
                ToolStripItem menuItem;
                if (lang == "auto")
                {
                    menuItem = tsmiLanguageAuto;
                }
                else if (lang == "default")
                {
                    menuItem = tsmiLanguageDefault;
                }
                else
                {
                    CultureInfo culture = CultureInfo.GetCultureInfo(lang);
                    menuItem = languageToolStripMenuItem.DropDownItems.Add(culture.NativeName, null, Language_Click);
                    menuItem.Tag = lang;
                }
                if (string.Equals(menuItem.Tag as string, Program.Settings.Language, StringComparison.OrdinalIgnoreCase))
                {
                    ((ToolStripMenuItem)menuItem).Checked = true;
                }
            }
        }

        private void InitializeSqlContext()
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                BaseMetadataProvider metadataProvider = null;
                BaseSyntaxProvider syntaxSyntaxProvider;

                // create new SqlConnection object using the connections string from the connection form
                if (!_selectedConnection.IsXmlFile)
                {
                    syntaxSyntaxProvider = _selectedConnection.ConnectionDescriptor.SyntaxProvider;
                    metadataProvider = _selectedConnection.ConnectionDescriptor.MetadataProvider;
                }
                else
                {
                    switch (_selectedConnection.Type)
                    {
                        case ConnectionTypes.MSSQL:
                            syntaxSyntaxProvider = new MSSQLSyntaxProvider();
                            break;
                        case ConnectionTypes.MSAccess:
                            syntaxSyntaxProvider = new MSAccessSyntaxProvider();
                            break;
                        case ConnectionTypes.Oracle:
                            syntaxSyntaxProvider = new OracleSyntaxProvider();
                            break;
                        case ConnectionTypes.MySQL:
                            syntaxSyntaxProvider = new MySQLSyntaxProvider();
                            break;
                        case ConnectionTypes.PostgreSQL:
                            syntaxSyntaxProvider = new PostgreSQLSyntaxProvider();
                            break;
                        case ConnectionTypes.OLEDB:
                            syntaxSyntaxProvider = new SQL92SyntaxProvider();
                            break;
                        case ConnectionTypes.ODBC:
                            syntaxSyntaxProvider = new SQL92SyntaxProvider();
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }
                }

                // setup the query builder with metadata and syntax providers
                queryBuilder1.SQLContext.MetadataContainer.Clear();
                queryBuilder1.MetadataProvider = metadataProvider;
                queryBuilder1.SyntaxProvider = syntaxSyntaxProvider;
                queryBuilder1.MetadataLoadingOptions.OfflineMode = metadataProvider == null;

                if (metadataProvider == null)
                    queryBuilder1.MetadataContainer.ImportFromXML(_selectedConnection.ConnectionString);

                // Instruct the query builder to fill the database schema tree
                queryBuilder1.InitializeDatabaseSchemaTree();

                toolStripStatusLabel1.Text = @"Query builder state: " + (queryBuilder1.SleepMode ? "Inactive" : "Active");
                RepairImageLists();
                RefreshNoConnectionLabel();                

                queryBuilder1.QueryView.UserPredefinedConditions.Clear();

                queryBuilder1.QueryView.UserPredefinedConditions.Add(
                    new PredefinedCondition(
                        "Check range",
                        null,
                        "Between 10 AND 100",
                        false));
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        public bool CanAddUnionSubQuery
        {
            get
            {
                if (queryBuilder1.ActiveUnionSubQuery != null && queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsSubQuery)
                {
                    return queryBuilder1.SyntaxProvider.IsSupportSubQueryUnions();
                }
                return queryBuilder1.SyntaxProvider != null && queryBuilder1.SyntaxProvider.IsSupportUnions();
            }
        }

        public bool CanCopyUnionSubQuery => CanAddUnionSubQuery;

        public bool CanAddDerivedTable
        {
            get
            {
                if (queryBuilder1.SyntaxProvider == null)
                {
                    return false;
                }
                if (queryBuilder1.ActiveUnionSubQuery != null && queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsMainQuery)
                {
                    return queryBuilder1.SyntaxProvider.IsSupportDerivedTables();
                }
                return queryBuilder1.SyntaxProvider != null && queryBuilder1.SyntaxProvider.IsSupportSubQueryDerivedTables();
            }
        }

        private bool CanAddObject => queryBuilder1.AddObjectDialog != null;

        // Workaround for the old Microsoft's bug: ImageList damages the alpha channel of 32-bit ICO and PNG files.
        // Clear all images from designed image lists and reload all images manually.
        private void RepairImageLists()
        {
            imageList1.Images.Clear();
            imageList1.Images.Add(Properties.Resources.bricks);
            imageList1.Images.Add(Properties.Resources.database_go);
        }

        private void Language_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem currentItem = sender as ToolStripMenuItem;
            if (currentItem == null || Equals(currentItem.Tag, Helpers.Localizer.Language))
            {
                return;
            }
            ToolStripMenuItem checkedItem = languageToolStripMenuItem.DropDownItems.OfType<ToolStripMenuItem>().FirstOrDefault(item => item.Checked);
            if (checkedItem != null)
            {
                checkedItem.Checked = false;
            }
            Program.Settings.Language = (string)currentItem.Tag;
            UpdateLanguage();
            currentItem.Checked = true;
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            tsmiParseQuery.Enabled = true;
            tsmiUndo.Enabled = CanUndo;
            tsmiRedo.Enabled = CanRedo;
            tsmiCut.Enabled = CanCut;
            tsmiCopy.Enabled = CanCopy;
            tsmiPaste.Enabled = CanPaste;
            tsmiSelectAll.Enabled = CanSelectAll;
            tsbCut.Enabled = CanCut;
            tsbCopy.Enabled = CanCopy;
            tsbPaste.Enabled = CanPaste;

            editUserPredefinedConditionsToolStripMenuItem.Enabled = queryBuilder1.SyntaxProvider != null;

            tsmiSave.Enabled = true;
            tsmiBuildQuery.Enabled = true;
            tsmiRunQuery.Enabled = true;
            tsmiQueryStatistics.Enabled = true;
            toolStripButtonNewQuery.Enabled = newQueryToolStripMenuItem1.Enabled = queryBuilder1.SQLContext != null;
            tsbQueryProperties.Enabled = queryBuilder1.SQLContext != null;
            tsbSave.Enabled = queryBuilder1.SQLContext != null;
            tsbAddObject.Enabled = queryBuilder1.SQLContext != null;
            tsbSaveInFile.Enabled = queryBuilder1.SQLContext != null;
            tabControl1.Enabled = queryBuilder1.SQLContext != null;
            tsmiOfflineMode.Enabled = true;
            tsmiOfflineMode.Checked = queryBuilder1.SQLContext == null || queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode;
            tsmiRefreshMetadata.Enabled = true;
            tsmiEditMetadata.Enabled = true;
            tsmiClearMetadata.Enabled = true;
            tsmiLoadMetadataFromXML.Enabled = true;
            tsmiSaveMetadataToXML.Enabled = true;

            addDerivedTableToolStripMenuItem.Enabled = CanAddDerivedTable;
            addObjectToolStripMenuItem.Enabled = CanAddObject;
            addUnionSubqueryToolStripMenuItem.Enabled = CanAddUnionSubQuery;
            copyUnionSubwueryToolStripMenuItem.Enabled = CanCopyUnionSubQuery;

            tsbEditMetadata.Enabled = queryBuilder1.SQLContext != null && queryBuilder1.MetadataContainer != null;

            bool supportsDerivedTable = false;
            bool supportsUnion = false;

            if (queryBuilder1.ActiveUnionSubQuery != null && queryBuilder1.SQLContext != null && queryBuilder1.SyntaxProvider != null)
            {
                supportsDerivedTable = queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsMainQuery
                    ? queryBuilder1.SyntaxProvider.IsSupportDerivedTables()
                    : queryBuilder1.SyntaxProvider.IsSupportSubQueryDerivedTables();
                supportsUnion = queryBuilder1.ActiveUnionSubQuery.QueryRoot.IsSubQuery
                    ? queryBuilder1.SyntaxProvider.IsSupportSubQueryUnions()
                    : queryBuilder1.SyntaxProvider.IsSupportUnions();
            }
            tsbAddDerivedTable.Enabled = supportsDerivedTable;
            tsbAddUnionSubquery.Enabled = supportsUnion;
            tsbCopyUnionSubquery.Enabled = supportsUnion;
        }

        private void SqlQuery_QueryAwake(QueryRoot sender, ref bool abort)
        {
            if (MessageBox.Show(@"You had typed something that is not a SELECT statement in the text editor and continued with visual query building." +
                @"Whatever the text in the editor is, it will be replaced with the SQL generated by the component. Is it right?", @"Active Query Builder .NET Demo", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                abort = true;
            }
        }

        private void SqlQuery_SleepModeChanged(object sender, EventArgs e)
        {
            panelSleepMode.Visible = queryBuilder1.SleepMode;
            toolStripStatusLabel1.Text = @"Query builder state: " + (queryBuilder1.SleepMode ? "Inactive" : "Active");
        }

        private void CBuilder_SQLUpdated(object sender, EventArgs e)
        {
            // Handle the event raised by Criteria Builder object that the text of SQL query is changed
            // update the text box
            if (tabControl1.SelectedTab != pageQueryResult)
            {
                return;
            }
            try
            {
                string sql = CBuilder.SQL;
                teResultSql.Text = sql;
                ExecuteQuery(sql);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void tsmiNew_Click(object sender, EventArgs e)
        {
            string query = queryBuilder1.SQL;
            if (Connect())
            {
                Clear();
                queryBuilder1.SQL = query;
            }
        }

        private bool Connect()
        {
            using (ConnectionForm cf = new ConnectionForm())
            {
                if (cf.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Cursor = Cursors.WaitCursor;
                        _selectedConnection = cf.SelectedConnection;
                        InitializeSqlContext();
                        return true;
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
            return false;
        }

        private void tsmiOpen_Click(object sender, EventArgs e)
        {
            // open a saved query
            if (!TrySave())
            {
                return;
            }
            if ((_selectedConnection == null && !Connect()) || openFileDialog1.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            StringBuilder sb = new StringBuilder();
            using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    sb.AppendLine(s);
                }
            }
            _fileSourcePath = openFileDialog1.FileName;

            // load query to the query builder by assigning its text to the SQL property
            queryBuilder1.SQL = sb.ToString();
            _oldSql = FormattedQueryText;
        }

        private void tsmiSave_Click(object sender, EventArgs e)
        {
            string path = SaveInFile(_fileSourcePath);
            if (path != null)
            {
                _fileSourcePath = path;
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Maximized)
            {
                Program.Settings.WindowPlacement = Bounds;
            }
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (Program.Settings.IsMaximized != (WindowState == FormWindowState.Maximized))
            {
                Program.Settings.IsMaximized = (WindowState == FormWindowState.Maximized);
            }

            if (!Program.Settings.IsMaximized)
            {
                Program.Settings.WindowPlacement = Bounds;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!TrySave())
            {
                e.Cancel = true;
            }
        }

        private void tsmiBuildQuery_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(0);
            teSql.Focus();
        }

        private void tsmiRunQuery_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void tsmiQueryStatistics_Click(object sender, EventArgs e)
        {
            QueryStatistics qs = queryBuilder1.QueryStatistics;

            string stats = "Used Objects (" + qs.UsedDatabaseObjects.Count + "):\r\n";
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

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            using (AboutForm f = new AboutForm())
            {
                f.ShowDialog();
            }
        }

        public void Undo()
        {
            teSql.Undo();
        }

        public void Redo()
        {
            teSql.Undo();
        }

        public void Cut()
        {
            teSql.Cut();
        }

        public void Copy()
        {
            teSql.Copy();
        }

        public void Paste()
        {
            teSql.Paste();
        }

        public void SelectAll()
        {
            teSql.SelectAll();
        }

        public bool CanCopy
        {
            get
            {
                if (teSql.ContainsFocus)
                {
                    if (teSql.SelectionLength > 0)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool CanCut
        {
            get
            {
                if (teSql.ContainsFocus)
                {
                    if (!string.IsNullOrEmpty(teSql.SelectedText))
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool CanPaste
        {
            get
            {
                if (teSql.ContainsFocus)
                {
                    return Clipboard.ContainsText();
                }
                return false;
            }
        }

        public bool CanUndo
        {
            get
            {
                if (teSql.ContainsFocus)
                {
                    return teSql.CanUndo;
                }
                return false;
            }
        }

        public bool CanRedo
        {
            get
            {
                if (teSql.ContainsFocus)
                {
                    return teSql.CanRedo;
                }
                return false;
            }
        }

        public bool CanSelectAll
        {
            get
            {
                return teSql.ContainsFocus && teSql.TextLength > 0;
            }
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

        private void tsmiOfflineMode_Click(object sender, EventArgs e)
        {
            if (tsmiOfflineMode.Checked)
            {
                try
                {
                    Cursor = Cursors.WaitCursor;

                    queryBuilder1.MetadataContainer.LoadAll(true);
                }
                finally
                {
                    Cursor = Cursors.Arrow;
                }
            }

            queryBuilder1.MetadataContainer.LoadingOptions.OfflineMode = tsmiOfflineMode.Checked;
        }

        private void tsmiRefreshMetadata_Click(object sender, EventArgs e)
        {
            if (queryBuilder1.MetadataProvider != null && queryBuilder1.MetadataProvider.Connected)
            {
                // Force the query builder to refresh metadata from current connection
                // to refresh metadata, just clear MetadataContainer and reinitialize metadata tree
                queryBuilder1.MetadataContainer.Clear();
                queryBuilder1.InitializeDatabaseSchemaTree();
            }
        }

        private void tsmiEditMetadata_Click(object sender, EventArgs e)
        {
            QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext);
        }

        private void tsmiClearMetadata_Click(object sender, EventArgs e)
        {
            queryBuilder1.MetadataContainer.Clear();
        }

        private void tsmiLoadMetadataFromXML_Click(object sender, EventArgs e)
        {
            LoadMetadataFromXml();
        }

        private void tsmiSaveMetadataToXML_Click(object sender, EventArgs e)
        {
            SaveMetadataToXml();
        }

        private void tsmiLanguageAuto_Click(object sender, EventArgs e)
        {
            Program.Settings.Language = "Auto";
            UpdateLanguage();
        }

        private void tsmiLanguageDefault_Click(object sender, EventArgs e)
        {
            Program.Settings.Language = "Default";
            UpdateLanguage();
        }

        private void newQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            if (!TrySave())
            {
                return;
            }
            queryBuilder1.SQL = "";
            _oldSql = null;
            _fileSourcePath = null;
        }

        private bool TrySave()
        {
            if (_oldSql != null && _oldSql != FormattedQueryText)
            {
                SaveDialogForm dialog = new SaveDialogForm(_fileSourcePath ?? "new file");
                if (dialog.ShowDialog() != DialogResult.OK)
                {
                    return false;
                }
                if (dialog.Save)
                {
                    SaveInFile(_fileSourcePath);
                }
            }
            return true;
        }

        private string SaveInFile(string path)
        {
            // Save the query text to file
            if (path != null && FormattedQueryText == _oldSql)
            {
                return path;
            }
            if (string.IsNullOrEmpty(path))
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    DefaultExt = "sql",
                    FileName = "query",
                    Filter = @"SQL query files (*.sql)|*.sql|All files|*.*"
                };
                if (saveFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return path;
                }
                path = saveFileDialog.FileName;
            }
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(FormattedQueryText);
                _oldSql = FormattedQueryText;
            }
            return path;
        }

        private void addDerivedTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tsbAddDerivedTable_Click(null, EventArgs.Empty);
        }

        private void tsbAddDerivedTable_Click(object sender, EventArgs e)
        {
            using (new UpdateRegion(queryBuilder1.ActiveUnionSubQuery.FromClause))
            {
                var sqlContext = queryBuilder1.ActiveUnionSubQuery.SQLContext;

                var fq = new SQLFromQuery(sqlContext)
                {
                    Alias = new SQLAliasObjectAlias(sqlContext)
                    {
                        Alias = queryBuilder1.ActiveUnionSubQuery.QueryRoot.CreateUniqueSubQueryName()
                    },
                    SubQuery = new SQLSubSelectStatement(sqlContext)
                };

                var sqse = new SQLSubQuerySelectExpression(sqlContext);
                fq.SubQuery.Add(sqse);
                sqse.SelectItems = new SQLSelectItems(sqlContext);
                sqse.From = new SQLFromClause(sqlContext);
                queryBuilder1.SQLQuery.AddObject(queryBuilder1.ActiveUnionSubQuery, fq, typeof(DataSourceQuery));
            }
        }

        private void tsbAddObject_Click(object sender, EventArgs e)
        {
            if (queryBuilder1.AddObjectDialog != null)
            {
                queryBuilder1.AddObjectDialog.ShowModal();
            }
        }

        private void tsbQueryProperties_Click(object sender, EventArgs e)
        {
            queryBuilder1.ShowActiveUnionSubQueryProperties();
        }

        private void tsbCopyUnionSubquery_Click(object sender, EventArgs e)
        {
            // add empty UnionSubQuery
            UnionSubQuery usq = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add();

            // copy the content of existing union sub-query to a new one
            SQLSubQuerySelectExpression usqAst = queryBuilder1.ActiveUnionSubQuery.ResultQueryAST;
            usqAst.RestoreColumnPrefixRecursive(true);

            List<SQLWithClauseItem> lCte = new List<SQLWithClauseItem>();
            List<SQLFromSource> lFromObj = new List<SQLFromSource>();
            queryBuilder1.ActiveUnionSubQuery.GatherPrepareAndFixupContext(lCte, lFromObj, false);
            usqAst.PrepareAndFixupRecursive(lCte, lFromObj);

            usq.LoadFromAST(usqAst);
            queryBuilder1.ActiveUnionSubQuery = usq;
        }

        private void addUnionSubQueryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            queryBuilder1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add();
        }

        private void propertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var propWindow = new QueryBuilderPropertiesForm(queryBuilder1);
            propWindow.ShowDialog();
        }

        private void tsbEditMetadata_Click(object sender, EventArgs e)
        {
            QueryBuilder.EditMetadataContainer(queryBuilder1.SQLContext);
        }

        private void tsbSaveInFile_Click(object sender, EventArgs e)
        {
            string path = SaveInFile(null);
            if (path != null)
                _fileSourcePath = path;
        }

        private void tsbAddUnionSubquery_Click(object sender, EventArgs e)
        {
            queryBuilder1.ActiveUnionSubQuery = queryBuilder1.ActiveUnionSubQuery.ParentGroup.Add();
        }

        private void queryBuilder1_SQLUpdated(object sender, EventArgs e)
        {
            errorBox1.Show(null, queryBuilder1.SyntaxProvider);
            _lastValidSql = teSql.Text = queryBuilder1.SleepMode ? queryBuilder1.SQL : FormattedQueryText;
        }

        private void _sqlFormattingOptions_Updated(object sender, EventArgs e)
        {
            teSql.Text = FormattedQueryText;
        }

        private void contextMenuStripForRichTextBox_Opening(object sender, CancelEventArgs e)
        {
            tsmiUndo.Enabled = CanUndo;
            tsmiRedo.Enabled = CanRedo;
            tsmiCut.Enabled = CanCut;
            tsmiCopy.Enabled = CanCopy;
            tsmiPaste.Enabled = CanPaste;
            tsmiSelectAll.Enabled = CanSelectAll;
        }

        private void teQbSql_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                // Update the query builder with manually edited query text:
                queryBuilder1.SQL = teSql.Text;
                errorBox1.Show(null, queryBuilder1.SyntaxProvider);
            }
            catch (SQLParsingException ex)
            {
                // Set caret to error position
                _errorPosition = teSql.SelectionStart = ex.ErrorPos.pos;

                // Show banner with error text
                errorBox1.Show(ex.Message, queryBuilder1.SyntaxProvider);
            }
        }

        private void tsmiParseQuery_Click(object sender, EventArgs e)
        {
            try
            {
                queryBuilder1.SQL = teSql.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void RefreshNoConnectionLabel()
        {
            if (_selectedConnection != null)
            {
                if (_noConnectionLabel != null)
                {
                    dataViewer.SizeChanged -= DataViewerSizeChanged;
                    _noConnectionLabel.Parent = null;
                    _noConnectionLabel = null;
                }
            }
            else if (_noConnectionLabel == null)
            {
                _noConnectionLabel = new NoConnectionLabel();
                dataViewer.SizeChanged += DataViewerSizeChanged;
                dataViewer.Controls.Add(_noConnectionLabel);
            }
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            // Execute a query on switching to the Data tab
            if (e.TabPage != pageQueryResult)
            {
                return;
            }

            CBuilder.Clear();
            
            teResultSql.Text = queryBuilder1.FormattedSQL;
            ExecuteQuery(queryBuilder1.FormattedSQL);
            RefreshNoConnectionLabel();
        }

        private void ExecuteQuery(string sql)
        {
            dataViewer.FillDataGrid(sql);
        }

        private void DataViewerSizeChanged(object sender, EventArgs e)
        {
            Control parent = (Control)sender;
            int x = parent.Width / 2 - _noConnectionLabel.Width / 2;
            int y = parent.Height / 2 - _noConnectionLabel.Height / 2;
            _noConnectionLabel.Location = new Point(x > 0 ? x : 0, y > 0 ? y : 0);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Connect();
        }

        private void errorBox1_GoToErrorPosition(object sender, EventArgs e)
        {
            if (_errorPosition != -1)
            {
                teSql.SelectionStart = _errorPosition;
                teSql.SelectionLength = 0;
                teSql.ScrollToCaret();
            }

            teSql.Focus();
        }

        private void errorBox1_RevertValidText(object sender, EventArgs e)
        {
            teSql.Text = _lastValidSql;
            teSql.Focus();
        }

        private void editUserExpressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var form = new EditUserExpressionForm())
            {
                form.LoadUserConditions(queryBuilder1.QueryView);
                form.StartPosition = FormStartPosition.CenterParent;
                form.ShowDialog(this);
            }
        }
    }
}
