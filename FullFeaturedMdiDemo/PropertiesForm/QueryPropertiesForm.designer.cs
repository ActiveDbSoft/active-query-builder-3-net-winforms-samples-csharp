namespace FullFeaturedMdiDemo.PropertiesForm
{
	partial class QueryPropertiesForm
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
            this.panelButtons = new System.Windows.Forms.Panel();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabQueryBuilder = new System.Windows.Forms.TabPage();
            this.panelQueryBuilder = new System.Windows.Forms.Panel();
            this.panelPages1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.linkSqlGeneration = new System.Windows.Forms.LinkLabel();
            this.linkBehaviorOptions = new System.Windows.Forms.LinkLabel();
            this.linkDatabaseSchemaView = new System.Windows.Forms.LinkLabel();
            this.linkDesignPane = new System.Windows.Forms.LinkLabel();
            this.linkVisualOptions = new System.Windows.Forms.LinkLabel();
            this.linkAddObjectDialog = new System.Windows.Forms.LinkLabel();
            this.linkDatasourceOptions = new System.Windows.Forms.LinkLabel();
            this.linkQueryColumnList = new System.Windows.Forms.LinkLabel();
            this.linkQueryNavBar = new System.Windows.Forms.LinkLabel();
            this.linkQueryView = new System.Windows.Forms.LinkLabel();
            this.lbExpressionEditor = new System.Windows.Forms.LinkLabel();
            this.lbTextEditor = new System.Windows.Forms.LinkLabel();
            this.lbTextEditorSql = new System.Windows.Forms.LinkLabel();
            this.tabFormatting = new System.Windows.Forms.TabPage();
            this.panelSqlFormatting = new System.Windows.Forms.Panel();
            this.panelPages2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSqlFormatting = new System.Windows.Forms.Label();
            this.linkMain = new System.Windows.Forms.LinkLabel();
            this.linkMainCommon = new System.Windows.Forms.LinkLabel();
            this.linkMainExpressions = new System.Windows.Forms.LinkLabel();
            this.linkCte = new System.Windows.Forms.LinkLabel();
            this.linkCteCommon = new System.Windows.Forms.LinkLabel();
            this.linkCteExpressions = new System.Windows.Forms.LinkLabel();
            this.linkDerived = new System.Windows.Forms.LinkLabel();
            this.linkDerivedCommon = new System.Windows.Forms.LinkLabel();
            this.linkDerivedExpressions = new System.Windows.Forms.LinkLabel();
            this.linkExpression = new System.Windows.Forms.LinkLabel();
            this.linkExpressionCommon = new System.Windows.Forms.LinkLabel();
            this.linkExpressionExpressions = new System.Windows.Forms.LinkLabel();
            this.panelButtons.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabQueryBuilder.SuspendLayout();
            this.panelQueryBuilder.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabFormatting.SuspendLayout();
            this.panelSqlFormatting.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.buttonLoad);
            this.panelButtons.Controls.Add(this.buttonSave);
            this.panelButtons.Controls.Add(this.buttonCancel);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 439);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(781, 43);
            this.panelButtons.TabIndex = 2;
            // 
            // buttonLoad
            // 
            this.buttonLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLoad.Location = new System.Drawing.Point(109, 10);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(96, 23);
            this.buttonLoad.TabIndex = 3;
            this.buttonLoad.Text = "Import...";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(7, 10);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Export...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonCancel.Location = new System.Drawing.Point(694, 10);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Close";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabQueryBuilder);
            this.tabControl.Controls.Add(this.tabFormatting);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(781, 439);
            this.tabControl.TabIndex = 3;
            // 
            // tabQueryBuilder
            // 
            this.tabQueryBuilder.Controls.Add(this.panelQueryBuilder);
            this.tabQueryBuilder.Location = new System.Drawing.Point(4, 22);
            this.tabQueryBuilder.Name = "tabQueryBuilder";
            this.tabQueryBuilder.Padding = new System.Windows.Forms.Padding(3);
            this.tabQueryBuilder.Size = new System.Drawing.Size(773, 413);
            this.tabQueryBuilder.TabIndex = 0;
            this.tabQueryBuilder.Text = "QueryBuilder properties";
            this.tabQueryBuilder.UseVisualStyleBackColor = true;
            // 
            // panelQueryBuilder
            // 
            this.panelQueryBuilder.Controls.Add(this.panelPages1);
            this.panelQueryBuilder.Controls.Add(this.flowLayoutPanel1);
            this.panelQueryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelQueryBuilder.Location = new System.Drawing.Point(3, 3);
            this.panelQueryBuilder.Name = "panelQueryBuilder";
            this.panelQueryBuilder.Size = new System.Drawing.Size(767, 407);
            this.panelQueryBuilder.TabIndex = 4;
            // 
            // panelPages1
            // 
            this.panelPages1.AutoScroll = true;
            this.panelPages1.AutoSize = true;
            this.panelPages1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPages1.BackColor = System.Drawing.Color.White;
            this.panelPages1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPages1.Location = new System.Drawing.Point(170, 0);
            this.panelPages1.Margin = new System.Windows.Forms.Padding(0);
            this.panelPages1.Name = "panelPages1";
            this.panelPages1.Padding = new System.Windows.Forms.Padding(10, 10, 6, 6);
            this.panelPages1.Size = new System.Drawing.Size(597, 407);
            this.panelPages1.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.linkSqlGeneration);
            this.flowLayoutPanel1.Controls.Add(this.linkBehaviorOptions);
            this.flowLayoutPanel1.Controls.Add(this.linkDatabaseSchemaView);
            this.flowLayoutPanel1.Controls.Add(this.linkDesignPane);
            this.flowLayoutPanel1.Controls.Add(this.linkVisualOptions);
            this.flowLayoutPanel1.Controls.Add(this.linkAddObjectDialog);
            this.flowLayoutPanel1.Controls.Add(this.linkDatasourceOptions);
            this.flowLayoutPanel1.Controls.Add(this.linkQueryColumnList);
            this.flowLayoutPanel1.Controls.Add(this.linkQueryNavBar);
            this.flowLayoutPanel1.Controls.Add(this.linkQueryView);
            this.flowLayoutPanel1.Controls.Add(this.lbExpressionEditor);
            this.flowLayoutPanel1.Controls.Add(this.lbTextEditor);
            this.flowLayoutPanel1.Controls.Add(this.lbTextEditorSql);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 407);
            this.flowLayoutPanel1.TabIndex = 6;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // linkSqlGeneration
            // 
            this.linkSqlGeneration.AutoSize = true;
            this.linkSqlGeneration.ForeColor = System.Drawing.Color.Black;
            this.linkSqlGeneration.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkSqlGeneration.LinkColor = System.Drawing.Color.Black;
            this.linkSqlGeneration.Location = new System.Drawing.Point(0, 10);
            this.linkSqlGeneration.Margin = new System.Windows.Forms.Padding(0);
            this.linkSqlGeneration.Name = "linkSqlGeneration";
            this.linkSqlGeneration.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkSqlGeneration.Size = new System.Drawing.Size(141, 23);
            this.linkSqlGeneration.TabIndex = 28;
            this.linkSqlGeneration.TabStop = true;
            this.linkSqlGeneration.Text = "SQL Generation Options";
            this.linkSqlGeneration.UseCompatibleTextRendering = true;
            this.linkSqlGeneration.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkSqlGeneration.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkBehaviorOptions
            // 
            this.linkBehaviorOptions.AutoSize = true;
            this.linkBehaviorOptions.ForeColor = System.Drawing.Color.Black;
            this.linkBehaviorOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkBehaviorOptions.LinkColor = System.Drawing.Color.Black;
            this.linkBehaviorOptions.Location = new System.Drawing.Point(0, 33);
            this.linkBehaviorOptions.Margin = new System.Windows.Forms.Padding(0);
            this.linkBehaviorOptions.Name = "linkBehaviorOptions";
            this.linkBehaviorOptions.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkBehaviorOptions.Size = new System.Drawing.Size(104, 23);
            this.linkBehaviorOptions.TabIndex = 15;
            this.linkBehaviorOptions.TabStop = true;
            this.linkBehaviorOptions.Text = "Behavior Options";
            this.linkBehaviorOptions.UseCompatibleTextRendering = true;
            this.linkBehaviorOptions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkBehaviorOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkDatabaseSchemaView
            // 
            this.linkDatabaseSchemaView.AutoSize = true;
            this.linkDatabaseSchemaView.ForeColor = System.Drawing.Color.Black;
            this.linkDatabaseSchemaView.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDatabaseSchemaView.LinkColor = System.Drawing.Color.Black;
            this.linkDatabaseSchemaView.Location = new System.Drawing.Point(0, 56);
            this.linkDatabaseSchemaView.Margin = new System.Windows.Forms.Padding(0);
            this.linkDatabaseSchemaView.Name = "linkDatabaseSchemaView";
            this.linkDatabaseSchemaView.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkDatabaseSchemaView.Size = new System.Drawing.Size(135, 36);
            this.linkDatabaseSchemaView.TabIndex = 18;
            this.linkDatabaseSchemaView.TabStop = true;
            this.linkDatabaseSchemaView.Text = "DatabaseSchemaView Options";
            this.linkDatabaseSchemaView.UseCompatibleTextRendering = true;
            this.linkDatabaseSchemaView.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkDatabaseSchemaView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkDesignPane
            // 
            this.linkDesignPane.AutoSize = true;
            this.linkDesignPane.ForeColor = System.Drawing.Color.Black;
            this.linkDesignPane.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDesignPane.LinkColor = System.Drawing.Color.Black;
            this.linkDesignPane.Location = new System.Drawing.Point(0, 92);
            this.linkDesignPane.Margin = new System.Windows.Forms.Padding(0);
            this.linkDesignPane.Name = "linkDesignPane";
            this.linkDesignPane.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkDesignPane.Size = new System.Drawing.Size(121, 23);
            this.linkDesignPane.TabIndex = 19;
            this.linkDesignPane.TabStop = true;
            this.linkDesignPane.Text = "DesignPane Options";
            this.linkDesignPane.UseCompatibleTextRendering = true;
            this.linkDesignPane.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkDesignPane.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkVisualOptions
            // 
            this.linkVisualOptions.AutoSize = true;
            this.linkVisualOptions.ForeColor = System.Drawing.Color.Black;
            this.linkVisualOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkVisualOptions.LinkColor = System.Drawing.Color.Black;
            this.linkVisualOptions.Location = new System.Drawing.Point(0, 115);
            this.linkVisualOptions.Margin = new System.Windows.Forms.Padding(0);
            this.linkVisualOptions.Name = "linkVisualOptions";
            this.linkVisualOptions.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkVisualOptions.Size = new System.Drawing.Size(90, 23);
            this.linkVisualOptions.TabIndex = 20;
            this.linkVisualOptions.TabStop = true;
            this.linkVisualOptions.Text = "Visual Options";
            this.linkVisualOptions.UseCompatibleTextRendering = true;
            this.linkVisualOptions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkVisualOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkAddObjectDialog
            // 
            this.linkAddObjectDialog.AutoSize = true;
            this.linkAddObjectDialog.ForeColor = System.Drawing.Color.Black;
            this.linkAddObjectDialog.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkAddObjectDialog.LinkColor = System.Drawing.Color.Black;
            this.linkAddObjectDialog.Location = new System.Drawing.Point(0, 138);
            this.linkAddObjectDialog.Margin = new System.Windows.Forms.Padding(0);
            this.linkAddObjectDialog.Name = "linkAddObjectDialog";
            this.linkAddObjectDialog.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkAddObjectDialog.Size = new System.Drawing.Size(148, 23);
            this.linkAddObjectDialog.TabIndex = 21;
            this.linkAddObjectDialog.TabStop = true;
            this.linkAddObjectDialog.Text = "AddObject Dialog Options";
            this.linkAddObjectDialog.UseCompatibleTextRendering = true;
            this.linkAddObjectDialog.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkAddObjectDialog.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkDatasourceOptions
            // 
            this.linkDatasourceOptions.AutoSize = true;
            this.linkDatasourceOptions.ForeColor = System.Drawing.Color.Black;
            this.linkDatasourceOptions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDatasourceOptions.LinkColor = System.Drawing.Color.Black;
            this.linkDatasourceOptions.Location = new System.Drawing.Point(0, 161);
            this.linkDatasourceOptions.Margin = new System.Windows.Forms.Padding(0);
            this.linkDatasourceOptions.Name = "linkDatasourceOptions";
            this.linkDatasourceOptions.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkDatasourceOptions.Size = new System.Drawing.Size(117, 23);
            this.linkDatasourceOptions.TabIndex = 22;
            this.linkDatasourceOptions.TabStop = true;
            this.linkDatasourceOptions.Text = "Datasource Options";
            this.linkDatasourceOptions.UseCompatibleTextRendering = true;
            this.linkDatasourceOptions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkDatasourceOptions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkQueryColumnList
            // 
            this.linkQueryColumnList.AutoSize = true;
            this.linkQueryColumnList.ForeColor = System.Drawing.Color.Black;
            this.linkQueryColumnList.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkQueryColumnList.LinkColor = System.Drawing.Color.Black;
            this.linkQueryColumnList.Location = new System.Drawing.Point(0, 184);
            this.linkQueryColumnList.Margin = new System.Windows.Forms.Padding(0);
            this.linkQueryColumnList.Name = "linkQueryColumnList";
            this.linkQueryColumnList.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkQueryColumnList.Size = new System.Drawing.Size(153, 23);
            this.linkQueryColumnList.TabIndex = 25;
            this.linkQueryColumnList.TabStop = true;
            this.linkQueryColumnList.Text = "QueryColumnsList Options";
            this.linkQueryColumnList.UseCompatibleTextRendering = true;
            this.linkQueryColumnList.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkQueryColumnList.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkQueryNavBar
            // 
            this.linkQueryNavBar.AutoSize = true;
            this.linkQueryNavBar.ForeColor = System.Drawing.Color.Black;
            this.linkQueryNavBar.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkQueryNavBar.LinkColor = System.Drawing.Color.Black;
            this.linkQueryNavBar.Location = new System.Drawing.Point(0, 207);
            this.linkQueryNavBar.Margin = new System.Windows.Forms.Padding(0);
            this.linkQueryNavBar.Name = "linkQueryNavBar";
            this.linkQueryNavBar.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkQueryNavBar.Size = new System.Drawing.Size(128, 23);
            this.linkQueryNavBar.TabIndex = 26;
            this.linkQueryNavBar.TabStop = true;
            this.linkQueryNavBar.Text = "QueryNavBar Options";
            this.linkQueryNavBar.UseCompatibleTextRendering = true;
            this.linkQueryNavBar.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkQueryNavBar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // linkQueryView
            // 
            this.linkQueryView.AutoSize = true;
            this.linkQueryView.ForeColor = System.Drawing.Color.Black;
            this.linkQueryView.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkQueryView.LinkColor = System.Drawing.Color.Black;
            this.linkQueryView.Location = new System.Drawing.Point(0, 230);
            this.linkQueryView.Margin = new System.Windows.Forms.Padding(0);
            this.linkQueryView.Name = "linkQueryView";
            this.linkQueryView.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.linkQueryView.Size = new System.Drawing.Size(127, 23);
            this.linkQueryView.TabIndex = 27;
            this.linkQueryView.TabStop = true;
            this.linkQueryView.Text = "UserInterface Options";
            this.linkQueryView.UseCompatibleTextRendering = true;
            this.linkQueryView.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkQueryView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // lbExpressionEditor
            // 
            this.lbExpressionEditor.AutoSize = true;
            this.lbExpressionEditor.ForeColor = System.Drawing.Color.Black;
            this.lbExpressionEditor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbExpressionEditor.LinkColor = System.Drawing.Color.Black;
            this.lbExpressionEditor.Location = new System.Drawing.Point(0, 253);
            this.lbExpressionEditor.Margin = new System.Windows.Forms.Padding(0);
            this.lbExpressionEditor.Name = "lbExpressionEditor";
            this.lbExpressionEditor.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.lbExpressionEditor.Size = new System.Drawing.Size(148, 23);
            this.lbExpressionEditor.TabIndex = 29;
            this.lbExpressionEditor.TabStop = true;
            this.lbExpressionEditor.Text = "Expression Editor Options";
            this.lbExpressionEditor.UseCompatibleTextRendering = true;
            this.lbExpressionEditor.VisitedLinkColor = System.Drawing.Color.Black;
            this.lbExpressionEditor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // lbTextEditor
            // 
            this.lbTextEditor.AutoSize = true;
            this.lbTextEditor.ForeColor = System.Drawing.Color.Black;
            this.lbTextEditor.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbTextEditor.LinkColor = System.Drawing.Color.Black;
            this.lbTextEditor.Location = new System.Drawing.Point(0, 276);
            this.lbTextEditor.Margin = new System.Windows.Forms.Padding(0);
            this.lbTextEditor.Name = "lbTextEditor";
            this.lbTextEditor.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.lbTextEditor.Size = new System.Drawing.Size(148, 23);
            this.lbTextEditor.TabIndex = 30;
            this.lbTextEditor.TabStop = true;
            this.lbTextEditor.Text = "Text Editor Visual Options";
            this.lbTextEditor.UseCompatibleTextRendering = true;
            this.lbTextEditor.VisitedLinkColor = System.Drawing.Color.Black;
            this.lbTextEditor.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // lbTextEditorSql
            // 
            this.lbTextEditorSql.AutoSize = true;
            this.lbTextEditorSql.ForeColor = System.Drawing.Color.Black;
            this.lbTextEditorSql.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbTextEditorSql.LinkColor = System.Drawing.Color.Black;
            this.lbTextEditorSql.Location = new System.Drawing.Point(0, 299);
            this.lbTextEditorSql.Margin = new System.Windows.Forms.Padding(0);
            this.lbTextEditorSql.Name = "lbTextEditorSql";
            this.lbTextEditorSql.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.lbTextEditorSql.Size = new System.Drawing.Size(140, 23);
            this.lbTextEditorSql.TabIndex = 31;
            this.lbTextEditorSql.TabStop = true;
            this.lbTextEditorSql.Text = "Text Editor SQL Options";
            this.lbTextEditorSql.UseCompatibleTextRendering = true;
            this.lbTextEditorSql.VisitedLinkColor = System.Drawing.Color.Black;
            this.lbTextEditorSql.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu1_LinkClicked);
            // 
            // tabFormatting
            // 
            this.tabFormatting.Controls.Add(this.panelSqlFormatting);
            this.tabFormatting.Location = new System.Drawing.Point(4, 22);
            this.tabFormatting.Name = "tabFormatting";
            this.tabFormatting.Padding = new System.Windows.Forms.Padding(3);
            this.tabFormatting.Size = new System.Drawing.Size(716, 417);
            this.tabFormatting.TabIndex = 1;
            this.tabFormatting.Text = "SQL Formatting properties";
            this.tabFormatting.UseVisualStyleBackColor = true;
            // 
            // panelSqlFormatting
            // 
            this.panelSqlFormatting.Controls.Add(this.panelPages2);
            this.panelSqlFormatting.Controls.Add(this.flowLayoutPanel2);
            this.panelSqlFormatting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSqlFormatting.Location = new System.Drawing.Point(3, 3);
            this.panelSqlFormatting.Name = "panelSqlFormatting";
            this.panelSqlFormatting.Size = new System.Drawing.Size(710, 411);
            this.panelSqlFormatting.TabIndex = 4;
            // 
            // panelPages2
            // 
            this.panelPages2.AutoScroll = true;
            this.panelPages2.AutoSize = true;
            this.panelPages2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPages2.BackColor = System.Drawing.Color.White;
            this.panelPages2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPages2.Location = new System.Drawing.Point(170, 0);
            this.panelPages2.Margin = new System.Windows.Forms.Padding(0);
            this.panelPages2.Name = "panelPages2";
            this.panelPages2.Padding = new System.Windows.Forms.Padding(10, 10, 6, 6);
            this.panelPages2.Size = new System.Drawing.Size(540, 411);
            this.panelPages2.TabIndex = 7;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel2.Controls.Add(this.labelSqlFormatting);
            this.flowLayoutPanel2.Controls.Add(this.linkMain);
            this.flowLayoutPanel2.Controls.Add(this.linkMainCommon);
            this.flowLayoutPanel2.Controls.Add(this.linkMainExpressions);
            this.flowLayoutPanel2.Controls.Add(this.linkCte);
            this.flowLayoutPanel2.Controls.Add(this.linkCteCommon);
            this.flowLayoutPanel2.Controls.Add(this.linkCteExpressions);
            this.flowLayoutPanel2.Controls.Add(this.linkDerived);
            this.flowLayoutPanel2.Controls.Add(this.linkDerivedCommon);
            this.flowLayoutPanel2.Controls.Add(this.linkDerivedExpressions);
            this.flowLayoutPanel2.Controls.Add(this.linkExpression);
            this.flowLayoutPanel2.Controls.Add(this.linkExpressionCommon);
            this.flowLayoutPanel2.Controls.Add(this.linkExpressionExpressions);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(170, 411);
            this.flowLayoutPanel2.TabIndex = 6;
            this.flowLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel_Paint);
            // 
            // labelSqlFormatting
            // 
            this.labelSqlFormatting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSqlFormatting.AutoSize = true;
            this.labelSqlFormatting.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSqlFormatting.Location = new System.Drawing.Point(0, 10);
            this.labelSqlFormatting.Margin = new System.Windows.Forms.Padding(0);
            this.labelSqlFormatting.Name = "labelSqlFormatting";
            this.labelSqlFormatting.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.labelSqlFormatting.Size = new System.Drawing.Size(137, 24);
            this.labelSqlFormatting.TabIndex = 10;
            this.labelSqlFormatting.Text = "SQL Options";
            this.labelSqlFormatting.UseCompatibleTextRendering = true;
            // 
            // linkMain
            // 
            this.linkMain.AutoSize = true;
            this.linkMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkMain.ForeColor = System.Drawing.Color.Black;
            this.linkMain.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkMain.LinkColor = System.Drawing.Color.Black;
            this.linkMain.Location = new System.Drawing.Point(0, 34);
            this.linkMain.Margin = new System.Windows.Forms.Padding(0);
            this.linkMain.Name = "linkMain";
            this.linkMain.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkMain.Size = new System.Drawing.Size(85, 23);
            this.linkMain.TabIndex = 26;
            this.linkMain.TabStop = true;
            this.linkMain.Text = "Main query";
            this.linkMain.UseCompatibleTextRendering = true;
            this.linkMain.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkMain.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkMainCommon
            // 
            this.linkMainCommon.AutoSize = true;
            this.linkMainCommon.ForeColor = System.Drawing.Color.Black;
            this.linkMainCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkMainCommon.LinkColor = System.Drawing.Color.Black;
            this.linkMainCommon.Location = new System.Drawing.Point(0, 57);
            this.linkMainCommon.Margin = new System.Windows.Forms.Padding(0);
            this.linkMainCommon.Name = "linkMainCommon";
            this.linkMainCommon.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkMainCommon.Size = new System.Drawing.Size(85, 23);
            this.linkMainCommon.TabIndex = 27;
            this.linkMainCommon.TabStop = true;
            this.linkMainCommon.Text = "    Common";
            this.linkMainCommon.UseCompatibleTextRendering = true;
            this.linkMainCommon.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkMainCommon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkMainExpressions
            // 
            this.linkMainExpressions.AutoSize = true;
            this.linkMainExpressions.ForeColor = System.Drawing.Color.Black;
            this.linkMainExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkMainExpressions.LinkColor = System.Drawing.Color.Black;
            this.linkMainExpressions.Location = new System.Drawing.Point(0, 80);
            this.linkMainExpressions.Margin = new System.Windows.Forms.Padding(0);
            this.linkMainExpressions.Name = "linkMainExpressions";
            this.linkMainExpressions.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkMainExpressions.Size = new System.Drawing.Size(101, 23);
            this.linkMainExpressions.TabIndex = 28;
            this.linkMainExpressions.TabStop = true;
            this.linkMainExpressions.Text = "    Expressions";
            this.linkMainExpressions.UseCompatibleTextRendering = true;
            this.linkMainExpressions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkMainExpressions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkCte
            // 
            this.linkCte.AutoSize = true;
            this.linkCte.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkCte.ForeColor = System.Drawing.Color.Black;
            this.linkCte.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCte.LinkColor = System.Drawing.Color.Black;
            this.linkCte.Location = new System.Drawing.Point(0, 103);
            this.linkCte.Margin = new System.Windows.Forms.Padding(0);
            this.linkCte.Name = "linkCte";
            this.linkCte.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkCte.Size = new System.Drawing.Size(83, 23);
            this.linkCte.TabIndex = 29;
            this.linkCte.TabStop = true;
            this.linkCte.Text = "CTE query";
            this.linkCte.UseCompatibleTextRendering = true;
            this.linkCte.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkCte.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkCteCommon
            // 
            this.linkCteCommon.AutoSize = true;
            this.linkCteCommon.ForeColor = System.Drawing.Color.Black;
            this.linkCteCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCteCommon.LinkColor = System.Drawing.Color.Black;
            this.linkCteCommon.Location = new System.Drawing.Point(0, 126);
            this.linkCteCommon.Margin = new System.Windows.Forms.Padding(0);
            this.linkCteCommon.Name = "linkCteCommon";
            this.linkCteCommon.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkCteCommon.Size = new System.Drawing.Size(85, 23);
            this.linkCteCommon.TabIndex = 30;
            this.linkCteCommon.TabStop = true;
            this.linkCteCommon.Text = "    Common";
            this.linkCteCommon.UseCompatibleTextRendering = true;
            this.linkCteCommon.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkCteCommon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkCteExpressions
            // 
            this.linkCteExpressions.AutoSize = true;
            this.linkCteExpressions.ForeColor = System.Drawing.Color.Black;
            this.linkCteExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkCteExpressions.LinkColor = System.Drawing.Color.Black;
            this.linkCteExpressions.Location = new System.Drawing.Point(0, 149);
            this.linkCteExpressions.Margin = new System.Windows.Forms.Padding(0);
            this.linkCteExpressions.Name = "linkCteExpressions";
            this.linkCteExpressions.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkCteExpressions.Size = new System.Drawing.Size(101, 23);
            this.linkCteExpressions.TabIndex = 31;
            this.linkCteExpressions.TabStop = true;
            this.linkCteExpressions.Text = "    Expressions";
            this.linkCteExpressions.UseCompatibleTextRendering = true;
            this.linkCteExpressions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkCteExpressions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkDerived
            // 
            this.linkDerived.AutoSize = true;
            this.linkDerived.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkDerived.ForeColor = System.Drawing.Color.Black;
            this.linkDerived.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDerived.LinkColor = System.Drawing.Color.Black;
            this.linkDerived.Location = new System.Drawing.Point(0, 172);
            this.linkDerived.Margin = new System.Windows.Forms.Padding(0);
            this.linkDerived.Name = "linkDerived";
            this.linkDerived.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkDerived.Size = new System.Drawing.Size(100, 23);
            this.linkDerived.TabIndex = 32;
            this.linkDerived.TabStop = true;
            this.linkDerived.Text = "Derived query";
            this.linkDerived.UseCompatibleTextRendering = true;
            this.linkDerived.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkDerived.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkDerivedCommon
            // 
            this.linkDerivedCommon.AutoSize = true;
            this.linkDerivedCommon.ForeColor = System.Drawing.Color.Black;
            this.linkDerivedCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDerivedCommon.LinkColor = System.Drawing.Color.Black;
            this.linkDerivedCommon.Location = new System.Drawing.Point(0, 195);
            this.linkDerivedCommon.Margin = new System.Windows.Forms.Padding(0);
            this.linkDerivedCommon.Name = "linkDerivedCommon";
            this.linkDerivedCommon.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkDerivedCommon.Size = new System.Drawing.Size(85, 23);
            this.linkDerivedCommon.TabIndex = 33;
            this.linkDerivedCommon.TabStop = true;
            this.linkDerivedCommon.Text = "    Common";
            this.linkDerivedCommon.UseCompatibleTextRendering = true;
            this.linkDerivedCommon.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkDerivedCommon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkDerivedExpressions
            // 
            this.linkDerivedExpressions.AutoSize = true;
            this.linkDerivedExpressions.ForeColor = System.Drawing.Color.Black;
            this.linkDerivedExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkDerivedExpressions.LinkColor = System.Drawing.Color.Black;
            this.linkDerivedExpressions.Location = new System.Drawing.Point(0, 218);
            this.linkDerivedExpressions.Margin = new System.Windows.Forms.Padding(0);
            this.linkDerivedExpressions.Name = "linkDerivedExpressions";
            this.linkDerivedExpressions.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkDerivedExpressions.Size = new System.Drawing.Size(101, 23);
            this.linkDerivedExpressions.TabIndex = 34;
            this.linkDerivedExpressions.TabStop = true;
            this.linkDerivedExpressions.Text = "    Expressions";
            this.linkDerivedExpressions.UseCompatibleTextRendering = true;
            this.linkDerivedExpressions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkDerivedExpressions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkExpression
            // 
            this.linkExpression.AutoSize = true;
            this.linkExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkExpression.ForeColor = System.Drawing.Color.Black;
            this.linkExpression.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkExpression.LinkColor = System.Drawing.Color.Black;
            this.linkExpression.Location = new System.Drawing.Point(0, 241);
            this.linkExpression.Margin = new System.Windows.Forms.Padding(0);
            this.linkExpression.Name = "linkExpression";
            this.linkExpression.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkExpression.Size = new System.Drawing.Size(137, 23);
            this.linkExpression.TabIndex = 35;
            this.linkExpression.TabStop = true;
            this.linkExpression.Text = "Expression subquery";
            this.linkExpression.UseCompatibleTextRendering = true;
            this.linkExpression.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkExpression.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkExpressionCommon
            // 
            this.linkExpressionCommon.AutoSize = true;
            this.linkExpressionCommon.ForeColor = System.Drawing.Color.Black;
            this.linkExpressionCommon.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkExpressionCommon.LinkColor = System.Drawing.Color.Black;
            this.linkExpressionCommon.Location = new System.Drawing.Point(0, 264);
            this.linkExpressionCommon.Margin = new System.Windows.Forms.Padding(0);
            this.linkExpressionCommon.Name = "linkExpressionCommon";
            this.linkExpressionCommon.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkExpressionCommon.Size = new System.Drawing.Size(85, 23);
            this.linkExpressionCommon.TabIndex = 36;
            this.linkExpressionCommon.TabStop = true;
            this.linkExpressionCommon.Text = "    Common";
            this.linkExpressionCommon.UseCompatibleTextRendering = true;
            this.linkExpressionCommon.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkExpressionCommon.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // linkExpressionExpressions
            // 
            this.linkExpressionExpressions.AutoSize = true;
            this.linkExpressionExpressions.ForeColor = System.Drawing.Color.Black;
            this.linkExpressionExpressions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.linkExpressionExpressions.LinkColor = System.Drawing.Color.Black;
            this.linkExpressionExpressions.Location = new System.Drawing.Point(0, 287);
            this.linkExpressionExpressions.Margin = new System.Windows.Forms.Padding(0);
            this.linkExpressionExpressions.Name = "linkExpressionExpressions";
            this.linkExpressionExpressions.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.linkExpressionExpressions.Size = new System.Drawing.Size(101, 23);
            this.linkExpressionExpressions.TabIndex = 37;
            this.linkExpressionExpressions.TabStop = true;
            this.linkExpressionExpressions.Text = "    Expressions";
            this.linkExpressionExpressions.UseCompatibleTextRendering = true;
            this.linkExpressionExpressions.VisitedLinkColor = System.Drawing.Color.Black;
            this.linkExpressionExpressions.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu2_LinkClicked);
            // 
            // QueryPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(781, 482);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panelButtons);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QueryPropertiesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Properties";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QueryPropertiesForm_FormClosing);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.QueryBuilderPropertiesForm_Paint);
            this.panelButtons.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabQueryBuilder.ResumeLayout(false);
            this.panelQueryBuilder.ResumeLayout(false);
            this.panelQueryBuilder.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabFormatting.ResumeLayout(false);
            this.panelSqlFormatting.ResumeLayout(false);
            this.panelSqlFormatting.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabQueryBuilder;
        private System.Windows.Forms.Panel panelQueryBuilder;
        private System.Windows.Forms.Panel panelPages1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.LinkLabel linkBehaviorOptions;
        private System.Windows.Forms.LinkLabel linkDatabaseSchemaView;
        private System.Windows.Forms.LinkLabel linkDesignPane;
        private System.Windows.Forms.LinkLabel linkVisualOptions;
        private System.Windows.Forms.LinkLabel linkAddObjectDialog;
        private System.Windows.Forms.LinkLabel linkDatasourceOptions;
        private System.Windows.Forms.LinkLabel linkQueryColumnList;
        private System.Windows.Forms.TabPage tabFormatting;
        private System.Windows.Forms.Panel panelSqlFormatting;
        private System.Windows.Forms.Panel panelPages2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label labelSqlFormatting;
        private System.Windows.Forms.LinkLabel linkMain;
        private System.Windows.Forms.LinkLabel linkMainCommon;
        private System.Windows.Forms.LinkLabel linkMainExpressions;
        private System.Windows.Forms.LinkLabel linkCte;
        private System.Windows.Forms.LinkLabel linkCteCommon;
        private System.Windows.Forms.LinkLabel linkCteExpressions;
        private System.Windows.Forms.LinkLabel linkDerived;
        private System.Windows.Forms.LinkLabel linkDerivedCommon;
        private System.Windows.Forms.LinkLabel linkDerivedExpressions;
        private System.Windows.Forms.LinkLabel linkExpression;
        private System.Windows.Forms.LinkLabel linkExpressionCommon;
        private System.Windows.Forms.LinkLabel linkExpressionExpressions;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.LinkLabel linkQueryNavBar;
        private System.Windows.Forms.LinkLabel linkQueryView;
        private System.Windows.Forms.LinkLabel linkSqlGeneration;
        private System.Windows.Forms.LinkLabel lbExpressionEditor;
        private System.Windows.Forms.LinkLabel lbTextEditor;
        private System.Windows.Forms.LinkLabel lbTextEditorSql;
    }
}
