using System.Drawing;
using ActiveQueryBuilder.View;

namespace BasicDemo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.expressionEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(this.components);
            this.labelSleepMode = new System.Windows.Forms.Label();
            this.errorBox1 = new BasicDemo.Common.ErrorBox();
            this.sqlTextEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.genericSyntaxProvider1 = new ActiveQueryBuilder.Core.GenericSyntaxProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mssqlSyntaxProvider1 = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider(this.components);
            this.mssqlMetadataProvider1 = new ActiveQueryBuilder.Core.MSSQLMetadataProvider(this.components);
            this.oledbMetadataProvider1 = new ActiveQueryBuilder.Core.OLEDBMetadataProvider(this.components);
            this.oracleMetadataProvider1 = new ActiveQueryBuilder.Core.OracleNativeMetadataProvider(this.components);
            this.odbcMetadataProvider1 = new ActiveQueryBuilder.Core.ODBCMetadataProvider(this.components);
            this.oracleSyntaxProvider1 = new ActiveQueryBuilder.Core.OracleSyntaxProvider(this.components);
            this.msaccessSyntaxProvider1 = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.fillProgrammaticallyMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.refreshMetadataMenuItem = new System.Windows.Forms.MenuItem();
            this.editMetadataMenuItem = new System.Windows.Forms.MenuItem();
            this.clearMetadataMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.loadMetadataFromXMLMenuItem = new System.Windows.Forms.MenuItem();
            this.saveMetadataToXMLMenuItem = new System.Windows.Forms.MenuItem();
            this.queryStatisticsMenuItem = new System.Windows.Forms.MenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLGenerationOptions)).BeginInit();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(884, 538);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.splitContainer1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(876, 512);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder1);
            this.splitContainer1.Panel1.Controls.Add(this.labelSleepMode);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorBox1);
            this.splitContainer1.Panel2.Controls.Add(this.sqlTextEditor1);
            this.splitContainer1.Size = new System.Drawing.Size(870, 506);
            this.splitContainer1.SplitterDistance = 355;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.AddObjectDialogOptions.Size = new System.Drawing.Size(400, 400);
            this.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder1.DatabaseSchemaViewOptions.ImageList = null;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Image)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder1.DataSourceOptions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.ExpressionEditor = this.expressionEditor1;
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 201;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.queryBuilder1.QueryColumnListOptions.AlternateRowColor = System.Drawing.SystemColors.Highlight;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100D;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3;
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60D;
            this.queryBuilder1.QueryColumnListOptions.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.queryBuilder1.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText;
            this.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.queryBuilder1.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.queryBuilder1.Size = new System.Drawing.Size(870, 317);
            // 
            // 
            // 
            this.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.DynamicIndents = false;
            this.queryBuilder1.SQLFormattingOptions.DynamicRightMargin = false;
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // 
            // 
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder1.SQLGenerationOptions.UseAltNames = false;
            this.queryBuilder1.TabIndex = 3;
            this.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.queryBuilder1.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.VisualOptions.DockTabFontColor = System.Drawing.Color.White;
            this.queryBuilder1.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White;
            this.queryBuilder1.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.queryBuilder1.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.SleepModeChanged += new System.EventHandler(this.queryBuilder1_SleepModeChanged);
            this.queryBuilder1.QueryAwake += new ActiveQueryBuilder.Core.QueryAwakeEventHandler(this.queryBuilder1_QueryAwake);
            this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
            // 
            // expressionEditor1
            // 
            this.expressionEditor1.ActiveUnionSubQuery = null;
            this.expressionEditor1.BackColor = System.Drawing.Color.White;
            this.expressionEditor1.CloseOnEscape = false;
            this.expressionEditor1.Expression = "";
            this.expressionEditor1.Height = 0;
            this.expressionEditor1.HighlightMatchingParentheses = ActiveQueryBuilder.View.ExpressionEditor.ParenthesesHighlighting.NoHighlight;
            this.expressionEditor1.KeepMetadataObjectsOnTopOfSuggestionList = true;
            this.expressionEditor1.LoadMetadataOnCodeCompletion = true;
            this.expressionEditor1.SearchFields = false;
            this.expressionEditor1.TextColor = System.Drawing.SystemColors.ControlText;
            this.expressionEditor1.TextEditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.expressionEditor1.Width = 0;
            // 
            // labelSleepMode
            // 
            this.labelSleepMode.AutoEllipsis = true;
            this.labelSleepMode.BackColor = System.Drawing.Color.Bisque;
            this.labelSleepMode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelSleepMode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSleepMode.Location = new System.Drawing.Point(0, 317);
            this.labelSleepMode.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelSleepMode.Name = "labelSleepMode";
            this.labelSleepMode.Padding = new System.Windows.Forms.Padding(10);
            this.labelSleepMode.Size = new System.Drawing.Size(870, 38);
            this.labelSleepMode.TabIndex = 2;
            this.labelSleepMode.Text = "Unsupported SQL statement. Visual Query Builder has been disabled. Either type a " +
    "SELECT statement or start building a query visually to turn this mode off.";
            this.labelSleepMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelSleepMode.Visible = false;
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.Location = new System.Drawing.Point(511, 44);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(354, 100);
            this.errorBox1.TabIndex = 1;
            this.errorBox1.Visible = false;
            this.errorBox1.SyntaxProviderChanged += new System.EventHandler(this.errorBox1_SyntaxProviderChanged);
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.errorBox1_GoToErrorPositionEvent);
            this.errorBox1.RevertValidText += new System.EventHandler(this.errorBox1_RevertValidTextEvent);
            this.errorBox1.IsVisibleCheckSyntaxPanel = true;
            // 
            // sqlTextEditor1
            // 
            this.sqlTextEditor1.AcceptTabs = false;
            this.sqlTextEditor1.AllowShowSuggestionByMouse = false;
            this.sqlTextEditor1.BackColor = System.Drawing.Color.White;
            this.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqlTextEditor1.CaretOffset = 0;
            this.sqlTextEditor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlTextEditor1.Location = new System.Drawing.Point(0, 0);
            this.sqlTextEditor1.Name = "sqlTextEditor1";
            this.sqlTextEditor1.Options.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqlTextEditor1.Options.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlTextEditor1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.sqlTextEditor1.Query = null;
            this.sqlTextEditor1.QueryProvider = null;
            this.sqlTextEditor1.SelectedText = "";
            this.sqlTextEditor1.SelectionLength = 0;
            this.sqlTextEditor1.SelectionStart = 0;
            this.sqlTextEditor1.Size = new System.Drawing.Size(870, 147);
            this.sqlTextEditor1.SQLContext = null;
            this.sqlTextEditor1.SqlOptions.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.sqlTextEditor1.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.sqlTextEditor1.TabIndex = 0;
            this.sqlTextEditor1.Validating += new System.ComponentModel.CancelEventHandler(this.sqlTextEditor1_Validating);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(876, 512);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(870, 506);
            this.dataGridView1.TabIndex = 0;
            // 
            // genericSyntaxProvider1
            // 
            this.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.genericSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // mssqlMetadataProvider1
            // 
            this.mssqlMetadataProvider1.Connection = null;
            // 
            // oledbMetadataProvider1
            // 
            this.oledbMetadataProvider1.Connection = null;
            // 
            // oracleMetadataProvider1
            // 
            this.oracleMetadataProvider1.Connection = null;
            // 
            // odbcMetadataProvider1
            // 
            this.odbcMetadataProvider1.Connection = null;
            // 
            // oracleSyntaxProvider1
            // 
            this.oracleSyntaxProvider1.OnCalcExpressionType = null;
            this.oracleSyntaxProvider1.ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle10;
            // 
            // msaccessSyntaxProvider1
            // 
            this.msaccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.msaccessSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem3,
            this.queryStatisticsMenuItem,
            this.propertiesMenuItem,
            this.aboutMenuItem});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem5,
            this.menuItem2,
            this.fillProgrammaticallyMenuItem});
            this.menuItem1.Text = "Connect";
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 0;
            this.menuItem5.Text = "Connect...";
            this.menuItem5.Click += new System.EventHandler(this.menuItem5_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "-";
            // 
            // fillProgrammaticallyMenuItem
            // 
            this.fillProgrammaticallyMenuItem.Index = 2;
            this.fillProgrammaticallyMenuItem.Text = "Fill the query builder programmatically";
            this.fillProgrammaticallyMenuItem.Click += new System.EventHandler(this.fillProgrammaticallyMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 1;
            this.menuItem3.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.refreshMetadataMenuItem,
            this.editMetadataMenuItem,
            this.clearMetadataMenuItem,
            this.menuItem4,
            this.loadMetadataFromXMLMenuItem,
            this.saveMetadataToXMLMenuItem});
            this.menuItem3.Text = "Metadata";
            // 
            // refreshMetadataMenuItem
            // 
            this.refreshMetadataMenuItem.Index = 0;
            this.refreshMetadataMenuItem.Text = "Refresh Metadata";
            this.refreshMetadataMenuItem.Click += new System.EventHandler(this.refreshMetadataMenuItem_Click);
            // 
            // editMetadataMenuItem
            // 
            this.editMetadataMenuItem.Index = 1;
            this.editMetadataMenuItem.Text = "Edit Metadata...";
            this.editMetadataMenuItem.Click += new System.EventHandler(this.editMetadataMenuItem_Click);
            // 
            // clearMetadataMenuItem
            // 
            this.clearMetadataMenuItem.Index = 2;
            this.clearMetadataMenuItem.Text = "Clear Metadata";
            this.clearMetadataMenuItem.Click += new System.EventHandler(this.clearMetadataMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 3;
            this.menuItem4.Text = "-";
            // 
            // loadMetadataFromXMLMenuItem
            // 
            this.loadMetadataFromXMLMenuItem.Index = 4;
            this.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML...";
            this.loadMetadataFromXMLMenuItem.Click += new System.EventHandler(this.loadMetadataFromXMLMenuItem_Click);
            // 
            // saveMetadataToXMLMenuItem
            // 
            this.saveMetadataToXMLMenuItem.Index = 5;
            this.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML...";
            this.saveMetadataToXMLMenuItem.Click += new System.EventHandler(this.saveMetadataToXMLMenuItem_Click);
            // 
            // queryStatisticsMenuItem
            // 
            this.queryStatisticsMenuItem.Index = 2;
            this.queryStatisticsMenuItem.Text = "Query Statistics...";
            this.queryStatisticsMenuItem.Click += new System.EventHandler(this.queryStatisticsMenuItem_Click);
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Index = 3;
            this.propertiesMenuItem.Text = "Properties...";
            this.propertiesMenuItem.Click += new System.EventHandler(this.propertiesMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 4;
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 5, 3, 0);
            this.panel1.Size = new System.Drawing.Size(884, 37);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(269, 22);
            this.linkLabel1.Location = new System.Drawing.Point(6, 5);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(773, 30);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 575);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Query Builder for .NET WinForms Edition - Basic Demo (C#)";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1)).EndInit();
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSQL;
		private System.Windows.Forms.TabPage tabPageData;
		private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor sqlTextEditor1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private ActiveQueryBuilder.Core.GenericSyntaxProvider genericSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSSQLMetadataProvider mssqlMetadataProvider1;
		private ActiveQueryBuilder.Core.OLEDBMetadataProvider oledbMetadataProvider1;
		private ActiveQueryBuilder.Core.OracleNativeMetadataProvider oracleMetadataProvider1;
		private ActiveQueryBuilder.Core.ODBCMetadataProvider odbcMetadataProvider1;
		private ActiveQueryBuilder.Core.OracleSyntaxProvider oracleSyntaxProvider1;
        private ActiveQueryBuilder.Core.MSAccessSyntaxProvider msaccessSyntaxProvider1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem fillProgrammaticallyMenuItem;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem refreshMetadataMenuItem;
		private System.Windows.Forms.MenuItem editMetadataMenuItem;
		private System.Windows.Forms.MenuItem clearMetadataMenuItem;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem loadMetadataFromXMLMenuItem;
		private System.Windows.Forms.MenuItem saveMetadataToXMLMenuItem;
		private System.Windows.Forms.MenuItem propertiesMenuItem;
		private System.Windows.Forms.MenuItem aboutMenuItem;
		private System.Windows.Forms.MenuItem queryStatisticsMenuItem;
		private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor expressionEditor1;
        private System.Windows.Forms.MenuItem menuItem5;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
        private System.Windows.Forms.Label labelSleepMode;
        private Common.ErrorBox errorBox1;
    }
}
