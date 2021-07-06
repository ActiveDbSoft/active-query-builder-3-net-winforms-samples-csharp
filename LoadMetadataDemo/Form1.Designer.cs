using System.Windows.Forms;

namespace LoadMetadataDemo
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
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.openMetadataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMetadataFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.menuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.genericSyntaxProvider1 = new ActiveQueryBuilder.Core.GenericSyntaxProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageDirect = new System.Windows.Forms.TabPage();
            this.btnFourthWay = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.tabPageOnDemand = new System.Windows.Forms.TabPage();
            this.btnThirdWay = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.tabPageExecSql = new System.Windows.Forms.TabPage();
            this.btnFirstWay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabPageDataset = new System.Windows.Forms.TabPage();
            this.btnFifthWay = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.way3EventMetadataProvider = new ActiveQueryBuilder.Core.EventMetadataProvider(this.components);
            this.menuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLFormattingOptions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryBuilder1.SQLGenerationOptions)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageDirect.SuspendLayout();
            this.tabPageOnDemand.SuspendLayout();
            this.tabPageExecSql.SuspendLayout();
            this.tabPageDataset.SuspendLayout();
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
            // openMetadataFileDialog
            // 
            this.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // saveMetadataFileDialog
            // 
            this.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // mainMenu1
            // 
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItem1,
            this.aboutMenuItem});
            // 
            // menuItem1
            // 
            this.menuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripMenuItem[] {
            this.menuItemConnect});
            this.menuItem1.Text = "Connect";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 149);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 455);
            this.splitContainer1.SplitterDistance = 346;
            this.splitContainer1.TabIndex = 1;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.AddObjectDialogOptions.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.AddObjectDialogOptions.Size = new System.Drawing.Size(430, 430);
            this.queryBuilder1.AddObjectDialogOptions.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.queryBuilder1.DatabaseSchemaViewOptions.DrawTreeLines = false;
            this.queryBuilder1.DatabaseSchemaViewOptions.ImageList = this.imageList16;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black;
            this.queryBuilder1.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Image)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder1.DesignPaneOptions.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.queryBuilder1.DesignPaneOptions.LinkPainterOptions = linkPainterAccess1;
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = true;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true;
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
            this.queryBuilder1.Size = new System.Drawing.Size(764, 346);
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
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.MainQueryFormat.FromClauseFormat.JoinConditionFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.MainQueryFormat.HavingFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            this.queryBuilder1.SQLFormattingOptions.MainQueryFormat.WhereFormat.NewLineBefore = ActiveQueryBuilder.Core.SQLBuilderConditionFormatNewLine.None;
            // 
            // 
            // 
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder1.SyntaxProvider = this.genericSyntaxProvider1;
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
            // genericSyntaxProvider1
            // 
            this.genericSyntaxProvider1.DetectServerVersion = false;
            this.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.genericSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(764, 105);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDirect);
            this.tabControl1.Controls.Add(this.tabPageOnDemand);
            this.tabControl1.Controls.Add(this.tabPageExecSql);
            this.tabControl1.Controls.Add(this.tabPageDataset);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 149);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageDirect
            // 
            this.tabPageDirect.Controls.Add(this.btnFourthWay);
            this.tabPageDirect.Controls.Add(this.textBox5);
            this.tabPageDirect.Location = new System.Drawing.Point(4, 22);
            this.tabPageDirect.Name = "tabPageDirect";
            this.tabPageDirect.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDirect.Size = new System.Drawing.Size(756, 123);
            this.tabPageDirect.TabIndex = 3;
            this.tabPageDirect.Text = "Direct filling of MetadataContainer";
            this.tabPageDirect.UseVisualStyleBackColor = true;
            // 
            // btnFourthWay
            // 
            this.btnFourthWay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFourthWay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFourthWay.Location = new System.Drawing.Point(613, 94);
            this.btnFourthWay.Name = "btnFourthWay";
            this.btnFourthWay.Size = new System.Drawing.Size(137, 23);
            this.btnFourthWay.TabIndex = 6;
            this.btnFourthWay.Text = "Load Metadata";
            this.btnFourthWay.UseVisualStyleBackColor = true;
            this.btnFourthWay.Click += new System.EventHandler(this.btn1Way_Click);
            // 
            // textBox5
            // 
            this.textBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox5.Location = new System.Drawing.Point(6, 6);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox5.Size = new System.Drawing.Size(742, 82);
            this.textBox5.TabIndex = 5;
            this.textBox5.Text = "This method demonstrates the direct access to the internal matadata objects colle" +
    "ction (MetadataContainer).";
            // 
            // tabPageOnDemand
            // 
            this.tabPageOnDemand.Controls.Add(this.btnThirdWay);
            this.tabPageOnDemand.Controls.Add(this.textBox3);
            this.tabPageOnDemand.Location = new System.Drawing.Point(4, 22);
            this.tabPageOnDemand.Name = "tabPageOnDemand";
            this.tabPageOnDemand.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOnDemand.Size = new System.Drawing.Size(756, 123);
            this.tabPageOnDemand.TabIndex = 1;
            this.tabPageOnDemand.Text = "On-demand filling using ItemMetadataLoading event";
            this.tabPageOnDemand.UseVisualStyleBackColor = true;
            // 
            // btnThirdWay
            // 
            this.btnThirdWay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThirdWay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnThirdWay.Location = new System.Drawing.Point(611, 94);
            this.btnThirdWay.Name = "btnThirdWay";
            this.btnThirdWay.Size = new System.Drawing.Size(137, 23);
            this.btnThirdWay.TabIndex = 3;
            this.btnThirdWay.Text = "Load Metadata";
            this.btnThirdWay.UseVisualStyleBackColor = true;
            this.btnThirdWay.Click += new System.EventHandler(this.btn2Way_Click);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(6, 6);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox3.Size = new System.Drawing.Size(742, 82);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "This method demonstrates manual filling of metadata structure using MetadataConta" +
    "iner.ItemMetadataLoading event.";
            // 
            // tabPageExecSql
            // 
            this.tabPageExecSql.Controls.Add(this.btnFirstWay);
            this.tabPageExecSql.Controls.Add(this.label1);
            this.tabPageExecSql.Controls.Add(this.textBox2);
            this.tabPageExecSql.Location = new System.Drawing.Point(4, 22);
            this.tabPageExecSql.Name = "tabPageExecSql";
            this.tabPageExecSql.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExecSql.Size = new System.Drawing.Size(756, 123);
            this.tabPageExecSql.TabIndex = 0;
            this.tabPageExecSql.Text = "Using the ExecSQL event";
            this.tabPageExecSql.UseVisualStyleBackColor = true;
            // 
            // btnFirstWay
            // 
            this.btnFirstWay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFirstWay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFirstWay.Location = new System.Drawing.Point(611, 94);
            this.btnFirstWay.Name = "btnFirstWay";
            this.btnFirstWay.Size = new System.Drawing.Size(137, 23);
            this.btnFirstWay.TabIndex = 1;
            this.btnFirstWay.Text = "Load Metadata";
            this.btnFirstWay.UseVisualStyleBackColor = true;
            this.btnFirstWay.Click += new System.EventHandler(this.btn3Way_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please setup a database connection by clicking on the \"Connect\" menu item before " +
    "testing this method.";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(6, 6);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(742, 82);
            this.textBox2.TabIndex = 0;
            this.textBox2.Text = resources.GetString("textBox2.Text");
            // 
            // tabPageDataset
            // 
            this.tabPageDataset.Controls.Add(this.btnFifthWay);
            this.tabPageDataset.Controls.Add(this.textBox6);
            this.tabPageDataset.Location = new System.Drawing.Point(4, 22);
            this.tabPageDataset.Name = "tabPageDataset";
            this.tabPageDataset.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataset.Size = new System.Drawing.Size(756, 123);
            this.tabPageDataset.TabIndex = 4;
            this.tabPageDataset.Text = "Fill from DataSet";
            this.tabPageDataset.UseVisualStyleBackColor = true;
            // 
            // btnFifthWay
            // 
            this.btnFifthWay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFifthWay.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnFifthWay.Location = new System.Drawing.Point(613, 94);
            this.btnFifthWay.Name = "btnFifthWay";
            this.btnFifthWay.Size = new System.Drawing.Size(137, 23);
            this.btnFifthWay.TabIndex = 8;
            this.btnFifthWay.Text = "Load Metadata";
            this.btnFifthWay.UseVisualStyleBackColor = true;
            this.btnFifthWay.Click += new System.EventHandler(this.btn4Way_Click);
            // 
            // textBox6
            // 
            this.textBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox6.Location = new System.Drawing.Point(6, 6);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox6.Size = new System.Drawing.Size(742, 82);
            this.textBox6.TabIndex = 7;
            this.textBox6.Text = "This method demonstrates manual filling of metadata structure from stored DataSet" +
    ".";
            // 
            // menuItemConnect
            // 
            this.menuItemConnect.Text = "Connect to...";
            this.menuItemConnect.Click += new System.EventHandler(this.menuItemConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 604);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.mainMenu1;
            this.Controls.Add(this.mainMenu1);
            this.mainMenu1.Dock = DockStyle.Top;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
            this.tabPageDirect.ResumeLayout(false);
            this.tabPageDirect.PerformLayout();
            this.tabPageOnDemand.ResumeLayout(false);
            this.tabPageOnDemand.PerformLayout();
            this.tabPageExecSql.ResumeLayout(false);
            this.tabPageExecSql.PerformLayout();
            this.tabPageDataset.ResumeLayout(false);
            this.tabPageDataset.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openMetadataFileDialog;
		private System.Windows.Forms.SaveFileDialog saveMetadataFileDialog;
		private System.Windows.Forms.ImageList imageList16;

		private ActiveQueryBuilder.Core.EventMetadataProvider way3EventMetadataProvider;
		private System.Windows.Forms.MenuStrip mainMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem1;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageExecSql;
		private System.Windows.Forms.TabPage tabPageOnDemand;
		private System.Windows.Forms.Button btnFirstWay;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button btnThirdWay;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TabPage tabPageDirect;
		private System.Windows.Forms.Button btnFourthWay;
		private System.Windows.Forms.TextBox textBox5;
		private ActiveQueryBuilder.Core.GenericSyntaxProvider genericSyntaxProvider1;
		private System.Windows.Forms.TabPage tabPageDataset;
		private System.Windows.Forms.Button btnFifthWay;
		private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ToolStripMenuItem menuItemConnect;
    }
}

