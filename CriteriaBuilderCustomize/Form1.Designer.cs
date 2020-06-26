namespace CriteriaBuilderCustomize
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.criteriaBuilder1 = new ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxEditor = new System.Windows.Forms.CheckBox();
            this.checkBoxButton = new System.Windows.Forms.CheckBox();
            this.checkBoxList = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLGenerationOptions)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxSql);
            this.splitContainer1.Size = new System.Drawing.Size(838, 491);
            this.splitContainer1.SplitterDistance = 324;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.queryBuilder1.DatabaseSchemaViewOptions.AllowDrop = true;
            this.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder1.DatabaseSchemaViewOptions.ImageList = null;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.DescriptionColumnOptions.DrawOrder = 4;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.DrawOrder = 3;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Margin = 5;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.NameColumnOptions.DrawOrder = 1;
            this.queryBuilder1.DataSourceOptions.DefaultWidth = 300;
            this.queryBuilder1.DataSourceOptions.MaxHeight = 300;
            this.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            this.queryBuilder1.DesignPaneOptions.DesignPaneOverviewWidth = 200;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.MetadataLoadingOptions.ExcludeFilter.Types = ActiveQueryBuilder.Core.MetadataType.None;
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 134;
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
            this.queryBuilder1.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Caption = null;
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
            this.queryBuilder1.QueryColumnListOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder1.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.queryBuilder1.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.queryBuilder1.QueryColumnListOptions.TextColor = System.Drawing.SystemColors.ControlText;
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
            this.queryBuilder1.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
            this.queryBuilder1.Size = new System.Drawing.Size(838, 324);
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
            this.queryBuilder1.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder1.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder1_SQLUpdated);
            // 
            // textBoxSql
            // 
            this.textBoxSql.AcceptsReturn = true;
            this.textBoxSql.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSql.Location = new System.Drawing.Point(0, 0);
            this.textBoxSql.Multiline = true;
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(838, 163);
            this.textBoxSql.TabIndex = 0;
            this.textBoxSql.Validated += new System.EventHandler(this.textBoxSql_Validated);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(852, 523);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(844, 497);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "QueryBuilder";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.criteriaBuilder1);
            this.tabPage2.Controls.Add(this.flowLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(844, 497);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "CriteriaBuilder";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // criteriaBuilder1
            // 
            this.criteriaBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.criteriaBuilder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.criteriaBuilder1.Location = new System.Drawing.Point(3, 26);
            this.criteriaBuilder1.MinimumSize = new System.Drawing.Size(355, 51);
            this.criteriaBuilder1.Name = "criteriaBuilder1";
            this.criteriaBuilder1.QueryTransformer = null;
            this.criteriaBuilder1.RootItemFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.criteriaBuilder1.RootJunctionPrefix = null;
            this.criteriaBuilder1.Size = new System.Drawing.Size(838, 468);
            this.criteriaBuilder1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.checkBoxEditor);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxButton);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxList);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(838, 23);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // checkBoxEditor
            // 
            this.checkBoxEditor.AutoSize = true;
            this.checkBoxEditor.Checked = true;
            this.checkBoxEditor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEditor.Location = new System.Drawing.Point(3, 3);
            this.checkBoxEditor.Name = "checkBoxEditor";
            this.checkBoxEditor.Size = new System.Drawing.Size(111, 17);
            this.checkBoxEditor.TabIndex = 0;
            this.checkBoxEditor.Text = "Use custom editor";
            this.checkBoxEditor.UseVisualStyleBackColor = true;
            // 
            // checkBoxButton
            // 
            this.checkBoxButton.AutoSize = true;
            this.checkBoxButton.Checked = true;
            this.checkBoxButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxButton.Location = new System.Drawing.Point(120, 3);
            this.checkBoxButton.Name = "checkBoxButton";
            this.checkBoxButton.Size = new System.Drawing.Size(150, 17);
            this.checkBoxButton.TabIndex = 0;
            this.checkBoxButton.Text = "Use custom lookup button";
            this.checkBoxButton.UseVisualStyleBackColor = true;
            // 
            // checkBoxList
            // 
            this.checkBoxList.AutoSize = true;
            this.checkBoxList.Checked = true;
            this.checkBoxList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxList.Location = new System.Drawing.Point(276, 3);
            this.checkBoxList.Name = "checkBoxList";
            this.checkBoxList.Size = new System.Drawing.Size(132, 17);
            this.checkBoxList.TabIndex = 0;
            this.checkBoxList.Text = "Use custom lookup list";
            this.checkBoxList.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(852, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToToolStripMenuItem,
            this.toolStripSeparator1,
            this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // connectToToolStripMenuItem
            // 
            this.connectToToolStripMenuItem.Name = "connectToToolStripMenuItem";
            this.connectToToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.connectToToolStripMenuItem.Text = "Connect to...";
            this.connectToToolStripMenuItem.Click += new System.EventHandler(this.connectToToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(276, 6);
            // 
            // fillTheQueryBuilderProgrammaticallyToolStripMenuItem
            // 
            this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem.Name = "fillTheQueryBuilderProgrammaticallyToolStripMenuItem";
            this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem.Text = "Fill the query builder programmatically";
            this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem.Click += new System.EventHandler(this.fillTheQueryBuilderProgrammaticallyToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 547);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private ActiveQueryBuilder.View.WinForms.CriteriaBuilder.CriteriaBuilder criteriaBuilder1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxEditor;
        private System.Windows.Forms.CheckBox checkBoxButton;
        private System.Windows.Forms.CheckBox checkBoxList;
        private System.Windows.Forms.ToolStripMenuItem connectToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fillTheQueryBuilderProgrammaticallyToolStripMenuItem;
    }
}

