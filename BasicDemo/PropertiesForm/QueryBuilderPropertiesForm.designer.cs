namespace BasicDemo.PropertiesForm
{
	partial class QueryBuilderPropertiesForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryBuilderPropertiesForm));
			this.panelButtons = new System.Windows.Forms.Panel();
			this.buttonApply = new System.Windows.Forms.Button();
			this.buttonOk = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.label17 = new System.Windows.Forms.Label();
			this.numericUpDown6 = new System.Windows.Forms.NumericUpDown();
			this.checkBox27 = new System.Windows.Forms.CheckBox();
			this.checkBox28 = new System.Windows.Forms.CheckBox();
			this.checkBox29 = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.numericUpDown7 = new System.Windows.Forms.NumericUpDown();
			this.checkBox30 = new System.Windows.Forms.CheckBox();
			this.checkBox31 = new System.Windows.Forms.CheckBox();
			this.checkBox32 = new System.Windows.Forms.CheckBox();
			this.checkBox33 = new System.Windows.Forms.CheckBox();
			this.checkBox34 = new System.Windows.Forms.CheckBox();
			this.numericUpDown8 = new System.Windows.Forms.NumericUpDown();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.numericUpDown9 = new System.Windows.Forms.NumericUpDown();
			this.checkBox35 = new System.Windows.Forms.CheckBox();
			this.checkBox36 = new System.Windows.Forms.CheckBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panelPages = new System.Windows.Forms.Panel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.labelNonVisual = new System.Windows.Forms.Label();
			this.linkSqlSyntax = new System.Windows.Forms.LinkLabel();
			this.linkOfflineMode = new System.Windows.Forms.LinkLabel();
			this.labelVisual = new System.Windows.Forms.Label();
			this.linkPanesVisibility = new System.Windows.Forms.LinkLabel();
			this.linkMetadataTree = new System.Windows.Forms.LinkLabel();
			this.linkMiscellaneous = new System.Windows.Forms.LinkLabel();
			this.labelSqlBuilder = new System.Windows.Forms.Label();
			this.linkGeneral = new System.Windows.Forms.LinkLabel();
			this.linkMainQuery = new System.Windows.Forms.LinkLabel();
			this.linkDerievedQueries = new System.Windows.Forms.LinkLabel();
			this.linkExpressionSubqueries = new System.Windows.Forms.LinkLabel();
			this.panelHeader = new System.Windows.Forms.Panel();
			this.labelHeader = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panelButtons.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).BeginInit();
			this.panel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.panelHeader.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			//
			// panelButtons
			//
			this.panelButtons.Controls.Add(this.buttonApply);
			this.panelButtons.Controls.Add(this.buttonOk);
			this.panelButtons.Controls.Add(this.buttonCancel);
			this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelButtons.Location = new System.Drawing.Point(0, 438);
			this.panelButtons.Name = "panelButtons";
			this.panelButtons.Size = new System.Drawing.Size(624, 39);
			this.panelButtons.TabIndex = 2;
			//
			// buttonApply
			//
			this.buttonApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonApply.Location = new System.Drawing.Point(540, 4);
			this.buttonApply.Name = "buttonApply";
			this.buttonApply.Size = new System.Drawing.Size(75, 23);
			this.buttonApply.TabIndex = 2;
			this.buttonApply.Text = "Apply";
			this.buttonApply.UseVisualStyleBackColor = true;
			this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
			//
			// buttonOk
			//
			this.buttonOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new System.Drawing.Point(378, 4);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 0;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
			//
			// buttonCancel
			//
			this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new System.Drawing.Point(459, 4);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 1;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			//
			// label17
			//
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(283, 20);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(127, 13);
			this.label17.TabIndex = 5;
			this.label17.Text = "Nested conditions indent:";
			//
			// numericUpDown6
			//
			this.numericUpDown6.Location = new System.Drawing.Point(416, 18);
			this.numericUpDown6.Name = "numericUpDown6";
			this.numericUpDown6.Size = new System.Drawing.Size(45, 20);
			this.numericUpDown6.TabIndex = 5;
			//
			// checkBox27
			//
			this.checkBox27.AutoSize = true;
			this.checkBox27.Location = new System.Drawing.Point(6, 42);
			this.checkBox27.Name = "checkBox27";
			this.checkBox27.Size = new System.Drawing.Size(248, 17);
			this.checkBox27.TabIndex = 2;
			this.checkBox27.Text = "Insert new line after the rest of logical operators";
			this.checkBox27.UseVisualStyleBackColor = true;
			//
			// checkBox28
			//
			this.checkBox28.AutoSize = true;
			this.checkBox28.Location = new System.Drawing.Point(6, 19);
			this.checkBox28.Name = "checkBox28";
			this.checkBox28.Size = new System.Drawing.Size(238, 17);
			this.checkBox28.TabIndex = 1;
			this.checkBox28.Text = "Insert new line after topmost logical operators";
			this.checkBox28.UseVisualStyleBackColor = true;
			//
			// checkBox29
			//
			this.checkBox29.AutoSize = true;
			this.checkBox29.Location = new System.Drawing.Point(6, 19);
			this.checkBox29.Name = "checkBox29";
			this.checkBox29.Size = new System.Drawing.Size(212, 17);
			this.checkBox29.TabIndex = 1;
			this.checkBox29.Text = "Insert new line after each group list item";
			this.checkBox29.UseVisualStyleBackColor = true;
			//
			// label18
			//
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(283, 20);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(127, 13);
			this.label18.TabIndex = 5;
			this.label18.Text = "Nested conditions indent:";
			//
			// numericUpDown7
			//
			this.numericUpDown7.Location = new System.Drawing.Point(416, 18);
			this.numericUpDown7.Name = "numericUpDown7";
			this.numericUpDown7.Size = new System.Drawing.Size(45, 20);
			this.numericUpDown7.TabIndex = 5;
			//
			// checkBox30
			//
			this.checkBox30.AutoSize = true;
			this.checkBox30.Location = new System.Drawing.Point(6, 42);
			this.checkBox30.Name = "checkBox30";
			this.checkBox30.Size = new System.Drawing.Size(248, 17);
			this.checkBox30.TabIndex = 2;
			this.checkBox30.Text = "Insert new line after the rest of logical operators";
			this.checkBox30.UseVisualStyleBackColor = true;
			//
			// checkBox31
			//
			this.checkBox31.AutoSize = true;
			this.checkBox31.Location = new System.Drawing.Point(6, 19);
			this.checkBox31.Name = "checkBox31";
			this.checkBox31.Size = new System.Drawing.Size(238, 17);
			this.checkBox31.TabIndex = 1;
			this.checkBox31.Text = "Insert new line after topmost logical operators";
			this.checkBox31.UseVisualStyleBackColor = true;
			//
			// checkBox32
			//
			this.checkBox32.AutoSize = true;
			this.checkBox32.Location = new System.Drawing.Point(6, 42);
			this.checkBox32.Name = "checkBox32";
			this.checkBox32.Size = new System.Drawing.Size(215, 17);
			this.checkBox32.TabIndex = 2;
			this.checkBox32.Text = "Insert new line after each JOIN keyword";
			this.checkBox32.UseVisualStyleBackColor = true;
			//
			// checkBox33
			//
			this.checkBox33.AutoSize = true;
			this.checkBox33.Location = new System.Drawing.Point(6, 19);
			this.checkBox33.Name = "checkBox33";
			this.checkBox33.Size = new System.Drawing.Size(229, 17);
			this.checkBox33.TabIndex = 1;
			this.checkBox33.Text = "Insert new line after each datat source item";
			this.checkBox33.UseVisualStyleBackColor = true;
			//
			// checkBox34
			//
			this.checkBox34.AutoSize = true;
			this.checkBox34.Location = new System.Drawing.Point(6, 19);
			this.checkBox34.Name = "checkBox34";
			this.checkBox34.Size = new System.Drawing.Size(213, 17);
			this.checkBox34.TabIndex = 1;
			this.checkBox34.Text = "Insert new line after each select list item";
			this.checkBox34.UseVisualStyleBackColor = true;
			//
			// numericUpDown8
			//
			this.numericUpDown8.Location = new System.Drawing.Point(308, 44);
			this.numericUpDown8.Name = "numericUpDown8";
			this.numericUpDown8.Size = new System.Drawing.Size(45, 20);
			this.numericUpDown8.TabIndex = 4;
			//
			// label19
			//
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(228, 46);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(61, 13);
			this.label19.TabIndex = 3;
			this.label19.Text = "Part indent:";
			//
			// label20
			//
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(228, 20);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(72, 13);
			this.label20.TabIndex = 1;
			this.label20.Text = "Global indent:";
			//
			// numericUpDown9
			//
			this.numericUpDown9.Location = new System.Drawing.Point(308, 18);
			this.numericUpDown9.Name = "numericUpDown9";
			this.numericUpDown9.Size = new System.Drawing.Size(45, 20);
			this.numericUpDown9.TabIndex = 1;
			//
			// checkBox35
			//
			this.checkBox35.AutoSize = true;
			this.checkBox35.Location = new System.Drawing.Point(6, 45);
			this.checkBox35.Name = "checkBox35";
			this.checkBox35.Size = new System.Drawing.Size(182, 17);
			this.checkBox35.TabIndex = 2;
			this.checkBox35.Text = "Insert new line after part keyword";
			this.checkBox35.UseVisualStyleBackColor = true;
			//
			// checkBox36
			//
			this.checkBox36.AutoSize = true;
			this.checkBox36.Location = new System.Drawing.Point(6, 19);
			this.checkBox36.Name = "checkBox36";
			this.checkBox36.Size = new System.Drawing.Size(136, 17);
			this.checkBox36.TabIndex = 1;
			this.checkBox36.Text = "Start parts on new lines";
			this.checkBox36.UseVisualStyleBackColor = true;
			//
			// panel1
			//
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.Controls.Add(this.panelPages);
			this.panel1.Controls.Add(this.flowLayoutPanel1);
			this.panel1.Controls.Add(this.panelHeader);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(600, 420);
			this.panel1.TabIndex = 3;
			//
			// panelPages
			//
			this.panelPages.AutoScroll = true;
			this.panelPages.AutoSize = true;
			this.panelPages.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panelPages.BackColor = System.Drawing.Color.White;
			this.panelPages.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelPages.Location = new System.Drawing.Point(170, 60);
			this.panelPages.Margin = new System.Windows.Forms.Padding(0);
			this.panelPages.Name = "panelPages";
			this.panelPages.Padding = new System.Windows.Forms.Padding(10, 10, 6, 6);
			this.panelPages.Size = new System.Drawing.Size(430, 360);
			this.panelPages.TabIndex = 7;
			//
			// flowLayoutPanel1
			//
			this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
			this.flowLayoutPanel1.Controls.Add(this.labelNonVisual);
			this.flowLayoutPanel1.Controls.Add(this.linkSqlSyntax);
			this.flowLayoutPanel1.Controls.Add(this.linkOfflineMode);
			this.flowLayoutPanel1.Controls.Add(this.labelVisual);
			this.flowLayoutPanel1.Controls.Add(this.linkPanesVisibility);
			this.flowLayoutPanel1.Controls.Add(this.linkMetadataTree);
			this.flowLayoutPanel1.Controls.Add(this.linkMiscellaneous);
			this.flowLayoutPanel1.Controls.Add(this.labelSqlBuilder);
			this.flowLayoutPanel1.Controls.Add(this.linkGeneral);
			this.flowLayoutPanel1.Controls.Add(this.linkMainQuery);
			this.flowLayoutPanel1.Controls.Add(this.linkDerievedQueries);
			this.flowLayoutPanel1.Controls.Add(this.linkExpressionSubqueries);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 60);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
			this.flowLayoutPanel1.Size = new System.Drawing.Size(170, 360);
			this.flowLayoutPanel1.TabIndex = 6;
			this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
			//
			// labelNonVisual
			//
			this.labelNonVisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelNonVisual.AutoSize = true;
			this.labelNonVisual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelNonVisual.Location = new System.Drawing.Point(0, 10);
			this.labelNonVisual.Margin = new System.Windows.Forms.Padding(0);
			this.labelNonVisual.Name = "labelNonVisual";
			this.labelNonVisual.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.labelNonVisual.Size = new System.Drawing.Size(148, 24);
			this.labelNonVisual.TabIndex = 0;
			this.labelNonVisual.Text = "Non-visual Options";
			this.labelNonVisual.UseCompatibleTextRendering = true;
			//
			// linkSqlSyntax
			//
			this.linkSqlSyntax.AutoSize = true;
			this.linkSqlSyntax.ForeColor = System.Drawing.Color.Black;
			this.linkSqlSyntax.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkSqlSyntax.LinkColor = System.Drawing.Color.Black;
			this.linkSqlSyntax.Location = new System.Drawing.Point(0, 34);
			this.linkSqlSyntax.Margin = new System.Windows.Forms.Padding(0);
			this.linkSqlSyntax.Name = "linkSqlSyntax";
			this.linkSqlSyntax.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkSqlSyntax.Size = new System.Drawing.Size(87, 23);
			this.linkSqlSyntax.TabIndex = 3;
			this.linkSqlSyntax.TabStop = true;
			this.linkSqlSyntax.Text = "SQL Syntax";
			this.linkSqlSyntax.UseCompatibleTextRendering = true;
			this.linkSqlSyntax.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkSqlSyntax.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// linkOfflineMode
			//
			this.linkOfflineMode.AutoSize = true;
			this.linkOfflineMode.ForeColor = System.Drawing.Color.Black;
			this.linkOfflineMode.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkOfflineMode.LinkColor = System.Drawing.Color.Black;
			this.linkOfflineMode.Location = new System.Drawing.Point(0, 57);
			this.linkOfflineMode.Margin = new System.Windows.Forms.Padding(0);
			this.linkOfflineMode.Name = "linkOfflineMode";
			this.linkOfflineMode.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkOfflineMode.Size = new System.Drawing.Size(91, 23);
			this.linkOfflineMode.TabIndex = 4;
			this.linkOfflineMode.TabStop = true;
			this.linkOfflineMode.Text = "Offline Mode";
			this.linkOfflineMode.UseCompatibleTextRendering = true;
			this.linkOfflineMode.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkOfflineMode.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// labelVisual
			//
			this.labelVisual.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelVisual.AutoSize = true;
			this.labelVisual.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelVisual.Location = new System.Drawing.Point(0, 80);
			this.labelVisual.Margin = new System.Windows.Forms.Padding(0);
			this.labelVisual.Name = "labelVisual";
			this.labelVisual.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.labelVisual.Size = new System.Drawing.Size(148, 24);
			this.labelVisual.TabIndex = 5;
			this.labelVisual.Text = "Visual Options";
			this.labelVisual.UseCompatibleTextRendering = true;
			//
			// linkPanesVisibility
			//
			this.linkPanesVisibility.AutoSize = true;
			this.linkPanesVisibility.ForeColor = System.Drawing.Color.Black;
			this.linkPanesVisibility.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkPanesVisibility.LinkColor = System.Drawing.Color.Black;
			this.linkPanesVisibility.Location = new System.Drawing.Point(0, 104);
			this.linkPanesVisibility.Margin = new System.Windows.Forms.Padding(0);
			this.linkPanesVisibility.Name = "linkPanesVisibility";
			this.linkPanesVisibility.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkPanesVisibility.Size = new System.Drawing.Size(104, 23);
			this.linkPanesVisibility.TabIndex = 6;
			this.linkPanesVisibility.TabStop = true;
			this.linkPanesVisibility.Text = "Panes Visibility";
			this.linkPanesVisibility.UseCompatibleTextRendering = true;
			this.linkPanesVisibility.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkPanesVisibility.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// linkMetadataTree
			//
			this.linkMetadataTree.AutoSize = true;
			this.linkMetadataTree.ForeColor = System.Drawing.Color.Black;
			this.linkMetadataTree.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkMetadataTree.LinkColor = System.Drawing.Color.Black;
			this.linkMetadataTree.Location = new System.Drawing.Point(0, 127);
			this.linkMetadataTree.Margin = new System.Windows.Forms.Padding(0);
			this.linkMetadataTree.Name = "linkMetadataTree";
			this.linkMetadataTree.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkMetadataTree.Size = new System.Drawing.Size(148, 23);
			this.linkMetadataTree.TabIndex = 8;
			this.linkMetadataTree.TabStop = true;
			this.linkMetadataTree.Text = "Database Schema View";
			this.linkMetadataTree.UseCompatibleTextRendering = true;
			this.linkMetadataTree.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkMetadataTree.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// linkMiscellaneous
			//
			this.linkMiscellaneous.AutoSize = true;
			this.linkMiscellaneous.ForeColor = System.Drawing.Color.Black;
			this.linkMiscellaneous.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkMiscellaneous.LinkColor = System.Drawing.Color.Black;
			this.linkMiscellaneous.Location = new System.Drawing.Point(0, 150);
			this.linkMiscellaneous.Margin = new System.Windows.Forms.Padding(0);
			this.linkMiscellaneous.Name = "linkMiscellaneous";
			this.linkMiscellaneous.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkMiscellaneous.Size = new System.Drawing.Size(99, 23);
			this.linkMiscellaneous.TabIndex = 9;
			this.linkMiscellaneous.TabStop = true;
			this.linkMiscellaneous.Text = "Miscellaneous";
			this.linkMiscellaneous.UseCompatibleTextRendering = true;
			this.linkMiscellaneous.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkMiscellaneous.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// labelSqlBuilder
			//
			this.labelSqlBuilder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSqlBuilder.AutoSize = true;
			this.labelSqlBuilder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelSqlBuilder.Location = new System.Drawing.Point(0, 173);
			this.labelSqlBuilder.Margin = new System.Windows.Forms.Padding(0);
			this.labelSqlBuilder.Name = "labelSqlBuilder";
			this.labelSqlBuilder.Padding = new System.Windows.Forms.Padding(10, 3, 3, 3);
			this.labelSqlBuilder.Size = new System.Drawing.Size(148, 24);
			this.labelSqlBuilder.TabIndex = 10;
			this.labelSqlBuilder.Text = "SQL Builder Options";
			this.labelSqlBuilder.UseCompatibleTextRendering = true;
			//
			// linkGeneral
			//
			this.linkGeneral.AutoSize = true;
			this.linkGeneral.ForeColor = System.Drawing.Color.Black;
			this.linkGeneral.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkGeneral.LinkColor = System.Drawing.Color.Black;
			this.linkGeneral.Location = new System.Drawing.Point(0, 197);
			this.linkGeneral.Margin = new System.Windows.Forms.Padding(0);
			this.linkGeneral.Name = "linkGeneral";
			this.linkGeneral.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkGeneral.Size = new System.Drawing.Size(68, 23);
			this.linkGeneral.TabIndex = 11;
			this.linkGeneral.TabStop = true;
			this.linkGeneral.Text = "General";
			this.linkGeneral.UseCompatibleTextRendering = true;
			this.linkGeneral.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkGeneral.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// linkMainQuery
			//
			this.linkMainQuery.AutoSize = true;
			this.linkMainQuery.ForeColor = System.Drawing.Color.Black;
			this.linkMainQuery.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkMainQuery.LinkColor = System.Drawing.Color.Black;
			this.linkMainQuery.Location = new System.Drawing.Point(0, 220);
			this.linkMainQuery.Margin = new System.Windows.Forms.Padding(0);
			this.linkMainQuery.Name = "linkMainQuery";
			this.linkMainQuery.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkMainQuery.Size = new System.Drawing.Size(86, 23);
			this.linkMainQuery.TabIndex = 12;
			this.linkMainQuery.TabStop = true;
			this.linkMainQuery.Text = "Main Query";
			this.linkMainQuery.UseCompatibleTextRendering = true;
			this.linkMainQuery.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkMainQuery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// linkDerievedQueries
			//
			this.linkDerievedQueries.AutoSize = true;
			this.linkDerievedQueries.ForeColor = System.Drawing.Color.Black;
			this.linkDerievedQueries.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkDerievedQueries.LinkColor = System.Drawing.Color.Black;
			this.linkDerievedQueries.Location = new System.Drawing.Point(0, 243);
			this.linkDerievedQueries.Margin = new System.Windows.Forms.Padding(0);
			this.linkDerievedQueries.Name = "linkDerievedQueries";
			this.linkDerievedQueries.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkDerievedQueries.Size = new System.Drawing.Size(115, 23);
			this.linkDerievedQueries.TabIndex = 13;
			this.linkDerievedQueries.TabStop = true;
			this.linkDerievedQueries.Text = "Derieved Queries";
			this.linkDerievedQueries.UseCompatibleTextRendering = true;
			this.linkDerievedQueries.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkDerievedQueries.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// linkExpressionSubqueries
			//
			this.linkExpressionSubqueries.AutoSize = true;
			this.linkExpressionSubqueries.ForeColor = System.Drawing.Color.Black;
			this.linkExpressionSubqueries.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
			this.linkExpressionSubqueries.LinkColor = System.Drawing.Color.Black;
			this.linkExpressionSubqueries.Location = new System.Drawing.Point(0, 266);
			this.linkExpressionSubqueries.Margin = new System.Windows.Forms.Padding(0);
			this.linkExpressionSubqueries.Name = "linkExpressionSubqueries";
			this.linkExpressionSubqueries.Padding = new System.Windows.Forms.Padding(20, 3, 3, 3);
			this.linkExpressionSubqueries.Size = new System.Drawing.Size(137, 23);
			this.linkExpressionSubqueries.TabIndex = 14;
			this.linkExpressionSubqueries.TabStop = true;
			this.linkExpressionSubqueries.Text = "Expression Subqeries";
			this.linkExpressionSubqueries.UseCompatibleTextRendering = true;
			this.linkExpressionSubqueries.VisitedLinkColor = System.Drawing.Color.Black;
			this.linkExpressionSubqueries.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SideMenu_LinkClicked);
			//
			// panelHeader
			//
			this.panelHeader.BackColor = System.Drawing.Color.White;
			this.panelHeader.Controls.Add(this.labelHeader);
			this.panelHeader.Controls.Add(this.pictureBox1);
			this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelHeader.Location = new System.Drawing.Point(0, 0);
			this.panelHeader.Name = "panelHeader";
			this.panelHeader.Size = new System.Drawing.Size(600, 60);
			this.panelHeader.TabIndex = 8;
			//
			// labelHeader
			//
			this.labelHeader.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labelHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelHeader.ForeColor = System.Drawing.Color.CornflowerBlue;
			this.labelHeader.Location = new System.Drawing.Point(0, 0);
			this.labelHeader.Margin = new System.Windows.Forms.Padding(0);
			this.labelHeader.Name = "labelHeader";
			this.labelHeader.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.labelHeader.Size = new System.Drawing.Size(539, 60);
			this.labelHeader.TabIndex = 1;
			this.labelHeader.Text = "Query Builder Properties";
			this.labelHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			//
			// pictureBox1
			//
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(539, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(61, 60);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			//
			// QueryBuilderPropertiesForm
			//
			this.AcceptButton = this.buttonOk;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.buttonCancel;
			this.ClientSize = new System.Drawing.Size(624, 477);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panelButtons);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "QueryBuilderPropertiesForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Query Builder Properties";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.QueryBuilderPropertiesForm_Paint);
			this.panelButtons.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown9)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.panelHeader.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panelButtons;
		private System.Windows.Forms.Button buttonOk;
		private System.Windows.Forms.Button buttonCancel;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.NumericUpDown numericUpDown6;
		private System.Windows.Forms.CheckBox checkBox27;
		private System.Windows.Forms.CheckBox checkBox28;
		private System.Windows.Forms.CheckBox checkBox29;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.NumericUpDown numericUpDown7;
		private System.Windows.Forms.CheckBox checkBox30;
		private System.Windows.Forms.CheckBox checkBox31;
		private System.Windows.Forms.CheckBox checkBox32;
		private System.Windows.Forms.CheckBox checkBox33;
		private System.Windows.Forms.CheckBox checkBox34;
		private System.Windows.Forms.NumericUpDown numericUpDown8;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.NumericUpDown numericUpDown9;
		private System.Windows.Forms.CheckBox checkBox35;
		private System.Windows.Forms.CheckBox checkBox36;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panelPages;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Panel panelHeader;
		private System.Windows.Forms.Label labelHeader;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label labelNonVisual;
		private System.Windows.Forms.LinkLabel linkSqlSyntax;
		private System.Windows.Forms.LinkLabel linkOfflineMode;
		private System.Windows.Forms.Label labelVisual;
		private System.Windows.Forms.LinkLabel linkPanesVisibility;
		private System.Windows.Forms.LinkLabel linkMetadataTree;
		private System.Windows.Forms.LinkLabel linkMiscellaneous;
		private System.Windows.Forms.Label labelSqlBuilder;
		private System.Windows.Forms.LinkLabel linkGeneral;
		private System.Windows.Forms.LinkLabel linkMainQuery;
		private System.Windows.Forms.LinkLabel linkDerievedQueries;
		private System.Windows.Forms.LinkLabel linkExpressionSubqueries;
		private System.Windows.Forms.Button buttonApply;
	}
}
