using System.Windows.Forms;

namespace SubQueryTextEditingDemo
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
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.breadcrumbControl1 = new ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryBreadcrumbsBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new GeneralAssembly.DataViewerControl.DataViewer();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mssqlMetadataProvider1 = new ActiveQueryBuilder.Core.MSSQLMetadataProvider(this.components);
            this.oledbMetadataProvider1 = new ActiveQueryBuilder.Core.OLEDBMetadataProvider(this.components);
            this.odbcMetadataProvider1 = new ActiveQueryBuilder.Core.ODBCMetadataProvider(this.components);
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemConnectTo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.fillProgrammaticallyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.loadMetadataFromXMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMetadataToXMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStatisticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.genericSyntaxProvider1 = new ActiveQueryBuilder.Core.GenericSyntaxProvider(this.components);
            this.mssqlSyntaxProvider1 = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider(this.components);
            this.oracleSyntaxProvider1 = new ActiveQueryBuilder.Core.OracleSyntaxProvider(this.components);
            this.msaccessSyntaxProvider1 = new ActiveQueryBuilder.Core.MSAccessSyntaxProvider(this.components);
            this.cmEditMode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiEntire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSubQuery = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExpression = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLGenerationOptions)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageData.SuspendLayout();
            this.mainMenu1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.cmEditMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 45);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1031, 475);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.splitContainer1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 24);
            this.tabPageSQL.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageSQL.Size = new System.Drawing.Size(1023, 447);
            this.tabPageSQL.TabIndex = 0;
            this.tabPageSQL.Text = "SQL";
            this.tabPageSQL.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(4, 3);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(1015, 441);
            this.splitContainer1.SplitterDistance = 308;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder1.AddObjectDialogOptions.StartWithDefaultNamespaceType = ActiveQueryBuilder.Core.MetadataType.Database;
            this.queryBuilder1.AddObjectDialogOptions.StartWithMetadataStructurePath = null;
            this.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder1.DatabaseSchemaViewOptions.ImageList = null;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black;
            this.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
    
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewDock = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = false;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.queryBuilder1.PanesConfigurationOptions.QueryColumnsPaneHeight = 135;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.queryBuilder1.QueryColumnListOptions.Font = null;
            this.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.queryBuilder1.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryBuilder1.QueryNavBarOptions.ActionButtonBackColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.ActionButtonBorderColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.AddCteCircleColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.queryBuilder1.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.queryBuilder1.QueryNavBarOptions.DragIndicatorColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.DragIndicatorHoverColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryBuilder1.QueryNavBarOptions.ForeColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.GraphLineColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.GroupBackColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.GroupTextColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.queryBuilder1.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.queryBuilder1.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.queryBuilder1.QueryNavBarOptions.SubQueryItemBackColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.SubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.SubQueryMarkerColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.SubQueryPopupBackColor = System.Drawing.Color.Empty;
            this.queryBuilder1.QueryNavBarOptions.TextHoverColor = System.Drawing.Color.Empty;
            this.queryBuilder1.Size = new System.Drawing.Size(1015, 308);
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
            this.queryBuilder1.TabIndex = 0;
            this.queryBuilder1.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.queryBuilder1.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.queryBuilder1.VisualOptions.DockPanelBackColor = System.Drawing.Color.Empty;
            this.queryBuilder1.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.VisualOptions.DockTabFontColor = System.Drawing.Color.White;
            this.queryBuilder1.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White;
            this.queryBuilder1.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.queryBuilder1.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.queryBuilder1.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.queryBuilder1.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.queryBuilder1.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(638, 47);
            this.errorBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.errorBox1.Size = new System.Drawing.Size(352, 79);
            this.errorBox1.TabIndex = 2;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.errorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.errorBox1_RevertValidText);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(1015, 98);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.breadcrumbControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1015, 30);
            this.panel2.TabIndex = 1;
            // 
            // breadcrumbControl1
            // 
            this.breadcrumbControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breadcrumbControl1.Location = new System.Drawing.Point(14, 0);
            this.breadcrumbControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.breadcrumbControl1.Name = "breadcrumbControl1";
            this.breadcrumbControl1.Options.ActionButtonBackColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.ActionButtonBorderColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.AddCteCircleColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.breadcrumbControl1.Options.DragIndicatorColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.DragIndicatorHoverColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.Font = null;
            this.breadcrumbControl1.Options.ForeColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.GraphLineColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.GroupBackColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.GroupTextColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.breadcrumbControl1.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.breadcrumbControl1.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.breadcrumbControl1.Options.SubQueryItemBackColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.SubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.SubQueryMarkerColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Options.TextHoverColor = System.Drawing.Color.Empty;
            this.breadcrumbControl1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.breadcrumbControl1.QueryView = null;
            this.breadcrumbControl1.Size = new System.Drawing.Size(1001, 30);
            this.breadcrumbControl1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(14, 30);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Location = new System.Drawing.Point(4, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(6, 6);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Location = new System.Drawing.Point(4, 24);
            this.tabPageData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPageData.Size = new System.Drawing.Size(1023, 423);
            this.tabPageData.TabIndex = 1;
            this.tabPageData.Text = "Data";
            this.tabPageData.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSize = true;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.QueryTransformer = null;
            this.dataGridView1.Size = new System.Drawing.Size(1015, 417);
            this.dataGridView1.SqlQuery = null;
            this.dataGridView1.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // mssqlMetadataProvider1
            // 
            this.mssqlMetadataProvider1.Connection = null;
            // 
            // oledbMetadataProvider1
            // 
            this.oledbMetadataProvider1.Connection = null;
            // 
            // odbcMetadataProvider1
            // 
            this.odbcMetadataProvider1.Connection = null;
            this.odbcMetadataProvider1.IgnoreSchemaOnlyFlag = false;
            this.odbcMetadataProvider1.SkipLoadFieldsFromGetSchema = false;
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem1,
            this.menuItem3,
            this.queryStatisticsMenuItem,
            this.propertiesMenuItem,
            this.aboutMenuItem});
            this.mainMenu1.Location = new System.Drawing.Point(0, 45);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu1.Size = new System.Drawing.Size(1031, 24);
            this.mainMenu1.TabIndex = 4;
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemConnectTo,
            this.menuItem2,
            this.fillProgrammaticallyMenuItem});
            this.menuItem1.Name = "menuItem1";
            this.menuItem1.Size = new System.Drawing.Size(64, 20);
            this.menuItem1.Text = "Connect";
            // 
            // menuItemConnectTo
            // 
            this.menuItemConnectTo.Name = "menuItemConnectTo";
            this.menuItemConnectTo.Size = new System.Drawing.Size(279, 22);
            this.menuItemConnectTo.Text = "Connect to...";
            this.menuItemConnectTo.Click += new System.EventHandler(this.menuItemConnectTo_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Name = "menuItem2";
            this.menuItem2.Size = new System.Drawing.Size(276, 6);
            // 
            // fillProgrammaticallyMenuItem
            // 
            this.fillProgrammaticallyMenuItem.Name = "fillProgrammaticallyMenuItem";
            this.fillProgrammaticallyMenuItem.Size = new System.Drawing.Size(279, 22);
            this.fillProgrammaticallyMenuItem.Text = "Fill the query builder programmatically";
            this.fillProgrammaticallyMenuItem.Click += new System.EventHandler(this.fillProgrammaticallyMenuItem_Click);
            // 
            // menuItem3
            // 
            this.menuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMetadataMenuItem,
            this.editMetadataMenuItem,
            this.clearMetadataMenuItem,
            this.menuItem4,
            this.loadMetadataFromXMLMenuItem,
            this.saveMetadataToXMLMenuItem});
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(69, 20);
            this.menuItem3.Text = "Metadata";
            // 
            // refreshMetadataMenuItem
            // 
            this.refreshMetadataMenuItem.Name = "refreshMetadataMenuItem";
            this.refreshMetadataMenuItem.Size = new System.Drawing.Size(218, 22);
            this.refreshMetadataMenuItem.Text = "Refresh Metadata";
            this.refreshMetadataMenuItem.Click += new System.EventHandler(this.refreshMetadataMenuItem_Click);
            // 
            // editMetadataMenuItem
            // 
            this.editMetadataMenuItem.Name = "editMetadataMenuItem";
            this.editMetadataMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editMetadataMenuItem.Text = "Edit Metadata...";
            this.editMetadataMenuItem.Click += new System.EventHandler(this.editMetadataMenuItem_Click);
            // 
            // clearMetadataMenuItem
            // 
            this.clearMetadataMenuItem.Name = "clearMetadataMenuItem";
            this.clearMetadataMenuItem.Size = new System.Drawing.Size(218, 22);
            this.clearMetadataMenuItem.Text = "Clear Metadata";
            this.clearMetadataMenuItem.Click += new System.EventHandler(this.clearMetadataMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(215, 6);
            // 
            // loadMetadataFromXMLMenuItem
            // 
            this.loadMetadataFromXMLMenuItem.Name = "loadMetadataFromXMLMenuItem";
            this.loadMetadataFromXMLMenuItem.Size = new System.Drawing.Size(218, 22);
            this.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML...";
            this.loadMetadataFromXMLMenuItem.Click += new System.EventHandler(this.loadMetadataFromXMLMenuItem_Click);
            // 
            // saveMetadataToXMLMenuItem
            // 
            this.saveMetadataToXMLMenuItem.Name = "saveMetadataToXMLMenuItem";
            this.saveMetadataToXMLMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML...";
            this.saveMetadataToXMLMenuItem.Click += new System.EventHandler(this.saveMetadataToXMLMenuItem_Click);
            // 
            // queryStatisticsMenuItem
            // 
            this.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem";
            this.queryStatisticsMenuItem.Size = new System.Drawing.Size(109, 20);
            this.queryStatisticsMenuItem.Text = "Query Statistics...";
            this.queryStatisticsMenuItem.Click += new System.EventHandler(this.queryStatisticsMenuItem_Click);
            // 
            // propertiesMenuItem
            // 
            this.propertiesMenuItem.Name = "propertiesMenuItem";
            this.propertiesMenuItem.Size = new System.Drawing.Size(81, 20);
            this.propertiesMenuItem.Text = "Properties...";
            this.propertiesMenuItem.Click += new System.EventHandler(this.propertiesMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(61, 20);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(7, 6, 4, 0);
            this.panel1.Size = new System.Drawing.Size(1031, 45);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoEllipsis = true;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(269, 22);
            this.linkLabel1.Location = new System.Drawing.Point(7, 6);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(836, 37);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.Text = resources.GetString("linkLabel1.Text");
            this.linkLabel1.UseCompatibleTextRendering = true;
            // 
            // genericSyntaxProvider1
            // 
            this.genericSyntaxProvider1.DetectServerVersion = false;
            this.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.genericSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.DetectServerVersion = true;
            this.mssqlSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // oracleSyntaxProvider1
            // 
            this.oracleSyntaxProvider1.DetectServerVersion = true;
            this.oracleSyntaxProvider1.OnCalcExpressionType = null;
            this.oracleSyntaxProvider1.ServerVersion = ActiveQueryBuilder.Core.OracleServerVersion.Oracle10;
            // 
            // msaccessSyntaxProvider1
            // 
            this.msaccessSyntaxProvider1.DetectServerVersion = false;
            this.msaccessSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.msaccessSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // cmEditMode
            // 
            this.cmEditMode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEntire,
            this.tsmiSubQuery,
            this.tsmiExpression});
            this.cmEditMode.Name = "contextMenuStrip1";
            this.cmEditMode.Size = new System.Drawing.Size(318, 70);
            // 
            // tsmiEntire
            // 
            this.tsmiEntire.CheckOnClick = true;
            this.tsmiEntire.Name = "tsmiEntire";
            this.tsmiEntire.Size = new System.Drawing.Size(317, 22);
            this.tsmiEntire.Text = "Edit the entire SQL query text";
            this.tsmiEntire.CheckedChanged += new System.EventHandler(this.tsmiEntire_CheckedChanged);
            // 
            // tsmiSubQuery
            // 
            this.tsmiSubQuery.CheckOnClick = true;
            this.tsmiSubQuery.Name = "tsmiSubQuery";
            this.tsmiSubQuery.Size = new System.Drawing.Size(317, 22);
            this.tsmiSubQuery.Text = "Edit text of the current sub-Query";
            this.tsmiSubQuery.CheckedChanged += new System.EventHandler(this.tsmiSubQuery_CheckedChanged);
            // 
            // tsmiExpression
            // 
            this.tsmiExpression.CheckOnClick = true;
            this.tsmiExpression.Name = "tsmiExpression";
            this.tsmiExpression.Size = new System.Drawing.Size(317, 22);
            this.tsmiExpression.Text = "Edit text of the current SELECT Expression only";
            this.tsmiExpression.CheckedChanged += new System.EventHandler(this.tsmiExpression_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 520);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.mainMenu1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Active Query Builder for .NET WinForms Edition - General Demo (C#)";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageData.ResumeLayout(false);
            this.tabPageData.PerformLayout();
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.cmEditMode.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSQL;
		private System.Windows.Forms.TabPage tabPageData;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBox1;
		private GeneralAssembly.DataViewerControl.DataViewer dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private ActiveQueryBuilder.Core.GenericSyntaxProvider genericSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSSQLMetadataProvider mssqlMetadataProvider1;
		private ActiveQueryBuilder.Core.OLEDBMetadataProvider oledbMetadataProvider1;
		private ActiveQueryBuilder.Core.ODBCMetadataProvider odbcMetadataProvider1;
		private ActiveQueryBuilder.Core.OracleSyntaxProvider oracleSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSAccessSyntaxProvider msaccessSyntaxProvider1;
		private System.Windows.Forms.MenuStrip mainMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripSeparator menuItem2;
		private System.Windows.Forms.ToolStripMenuItem fillProgrammaticallyMenuItem;
		private System.Windows.Forms.ToolStripMenuItem menuItem3;
		private System.Windows.Forms.ToolStripMenuItem refreshMetadataMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMetadataMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearMetadataMenuItem;
		private System.Windows.Forms.ToolStripSeparator menuItem4;
		private System.Windows.Forms.ToolStripMenuItem loadMetadataFromXMLMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveMetadataToXMLMenuItem;
		private System.Windows.Forms.ToolStripMenuItem propertiesMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem queryStatisticsMenuItem;
		private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryBreadcrumbsBar breadcrumbControl1;
        private System.Windows.Forms.ContextMenuStrip cmEditMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntire;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpression;
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
        private System.Windows.Forms.ToolStripMenuItem menuItemConnectTo;
    }
}

