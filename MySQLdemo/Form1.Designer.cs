namespace MySQLdemo
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.mySQLMetadataProvider1 = new ActiveQueryBuilder.Core.MySQLMetadataProvider(this.components);
            this.mySQLSyntaxProvider1 = new ActiveQueryBuilder.Core.MySQLSyntaxProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStatisticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMetadataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMetadataFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).BeginInit();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 506);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.splitContainer1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(785, 480);
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
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorBox1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(779, 474);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder
            // 
            this.queryBuilder.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder.DatabaseSchemaViewOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.queryBuilder.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.queryBuilder.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.MetadataProvider = this.mySQLMetadataProvider1;
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
            this.queryBuilder.Size = new System.Drawing.Size(779, 364);
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
            this.queryBuilder.SyntaxProvider = this.mySQLSyntaxProvider1;
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
            // mySQLMetadataProvider1
            // 
            this.mySQLMetadataProvider1.Connection = null;
            // 
            // mySQLSyntaxProvider1
            // 
            this.mySQLSyntaxProvider1.OnCalcExpressionType = null;
            this.mySQLSyntaxProvider1.ServerVersion = "5.02";
            this.mySQLSyntaxProvider1.ServerVersionInt = 50200;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(779, 106);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(785, 480);
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
            this.dataGridView1.Size = new System.Drawing.Size(779, 474);
            this.dataGridView1.TabIndex = 0;
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
            this.connectMetadataToolStripMenuItem,
            this.metadataToolStripMenuItem,
            this.queryStatisticsMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectMetadataToolStripMenuItem
            // 
            this.connectMetadataToolStripMenuItem.Name = "connectMetadataToolStripMenuItem";
            this.connectMetadataToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.connectMetadataToolStripMenuItem.Text = "Connect...";
            this.connectMetadataToolStripMenuItem.Click += new System.EventHandler(this.connectMetadataToolStripMenuItem_Click);
            // 
            // metadataToolStripMenuItem
            // 
            this.metadataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMetadataToolStripMenuItem,
            this.editMetadataToolStripMenuItem,
            this.clearMetadataToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadFromXMLToolStripMenuItem,
            this.saveToXMLToolStripMenuItem});
            this.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem";
            this.metadataToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.metadataToolStripMenuItem.Text = "Metadata";
            // 
            // refreshMetadataToolStripMenuItem
            // 
            this.refreshMetadataToolStripMenuItem.Name = "refreshMetadataToolStripMenuItem";
            this.refreshMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.refreshMetadataToolStripMenuItem.Text = "Refresh Metadata";
            this.refreshMetadataToolStripMenuItem.Click += new System.EventHandler(this.refreshMetadataToolStripMenuItem_Click);
            // 
            // editMetadataToolStripMenuItem
            // 
            this.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem";
            this.editMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editMetadataToolStripMenuItem.Text = "Edit Metadata...";
            this.editMetadataToolStripMenuItem.Click += new System.EventHandler(this.editMetadataToolStripMenuItem_Click);
            // 
            // clearMetadataToolStripMenuItem
            // 
            this.clearMetadataToolStripMenuItem.Name = "clearMetadataToolStripMenuItem";
            this.clearMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearMetadataToolStripMenuItem.Text = "Clear Metadata";
            this.clearMetadataToolStripMenuItem.Click += new System.EventHandler(this.clearMetadataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // loadFromXMLToolStripMenuItem
            // 
            this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
            this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.loadFromXMLToolStripMenuItem.Text = "Load from XML...";
            this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
            // 
            // saveToXMLToolStripMenuItem
            // 
            this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
            this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToXMLToolStripMenuItem.Text = "Save to XML...";
            this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
            // 
            // queryStatisticsMenuItem
            // 
            this.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem";
            this.queryStatisticsMenuItem.Size = new System.Drawing.Size(109, 20);
            this.queryStatisticsMenuItem.Text = "Query Statistics...";
            this.queryStatisticsMenuItem.Click += new System.EventHandler(this.queryStatisticsMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openMetadataFileDialog
            // 
            this.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // saveMetadataFileDialog
            // 
            this.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList32.Images.SetKeyName(0, "0.bmp");
            this.imageList32.Images.SetKeyName(1, "1.bmp");
            this.imageList32.Images.SetKeyName(2, "2.bmp");
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(443, 40);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(312, 61);
            this.errorBox1.TabIndex = 1;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.ErrorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.ErrorBox1_RevertValidText);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder)).EndInit();
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageSQL;
		private System.Windows.Forms.TabPage tabPageData;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem metadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openMetadataFileDialog;
		private System.Windows.Forms.SaveFileDialog saveMetadataFileDialog;
		private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ImageList imageList32;
		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
		private ActiveQueryBuilder.Core.MySQLSyntaxProvider mySQLSyntaxProvider1;
		private ActiveQueryBuilder.Core.MySQLMetadataProvider mySQLMetadataProvider1;
		private System.Windows.Forms.ToolStripMenuItem queryStatisticsMenuItem;
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
    }
}

