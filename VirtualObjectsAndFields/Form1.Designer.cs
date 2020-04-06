namespace VirtualObjectsAndFields
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
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess2 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.sqlFormattingOptions1 = new ActiveQueryBuilder.Core.SQLFormattingOptions();
            this.sqlFormattingOptions2 = new ActiveQueryBuilder.Core.SQLFormattingOptions();
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.errorBoxReal = new GeneralAssembly.Common.SqlErrorBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlFormattingOptions1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlFormattingOptions2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList16.Images.SetKeyName(0, "0.bmp");
            this.imageList16.Images.SetKeyName(1, "1.bmp");
            this.imageList16.Images.SetKeyName(2, "2.bmp");
            this.imageList16.Images.SetKeyName(3, "3.bmp");
            this.imageList16.Images.SetKeyName(4, "4.bmp");
            this.imageList16.Images.SetKeyName(5, "5.bmp");
            this.imageList16.Images.SetKeyName(6, "6.bmp");
            this.imageList16.Images.SetKeyName(7, "7.bmp");
            this.imageList16.Images.SetKeyName(8, "8.bmp");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMetadataToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editMetadataToolStripMenuItem
            // 
            this.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem";
            this.editMetadataToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.editMetadataToolStripMenuItem.Text = "Edit Metadata...";
            this.editMetadataToolStripMenuItem.Click += new System.EventHandler(this.editMetadataToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList32.Images.SetKeyName(0, "0.bmp");
            this.imageList32.Images.SetKeyName(1, "1.bmp");
            this.imageList32.Images.SetKeyName(2, "2.bmp");
            // 
            // queryBuilder
            // 
            this.queryBuilder.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder.DatabaseSchemaViewOptions.ImageList = null;
            this.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Image)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder.DataSourceOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess2.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess2.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess2.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess2.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2;
            this.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.MetadataStructureOptions.ProceduresFolderText = null;
            this.queryBuilder.MetadataStructureOptions.SynonymsFolderText = null;
            this.queryBuilder.MetadataStructureOptions.TablesFolderText = null;
            this.queryBuilder.MetadataStructureOptions.ViewsFolderText = null;
            this.queryBuilder.Name = "queryBuilder";
            this.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true;
            this.queryBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.queryBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.queryBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.queryBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 140D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 200D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 250D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 100D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 100D;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3;
            this.queryBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 60D;
            this.queryBuilder.QueryColumnListOptions.Font = null;
            this.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.queryBuilder.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.queryBuilder.Size = new System.Drawing.Size(793, 316);
            // 
            // 
            // 
            this.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.DynamicIndents = false;
            this.queryBuilder.SQLFormattingOptions.DynamicRightMargin = false;
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // 
            // 
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder.TabIndex = 0;
            this.queryBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.queryBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.queryBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White;
            this.queryBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White;
            this.queryBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.queryBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.queryBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.queryBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.queryBuilder.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 83);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(793, 447);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 127);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.errorBox1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(785, 101);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Query text with virtual objects and fields";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(779, 95);
            this.textBox1.TabIndex = 1;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.errorBoxReal);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(785, 101);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Real query text with virtual objects expanded to their expressions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.HideSelection = false;
            this.textBox2.Location = new System.Drawing.Point(3, 3);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(779, 95);
            this.textBox2.TabIndex = 2;
            this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 4);
            this.panel1.Size = new System.Drawing.Size(793, 59);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(669, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // sqlFormattingOptions1
            // 
            this.sqlFormattingOptions1.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.DynamicIndents = false;
            this.sqlFormattingOptions1.DynamicRightMargin = false;
            this.sqlFormattingOptions1.ExpandVirtualFields = false;
            this.sqlFormattingOptions1.ExpandVirtualObjects = false;
            this.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.sqlFormattingOptions1.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            this.sqlFormattingOptions1.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.KeywordFormat = ActiveQueryBuilder.Core.KeywordFormat.UpperCase;
            this.sqlFormattingOptions1.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions1.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // sqlFormattingOptions2
            // 
            this.sqlFormattingOptions2.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.DynamicIndents = false;
            this.sqlFormattingOptions2.DynamicRightMargin = false;
            this.sqlFormattingOptions2.ExpandVirtualFields = true;
            this.sqlFormattingOptions2.ExpandVirtualObjects = true;
            this.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.sqlFormattingOptions2.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            this.sqlFormattingOptions2.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.sqlFormattingOptions2.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(462, 32);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(298, 61);
            this.errorBox1.TabIndex = 2;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.ErrorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.ErrorBox1_RevertValidText);
            // 
            // errorBoxReal
            // 
            this.errorBoxReal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBoxReal.AutoSize = true;
            this.errorBoxReal.BackColor = System.Drawing.Color.LightPink;
            this.errorBoxReal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBoxReal.CurrentSyntaxProvider = null;
            this.errorBoxReal.IsVisibleCheckSyntaxPanel = false;
            this.errorBoxReal.Location = new System.Drawing.Point(475, 34);
            this.errorBoxReal.Name = "errorBoxReal";
            this.errorBoxReal.Padding = new System.Windows.Forms.Padding(5);
            this.errorBoxReal.Size = new System.Drawing.Size(282, 61);
            this.errorBoxReal.TabIndex = 3;
            this.errorBoxReal.Visible = false;
            this.errorBoxReal.GoToErrorPosition += new System.EventHandler(this.ErrorBoxReal_GoToErrorPosition);
            this.errorBoxReal.RevertValidText += new System.EventHandler(this.ErrorBoxReal_RevertValidText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VirtualObjectsAndFields Demo";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlFormattingOptions1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sqlFormattingOptions2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ImageList imageList32;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ToolStripMenuItem editMetadataToolStripMenuItem;
        private ActiveQueryBuilder.Core.SQLFormattingOptions sqlFormattingOptions1;
        private ActiveQueryBuilder.Core.SQLFormattingOptions sqlFormattingOptions2;
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
        private GeneralAssembly.Common.SqlErrorBox errorBoxReal;
    }
}

