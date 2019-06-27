namespace SubQueryResultsPreview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess2 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rbQuery = new System.Windows.Forms.RadioButton();
            this.rbSubQuery = new System.Windows.Forms.RadioButton();
            this.rbUnionSubQuery = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToMicrosoftSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToOracleServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectToDatabaseThroughOLEDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToDatabaseThroughODBCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageQueryText = new System.Windows.Forms.TabPage();
            this.tabPageResultsPreview = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.errorBox1 = new SubQueryResultsPreview.Common.ErrorBox();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageQueryText.SuspendLayout();
            this.tabPageResultsPreview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // queryBuilder
            // 
            this.queryBuilder.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder.DatabaseSchemaViewOptions.ImageList = null;
            this.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Image)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess2.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess2.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess2.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess2.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess2.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess2;
            this.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder.Location = new System.Drawing.Point(12, 99);
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
            this.queryBuilder.QueryColumnListOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.queryBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.queryBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.queryBuilder.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.queryBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.queryBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.queryBuilder.Size = new System.Drawing.Size(926, 392);
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
            this.queryBuilder.TabIndex = 3;
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
            this.queryBuilder.ActiveUnionSubQueryChanged += new System.EventHandler(this.queryBuilder_ActiveUnionSubQueryChanged);
            this.queryBuilder.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F);
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(912, 127);
            this.textBox1.TabIndex = 4;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // rbQuery
            // 
            this.rbQuery.AutoSize = true;
            this.rbQuery.ForeColor = System.Drawing.Color.Maroon;
            this.rbQuery.Location = new System.Drawing.Point(136, 27);
            this.rbQuery.Name = "rbQuery";
            this.rbQuery.Size = new System.Drawing.Size(72, 17);
            this.rbQuery.TabIndex = 0;
            this.rbQuery.TabStop = true;
            this.rbQuery.Text = "Full Query";
            this.rbQuery.UseVisualStyleBackColor = true;
            this.rbQuery.CheckedChanged += new System.EventHandler(this.QueryPartChanged);
            // 
            // rbSubQuery
            // 
            this.rbSubQuery.AutoSize = true;
            this.rbSubQuery.ForeColor = System.Drawing.Color.Maroon;
            this.rbSubQuery.Location = new System.Drawing.Point(136, 50);
            this.rbSubQuery.Name = "rbSubQuery";
            this.rbSubQuery.Size = new System.Drawing.Size(73, 17);
            this.rbSubQuery.TabIndex = 1;
            this.rbSubQuery.TabStop = true;
            this.rbSubQuery.Text = "Sub-query";
            this.rbSubQuery.UseVisualStyleBackColor = true;
            this.rbSubQuery.CheckedChanged += new System.EventHandler(this.QueryPartChanged);
            // 
            // rbUnionSubQuery
            // 
            this.rbUnionSubQuery.AutoSize = true;
            this.rbUnionSubQuery.ForeColor = System.Drawing.Color.Maroon;
            this.rbUnionSubQuery.Location = new System.Drawing.Point(136, 73);
            this.rbUnionSubQuery.Margin = new System.Windows.Forms.Padding(3, 3, 3, 6);
            this.rbUnionSubQuery.Name = "rbUnionSubQuery";
            this.rbUnionSubQuery.Size = new System.Drawing.Size(102, 17);
            this.rbUnionSubQuery.TabIndex = 2;
            this.rbUnionSubQuery.TabStop = true;
            this.rbUnionSubQuery.Text = "Union sub-query";
            this.rbUnionSubQuery.UseVisualStyleBackColor = true;
            this.rbUnionSubQuery.CheckedChanged += new System.EventHandler(this.QueryPartChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(244, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(627, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Show only tabs related to selected UNION; show text of selected UNION only. Acts " +
    "like the previous mode if select a sub-query tab.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(244, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Show only tabs related to selected sub-query; show text of selected sub-query onl" +
    "y.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Show all subquery tabs and the full query text.";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToMicrosoftSQLServerToolStripMenuItem,
            this.connectToOracleServerToolStripMenuItem,
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem,
            this.toolStripSeparator1,
            this.connectToDatabaseThroughOLEDBToolStripMenuItem,
            this.connectToDatabaseThroughODBCToolStripMenuItem});
            this.connectToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 20);
            this.connectToolStripMenuItem.Text = "Connect Database";
            // 
            // connectToMicrosoftSQLServerToolStripMenuItem
            // 
            this.connectToMicrosoftSQLServerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectToMicrosoftSQLServerToolStripMenuItem.Name = "connectToMicrosoftSQLServerToolStripMenuItem";
            this.connectToMicrosoftSQLServerToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.connectToMicrosoftSQLServerToolStripMenuItem.Text = "Connect to Microsoft SQL Server";
            this.connectToMicrosoftSQLServerToolStripMenuItem.Click += new System.EventHandler(this.connectToMicrosoftSQLServerToolStripMenuItem_Click);
            // 
            // connectToOracleServerToolStripMenuItem
            // 
            this.connectToOracleServerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectToOracleServerToolStripMenuItem.Name = "connectToOracleServerToolStripMenuItem";
            this.connectToOracleServerToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.connectToOracleServerToolStripMenuItem.Text = "Connect to Oracle Server";
            this.connectToOracleServerToolStripMenuItem.Click += new System.EventHandler(this.connectToOracleServerToolStripMenuItem_Click);
            // 
            // connectToMicrosoftAccessDatabaseToolStripMenuItem
            // 
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem.Name = "connectToMicrosoftAccessDatabaseToolStripMenuItem";
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem.Text = "Connect to Microsoft Access database";
            this.connectToMicrosoftAccessDatabaseToolStripMenuItem.Click += new System.EventHandler(this.connectToMicrosoftAccessDatabaseToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(273, 6);
            // 
            // connectToDatabaseThroughOLEDBToolStripMenuItem
            // 
            this.connectToDatabaseThroughOLEDBToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectToDatabaseThroughOLEDBToolStripMenuItem.Name = "connectToDatabaseThroughOLEDBToolStripMenuItem";
            this.connectToDatabaseThroughOLEDBToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.connectToDatabaseThroughOLEDBToolStripMenuItem.Text = "Connect to database through OLE DB";
            this.connectToDatabaseThroughOLEDBToolStripMenuItem.Click += new System.EventHandler(this.connectToDatabaseThroughOLEDBToolStripMenuItem_Click);
            // 
            // connectToDatabaseThroughODBCToolStripMenuItem
            // 
            this.connectToDatabaseThroughODBCToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.connectToDatabaseThroughODBCToolStripMenuItem.Name = "connectToDatabaseThroughODBCToolStripMenuItem";
            this.connectToDatabaseThroughODBCToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.connectToDatabaseThroughODBCToolStripMenuItem.Text = "Connect to database through ODBC";
            this.connectToDatabaseThroughODBCToolStripMenuItem.Click += new System.EventHandler(this.connectToDatabaseThroughODBCToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPageQueryText);
            this.tabControl1.Controls.Add(this.tabPageResultsPreview);
            this.tabControl1.Location = new System.Drawing.Point(12, 497);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(926, 159);
            this.tabControl1.TabIndex = 9;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageQueryText
            // 
            this.tabPageQueryText.Controls.Add(this.errorBox1);
            this.tabPageQueryText.Controls.Add(this.textBox1);
            this.tabPageQueryText.Location = new System.Drawing.Point(4, 22);
            this.tabPageQueryText.Name = "tabPageQueryText";
            this.tabPageQueryText.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageQueryText.Size = new System.Drawing.Size(918, 133);
            this.tabPageQueryText.TabIndex = 0;
            this.tabPageQueryText.Text = "Selected Query Part Text";
            this.tabPageQueryText.UseVisualStyleBackColor = true;
            // 
            // tabPageResultsPreview
            // 
            this.tabPageResultsPreview.Controls.Add(this.dataGridView1);
            this.tabPageResultsPreview.Location = new System.Drawing.Point(4, 22);
            this.tabPageResultsPreview.Name = "tabPageResultsPreview";
            this.tabPageResultsPreview.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResultsPreview.Size = new System.Drawing.Size(918, 133);
            this.tabPageResultsPreview.TabIndex = 1;
            this.tabPageResultsPreview.Text = "---> Results Preview <---";
            this.tabPageResultsPreview.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(912, 127);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Query part to display:";
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(580, 66);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(314, 61);
            this.errorBox1.TabIndex = 5;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.errorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.errorBox1_RevertValidText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 668);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbUnionSubQuery);
            this.Controls.Add(this.rbSubQuery);
            this.Controls.Add(this.rbQuery);
            this.Controls.Add(this.queryBuilder);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Preview Sub-query Results";
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageQueryText.ResumeLayout(false);
            this.tabPageQueryText.PerformLayout();
            this.tabPageResultsPreview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton rbQuery;
		private System.Windows.Forms.RadioButton rbSubQuery;
		private System.Windows.Forms.RadioButton rbUnionSubQuery;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToMicrosoftSQLServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToOracleServerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToMicrosoftAccessDatabaseToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem connectToDatabaseThroughOLEDBToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem connectToDatabaseThroughODBCToolStripMenuItem;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageQueryText;
		private System.Windows.Forms.TabPage tabPageResultsPreview;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridView dataGridView1;
        private Common.ErrorBox errorBox1;
    }
}

