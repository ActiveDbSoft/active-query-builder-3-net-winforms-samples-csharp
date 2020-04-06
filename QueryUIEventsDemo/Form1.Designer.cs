namespace QueryUIEventsDemo
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
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.CbDataSourceAdded = new System.Windows.Forms.CheckBox();
            this.CbDataSourceAdding = new System.Windows.Forms.CheckBox();
            this.CbDataSourceDeleting = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.CbDataSourceFieldAdded = new System.Windows.Forms.CheckBox();
            this.CbDataSourceFieldAdding = new System.Windows.Forms.CheckBox();
            this.CbDatasourceFieldRemoved = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.CbDataSourceFieldRemoving = new System.Windows.Forms.CheckBox();
            this.CbQueryColumnListItemChanged = new System.Windows.Forms.CheckBox();
            this.CbQueryColumnListItemChanging = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.CbLinkChanged = new System.Windows.Forms.CheckBox();
            this.CbLinkChanging = new System.Windows.Forms.CheckBox();
            this.CbLinkCreated = new System.Windows.Forms.CheckBox();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.CbLinkCreating = new System.Windows.Forms.CheckBox();
            this.CbLinkDeleting = new System.Windows.Forms.CheckBox();
            this.cbQueryColumnListItemRemoving = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.QBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.TextBoxSQL = new System.Windows.Forms.RichTextBox();
            this.TextBoxReport = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLGenerationOptions)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.splitContainer1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxReport, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1008, 771);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(3);
            this.panel1.Size = new System.Drawing.Size(1002, 100);
            this.panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel6);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(3);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(992, 78);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.CbDataSourceAdded);
            this.flowLayoutPanel2.Controls.Add(this.CbDataSourceAdding);
            this.flowLayoutPanel2.Controls.Add(this.CbDataSourceDeleting);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(154, 72);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // CbDataSourceAdded
            // 
            this.CbDataSourceAdded.AutoSize = true;
            this.CbDataSourceAdded.Checked = true;
            this.CbDataSourceAdded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDataSourceAdded.Location = new System.Drawing.Point(3, 3);
            this.CbDataSourceAdded.Name = "CbDataSourceAdded";
            this.CbDataSourceAdded.Size = new System.Drawing.Size(114, 17);
            this.CbDataSourceAdded.TabIndex = 0;
            this.CbDataSourceAdded.Text = "DataSourceAdded";
            this.CbDataSourceAdded.UseVisualStyleBackColor = true;
            // 
            // CbDataSourceAdding
            // 
            this.CbDataSourceAdding.AutoSize = true;
            this.CbDataSourceAdding.Checked = true;
            this.CbDataSourceAdding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDataSourceAdding.Location = new System.Drawing.Point(3, 26);
            this.CbDataSourceAdding.Name = "CbDataSourceAdding";
            this.CbDataSourceAdding.Size = new System.Drawing.Size(116, 17);
            this.CbDataSourceAdding.TabIndex = 1;
            this.CbDataSourceAdding.Text = "DataSourceAdding";
            this.CbDataSourceAdding.UseVisualStyleBackColor = true;
            // 
            // CbDataSourceDeleting
            // 
            this.CbDataSourceDeleting.AutoSize = true;
            this.CbDataSourceDeleting.Checked = true;
            this.CbDataSourceDeleting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDataSourceDeleting.Location = new System.Drawing.Point(3, 49);
            this.CbDataSourceDeleting.Name = "CbDataSourceDeleting";
            this.CbDataSourceDeleting.Size = new System.Drawing.Size(122, 17);
            this.CbDataSourceDeleting.TabIndex = 2;
            this.CbDataSourceDeleting.Text = "DataSourceDeleting";
            this.CbDataSourceDeleting.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.CbDataSourceFieldAdded);
            this.flowLayoutPanel3.Controls.Add(this.CbDataSourceFieldAdding);
            this.flowLayoutPanel3.Controls.Add(this.CbDatasourceFieldRemoved);
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(166, 6);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(164, 72);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // CbDataSourceFieldAdded
            // 
            this.CbDataSourceFieldAdded.AutoSize = true;
            this.CbDataSourceFieldAdded.Checked = true;
            this.CbDataSourceFieldAdded.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDataSourceFieldAdded.Location = new System.Drawing.Point(3, 3);
            this.CbDataSourceFieldAdded.Name = "CbDataSourceFieldAdded";
            this.CbDataSourceFieldAdded.Size = new System.Drawing.Size(136, 17);
            this.CbDataSourceFieldAdded.TabIndex = 0;
            this.CbDataSourceFieldAdded.Text = "DataSourceFieldAdded";
            this.CbDataSourceFieldAdded.UseVisualStyleBackColor = true;
            // 
            // CbDataSourceFieldAdding
            // 
            this.CbDataSourceFieldAdding.AutoSize = true;
            this.CbDataSourceFieldAdding.Checked = true;
            this.CbDataSourceFieldAdding.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDataSourceFieldAdding.Location = new System.Drawing.Point(3, 26);
            this.CbDataSourceFieldAdding.Name = "CbDataSourceFieldAdding";
            this.CbDataSourceFieldAdding.Size = new System.Drawing.Size(138, 17);
            this.CbDataSourceFieldAdding.TabIndex = 1;
            this.CbDataSourceFieldAdding.Text = "DataSourceFieldAdding";
            this.CbDataSourceFieldAdding.UseVisualStyleBackColor = true;
            // 
            // CbDatasourceFieldRemoved
            // 
            this.CbDatasourceFieldRemoved.AutoSize = true;
            this.CbDatasourceFieldRemoved.Checked = true;
            this.CbDatasourceFieldRemoved.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDatasourceFieldRemoved.Location = new System.Drawing.Point(3, 49);
            this.CbDatasourceFieldRemoved.Name = "CbDatasourceFieldRemoved";
            this.CbDatasourceFieldRemoved.Size = new System.Drawing.Size(149, 17);
            this.CbDatasourceFieldRemoved.TabIndex = 2;
            this.CbDatasourceFieldRemoved.Text = "DatasourceFieldRemoved";
            this.CbDatasourceFieldRemoved.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.CbDataSourceFieldRemoving);
            this.flowLayoutPanel4.Controls.Add(this.CbQueryColumnListItemChanged);
            this.flowLayoutPanel4.Controls.Add(this.CbQueryColumnListItemChanging);
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(336, 6);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(191, 72);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // CbDataSourceFieldRemoving
            // 
            this.CbDataSourceFieldRemoving.AutoSize = true;
            this.CbDataSourceFieldRemoving.Checked = true;
            this.CbDataSourceFieldRemoving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbDataSourceFieldRemoving.Location = new System.Drawing.Point(3, 3);
            this.CbDataSourceFieldRemoving.Name = "CbDataSourceFieldRemoving";
            this.CbDataSourceFieldRemoving.Size = new System.Drawing.Size(153, 17);
            this.CbDataSourceFieldRemoving.TabIndex = 0;
            this.CbDataSourceFieldRemoving.Text = "DataSourceFieldRemoving";
            this.CbDataSourceFieldRemoving.UseVisualStyleBackColor = true;
            // 
            // CbQueryColumnListItemChanged
            // 
            this.CbQueryColumnListItemChanged.AutoSize = true;
            this.CbQueryColumnListItemChanged.Checked = true;
            this.CbQueryColumnListItemChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbQueryColumnListItemChanged.Location = new System.Drawing.Point(3, 26);
            this.CbQueryColumnListItemChanged.Name = "CbQueryColumnListItemChanged";
            this.CbQueryColumnListItemChanged.Size = new System.Drawing.Size(168, 17);
            this.CbQueryColumnListItemChanged.TabIndex = 1;
            this.CbQueryColumnListItemChanged.Text = "QueryColumnListItemChanged";
            this.CbQueryColumnListItemChanged.UseVisualStyleBackColor = true;
            // 
            // CbQueryColumnListItemChanging
            // 
            this.CbQueryColumnListItemChanging.AutoSize = true;
            this.CbQueryColumnListItemChanging.Checked = true;
            this.CbQueryColumnListItemChanging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbQueryColumnListItemChanging.Location = new System.Drawing.Point(3, 49);
            this.CbQueryColumnListItemChanging.Name = "CbQueryColumnListItemChanging";
            this.CbQueryColumnListItemChanging.Size = new System.Drawing.Size(170, 17);
            this.CbQueryColumnListItemChanging.TabIndex = 2;
            this.CbQueryColumnListItemChanging.Text = "QueryColumnListItemChanging";
            this.CbQueryColumnListItemChanging.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.CbLinkChanged);
            this.flowLayoutPanel5.Controls.Add(this.CbLinkChanging);
            this.flowLayoutPanel5.Controls.Add(this.CbLinkCreated);
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(533, 6);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(108, 72);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // CbLinkChanged
            // 
            this.CbLinkChanged.AutoSize = true;
            this.CbLinkChanged.Checked = true;
            this.CbLinkChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbLinkChanged.Location = new System.Drawing.Point(3, 3);
            this.CbLinkChanged.Name = "CbLinkChanged";
            this.CbLinkChanged.Size = new System.Drawing.Size(89, 17);
            this.CbLinkChanged.TabIndex = 0;
            this.CbLinkChanged.Text = "LinkChanged";
            this.CbLinkChanged.UseVisualStyleBackColor = true;
            // 
            // CbLinkChanging
            // 
            this.CbLinkChanging.AutoSize = true;
            this.CbLinkChanging.Checked = true;
            this.CbLinkChanging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbLinkChanging.Location = new System.Drawing.Point(3, 26);
            this.CbLinkChanging.Name = "CbLinkChanging";
            this.CbLinkChanging.Size = new System.Drawing.Size(91, 17);
            this.CbLinkChanging.TabIndex = 1;
            this.CbLinkChanging.Text = "LinkChanging";
            this.CbLinkChanging.UseVisualStyleBackColor = true;
            // 
            // CbLinkCreated
            // 
            this.CbLinkCreated.AutoSize = true;
            this.CbLinkCreated.Checked = true;
            this.CbLinkCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbLinkCreated.Location = new System.Drawing.Point(3, 49);
            this.CbLinkCreated.Name = "CbLinkCreated";
            this.CbLinkCreated.Size = new System.Drawing.Size(83, 17);
            this.CbLinkCreated.TabIndex = 2;
            this.CbLinkCreated.Text = "LinkCreated";
            this.CbLinkCreated.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.CbLinkCreating);
            this.flowLayoutPanel6.Controls.Add(this.CbLinkDeleting);
            this.flowLayoutPanel6.Controls.Add(this.cbQueryColumnListItemRemoving);
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(647, 6);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Size = new System.Drawing.Size(175, 72);
            this.flowLayoutPanel6.TabIndex = 0;
            // 
            // CbLinkCreating
            // 
            this.CbLinkCreating.AutoSize = true;
            this.CbLinkCreating.Checked = true;
            this.CbLinkCreating.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbLinkCreating.Location = new System.Drawing.Point(3, 3);
            this.CbLinkCreating.Name = "CbLinkCreating";
            this.CbLinkCreating.Size = new System.Drawing.Size(85, 17);
            this.CbLinkCreating.TabIndex = 0;
            this.CbLinkCreating.Text = "LinkCreating";
            this.CbLinkCreating.UseVisualStyleBackColor = true;
            // 
            // CbLinkDeleting
            // 
            this.CbLinkDeleting.AutoSize = true;
            this.CbLinkDeleting.Checked = true;
            this.CbLinkDeleting.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbLinkDeleting.Location = new System.Drawing.Point(3, 26);
            this.CbLinkDeleting.Name = "CbLinkDeleting";
            this.CbLinkDeleting.Size = new System.Drawing.Size(85, 17);
            this.CbLinkDeleting.TabIndex = 1;
            this.CbLinkDeleting.Text = "LinkDeleting";
            this.CbLinkDeleting.UseVisualStyleBackColor = true;
            // 
            // cbQueryColumnListItemRemoving
            // 
            this.cbQueryColumnListItemRemoving.AutoSize = true;
            this.cbQueryColumnListItemRemoving.Checked = true;
            this.cbQueryColumnListItemRemoving.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQueryColumnListItemRemoving.Location = new System.Drawing.Point(3, 49);
            this.cbQueryColumnListItemRemoving.Name = "cbQueryColumnListItemRemoving";
            this.cbQueryColumnListItemRemoving.Size = new System.Drawing.Size(173, 17);
            this.cbQueryColumnListItemRemoving.TabIndex = 1;
            this.cbQueryColumnListItemRemoving.Text = "QueryColumnListItemRemoving";
            this.cbQueryColumnListItemRemoving.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stop on:";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(3, 109);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.QBuilder);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.errorBox1);
            this.splitContainer1.Panel2.Controls.Add(this.TextBoxSQL);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 557);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 1;
            // 
            // QBuilder
            // 
            this.QBuilder.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.QBuilder.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.QBuilder.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.QBuilder.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.QBuilder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QBuilder.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.QBuilder.DatabaseSchemaViewOptions.ImageList = null;
            this.QBuilder.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.QBuilder.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
            this.QBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.QBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QBuilder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.QBuilder.Location = new System.Drawing.Point(0, 0);
            this.QBuilder.Name = "QBuilder";
            this.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true;
            this.QBuilder.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.QBuilder.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.QBuilder.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.QBuilder.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Index = 5;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.AggregateColumn.Width = 90D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Index = 2;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.AliasColumn.Width = 100D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Index = 7;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.ConditionTypeColumn.Width = 70D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Index = 8;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaColumn.Width = 60D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Index = 0;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.CriteriaOrColumns.Width = 60D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Index = 1;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.ExpressionColumn.Width = 150D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Index = 6;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.GroupingColumn.Width = 80D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Index = 0;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.OutputColumn.Width = 55D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Index = 4;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.SortOrderColumn.Width = 90D;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Index = 3;
            this.QBuilder.QueryColumnListOptions.ColumnsOptions.SortTypeColumn.Width = 80D;
            this.QBuilder.QueryColumnListOptions.Font = null;
            this.QBuilder.QueryColumnListOptions.InitialOrColumnsCount = 2;
            this.QBuilder.QueryColumnListOptions.NullOrderingInOrderBy = false;
            this.QBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.QBuilder.QueryNavBarOptions.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.QBuilder.QueryNavBarOptions.DisableQueryNavigationBarPopup = false;
            this.QBuilder.QueryNavBarOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QBuilder.QueryNavBarOptions.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.QBuilder.QueryNavBarOptions.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.QBuilder.QueryNavBarOptions.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.QBuilder.Size = new System.Drawing.Size(1002, 443);
            // 
            // 
            // 
            this.QBuilder.SQLFormattingOptions.CTESubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.CTESubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.CTESubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DerivedQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DerivedQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DerivedQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.DynamicIndents = false;
            this.QBuilder.SQLFormattingOptions.DynamicRightMargin = false;
            this.QBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.QBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            this.QBuilder.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.QBuilder.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // 
            // 
            this.QBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.QBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.QBuilder.SQLGenerationOptions.UseAltNames = false;
            this.QBuilder.TabIndex = 0;
            this.QBuilder.VisualOptions.ActiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(242)))), ((int)(((byte)(157)))));
            this.QBuilder.VisualOptions.ActiveDockPanelCaptionFontColor = System.Drawing.Color.Black;
            this.QBuilder.VisualOptions.DockTabColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.QBuilder.VisualOptions.DockTabFontColor = System.Drawing.Color.White;
            this.QBuilder.VisualOptions.DockTabFontHoverColor = System.Drawing.Color.White;
            this.QBuilder.VisualOptions.DockTabHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.QBuilder.VisualOptions.DockTabIndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(125)))));
            this.QBuilder.VisualOptions.DockTabIndicatorHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.QBuilder.VisualOptions.InactiveDockPanelCaptionColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(96)))), ((int)(((byte)(130)))));
            this.QBuilder.VisualOptions.InactiveDockPanelCaptionFontColor = System.Drawing.Color.White;
            this.QBuilder.VisualOptions.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QBuilder.VisualOptions.TabsStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.QBuilder.DataSourceAdding += new ActiveQueryBuilder.View.QueryView.DataSourceAddingEventHandler(this.QBuilder_DataSourceAdding);
            this.QBuilder.DataSourceAdded += new ActiveQueryBuilder.Core.DataSourceAddedEventHandler(this.QBuilder_DataSourceAdded);
            this.QBuilder.DataSourceDeleting += new ActiveQueryBuilder.View.QueryView.DataSourceDeletingEventHandler(this.QBuilder_DataSourceDeleting);
            this.QBuilder.LinkDeleting += new ActiveQueryBuilder.View.QueryView.LinkDeletingEventHandler(this.QBuilder_LinkDeleting);
            this.QBuilder.LinkCreated += new ActiveQueryBuilder.Core.LinkCreatedEventhandler(this.QBuilder_LinkCreated);
            this.QBuilder.LinkChanging += new ActiveQueryBuilder.View.QueryView.LinkChangingEventHandler(this.QBuilder_LinkChanging);
            this.QBuilder.LinkChanged += new ActiveQueryBuilder.View.QueryView.LinkChangedEventHandler(this.QBuilder_LinkChanged);
            this.QBuilder.LinkCreating += new ActiveQueryBuilder.View.QueryView.LinkCreatingEventHandler(this.QBuilder_LinkCreating);
            this.QBuilder.QueryColumnListItemChanging += new ActiveQueryBuilder.View.QueryView.QueryColumnListItemChangingEventHandler(this.QBuilder_QueryColumnListItemChanging);
            this.QBuilder.QueryColumnListItemChanged += new ActiveQueryBuilder.View.QueryView.QueryColumnListItemChangedEventHandler(this.QBuilder_QueryColumnListItemChanged);
            this.QBuilder.QueryColumnListItemAdded += new ActiveQueryBuilder.View.QueryView.ItemCollectionChanged(this.QBuilder_QueryColumnListItemAdded);
            this.QBuilder.QueryColumnListItemRemoving += new ActiveQueryBuilder.View.QueryView.ItemCollectionChanging(this.QBuilder_QueryColumnListItemRemoving);
            this.QBuilder.DataSourceFieldAdding += new ActiveQueryBuilder.View.QueryView.DataSourceFieldAddingEventHandler(this.QBuilder_DataSourceFieldAdding);
            this.QBuilder.DataSourceFieldAdded += new ActiveQueryBuilder.View.QueryView.DataSourceFieldAddedEventHandler(this.QBuilder_DataSourceFieldAdded);
            this.QBuilder.DataSourceFieldRemoving += new ActiveQueryBuilder.View.QueryView.DataSourceFieldRemovingEventHandler(this.QBuilder_DataSourceFieldRemoving);
            this.QBuilder.DatasourceFieldRemoved += new ActiveQueryBuilder.View.QueryView.DatasourceFieldRemovedEventHandler(this.QBuilder_DatasourceFieldRemoved);
            this.QBuilder.SQLUpdated += new System.EventHandler(this.QBuilder_SQLUpdated);
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(677, 46);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(5);
            this.errorBox1.Size = new System.Drawing.Size(316, 61);
            this.errorBox1.TabIndex = 1;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.ErrorBox1_GoToErrorPosition);
            this.errorBox1.RevertValidText += new System.EventHandler(this.ErrorBox1_RevertValidText);
            // 
            // TextBoxSQL
            // 
            this.TextBoxSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxSQL.Location = new System.Drawing.Point(0, 0);
            this.TextBoxSQL.Name = "TextBoxSQL";
            this.TextBoxSQL.Size = new System.Drawing.Size(1002, 110);
            this.TextBoxSQL.TabIndex = 0;
            this.TextBoxSQL.Text = "";
            this.TextBoxSQL.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxSQL_Validating);
            // 
            // TextBoxReport
            // 
            this.TextBoxReport.BackColor = System.Drawing.SystemColors.Info;
            this.TextBoxReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxReport.Location = new System.Drawing.Point(3, 672);
            this.TextBoxReport.Name = "TextBoxReport";
            this.TextBoxReport.Size = new System.Drawing.Size(1002, 96);
            this.TextBoxReport.TabIndex = 2;
            this.TextBoxReport.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 771);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "QueryUIEventsDemo";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLFormattingOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QBuilder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder QBuilder;
        private System.Windows.Forms.RichTextBox TextBoxSQL;
        private System.Windows.Forms.RichTextBox TextBoxReport;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox CbDataSourceAdded;
        private System.Windows.Forms.CheckBox CbDataSourceAdding;
        private System.Windows.Forms.CheckBox CbDataSourceDeleting;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.CheckBox CbDataSourceFieldAdded;
        private System.Windows.Forms.CheckBox CbDataSourceFieldAdding;
        private System.Windows.Forms.CheckBox CbDatasourceFieldRemoved;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.CheckBox CbDataSourceFieldRemoving;
        private System.Windows.Forms.CheckBox CbQueryColumnListItemChanged;
        private System.Windows.Forms.CheckBox CbQueryColumnListItemChanging;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.CheckBox CbLinkChanged;
        private System.Windows.Forms.CheckBox CbLinkChanging;
        private System.Windows.Forms.CheckBox CbLinkCreated;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel6;
        private System.Windows.Forms.CheckBox CbLinkCreating;
        private System.Windows.Forms.CheckBox CbLinkDeleting;
        private System.Windows.Forms.CheckBox cbQueryColumnListItemRemoving;
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
    }
}

