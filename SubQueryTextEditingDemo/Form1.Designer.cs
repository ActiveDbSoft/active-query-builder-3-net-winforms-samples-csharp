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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageSQL = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.breadcrumbControl1 = new ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryBreadcrumbsBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mssqlMetadataProvider1 = new ActiveQueryBuilder.Core.MSSQLMetadataProvider(this.components);
            this.oledbMetadataProvider1 = new ActiveQueryBuilder.Core.OLEDBMetadataProvider(this.components);
            this.oracleMetadataProvider1 = new ActiveQueryBuilder.Core.OracleMetadataProvider(this.components);
            this.odbcMetadataProvider1 = new ActiveQueryBuilder.Core.ODBCMetadataProvider(this.components);
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.connectToMSSQLServerMenuItem = new System.Windows.Forms.MenuItem();
            this.connectToOracleServerMenuItem = new System.Windows.Forms.MenuItem();
            this.connectToAccessDatabaseMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.connectOleDbMenuItem = new System.Windows.Forms.MenuItem();
            this.connectODBCMenuItem = new System.Windows.Forms.MenuItem();
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
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.cmEditMode.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(884, 414);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.splitContainer1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(876, 388);
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Size = new System.Drawing.Size(870, 382);
            this.splitContainer1.SplitterDistance = 268;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.BehaviorOptions.ResolveColumnNamingConflictsAutomatically = false;
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.MetadataStructureOptions.ProceduresFolderText = "Procedures";
            this.queryBuilder1.MetadataStructureOptions.SynonymsFolderText = "Synonyms";
            this.queryBuilder1.MetadataStructureOptions.TablesFolderText = "Tables";
            this.queryBuilder1.MetadataStructureOptions.ViewsFolderText = "Views";
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.AutoHide = false;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Right;
            this.queryBuilder1.PanesConfigurationOptions.PropertiesBarEnabled = true;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.AutoHide = true;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarDockOptions.Position = ActiveQueryBuilder.View.SidePanelDockStyle.Left;
            this.queryBuilder1.PanesConfigurationOptions.SubQueryNavBarEnabled = true;
            this.queryBuilder1.Size = new System.Drawing.Size(870, 268);
            // 
            // 
            // 
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.FromClauseFormat.NewLineAfterDatasource = false;
            this.queryBuilder1.SQLFormattingOptions.ExpressionSubQueryFormat.MainPartsFromNewLine = false;
            // 
            // 
            // 
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder1.SQLGenerationOptions.UseAltNames = false;
            this.queryBuilder1.TabIndex = 0;
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
            this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(870, 84);
            this.textBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.breadcrumbControl1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 26);
            this.panel2.TabIndex = 1;
            // 
            // breadcrumbControl1
            // 
            this.breadcrumbControl1.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.breadcrumbControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.breadcrumbControl1.Location = new System.Drawing.Point(28, 0);
            this.breadcrumbControl1.Name = "breadcrumbControl1";
            this.breadcrumbControl1.QueryView = null;
            this.breadcrumbControl1.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.breadcrumbControl1.Size = new System.Drawing.Size(842, 26);
            this.breadcrumbControl1.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.breadcrumbControl1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(28, 26);
            this.panel3.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button1.Image = global::SubQueryTextEditingDemo.Properties.Resources.img;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(876, 388);
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
            this.dataGridView1.Size = new System.Drawing.Size(870, 382);
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
            // oracleMetadataProvider1
            // 
            this.oracleMetadataProvider1.Connection = null;
            // 
            // odbcMetadataProvider1
            // 
            this.odbcMetadataProvider1.Connection = null;
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
            this.connectToMSSQLServerMenuItem,
            this.connectToOracleServerMenuItem,
            this.connectToAccessDatabaseMenuItem,
            this.menuItem2,
            this.connectOleDbMenuItem,
            this.connectODBCMenuItem,
            this.fillProgrammaticallyMenuItem});
            this.menuItem1.Text = "Connect";
            // 
            // connectToMSSQLServerMenuItem
            // 
            this.connectToMSSQLServerMenuItem.Index = 0;
            this.connectToMSSQLServerMenuItem.Text = "Connect to Microsoft SQL Server";
            this.connectToMSSQLServerMenuItem.Click += new System.EventHandler(this.connectToMSSQLServerMenuItem_Click);
            // 
            // connectToOracleServerMenuItem
            // 
            this.connectToOracleServerMenuItem.Index = 1;
            this.connectToOracleServerMenuItem.Text = "Connect to Oracle Server";
            this.connectToOracleServerMenuItem.Click += new System.EventHandler(this.connectToOracleServerMenuItem_Click);
            // 
            // connectToAccessDatabaseMenuItem
            // 
            this.connectToAccessDatabaseMenuItem.Index = 2;
            this.connectToAccessDatabaseMenuItem.Text = "Connect to Microsoft Access database";
            this.connectToAccessDatabaseMenuItem.Click += new System.EventHandler(this.connectToAccessDatabaseMenuItem_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 3;
            this.menuItem2.Text = "-";
            // 
            // connectOleDbMenuItem
            // 
            this.connectOleDbMenuItem.Index = 4;
            this.connectOleDbMenuItem.Text = "Connect to database through OLE DB";
            this.connectOleDbMenuItem.Click += new System.EventHandler(this.connectOleDbMenuItem_Click);
            // 
            // connectODBCMenuItem
            // 
            this.connectODBCMenuItem.Index = 5;
            this.connectODBCMenuItem.Text = "Connect to database through ODBC";
            this.connectODBCMenuItem.Click += new System.EventHandler(this.connectODBCMenuItem_Click);
            // 
            // fillProgrammaticallyMenuItem
            // 
            this.fillProgrammaticallyMenuItem.Index = 6;
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
            // genericSyntaxProvider1
            // 
            this.genericSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.genericSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.OnCalcExpressionType = null;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 451);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private ActiveQueryBuilder.Core.GenericSyntaxProvider genericSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSSQLMetadataProvider mssqlMetadataProvider1;
		private ActiveQueryBuilder.Core.OLEDBMetadataProvider oledbMetadataProvider1;
		private ActiveQueryBuilder.Core.OracleMetadataProvider oracleMetadataProvider1;
		private ActiveQueryBuilder.Core.ODBCMetadataProvider odbcMetadataProvider1;
		private ActiveQueryBuilder.Core.OracleSyntaxProvider oracleSyntaxProvider1;
		private ActiveQueryBuilder.Core.MSAccessSyntaxProvider msaccessSyntaxProvider1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem connectToMSSQLServerMenuItem;
		private System.Windows.Forms.MenuItem connectToOracleServerMenuItem;
		private System.Windows.Forms.MenuItem connectToAccessDatabaseMenuItem;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem connectOleDbMenuItem;
		private System.Windows.Forms.MenuItem connectODBCMenuItem;
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
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private ActiveQueryBuilder.View.WinForms.NavigationBar.SubQueryBreadcrumbsBar breadcrumbControl1;
        private System.Windows.Forms.ContextMenuStrip cmEditMode;
        private System.Windows.Forms.ToolStripMenuItem tsmiEntire;
        private System.Windows.Forms.ToolStripMenuItem tsmiSubQuery;
        private System.Windows.Forms.ToolStripMenuItem tsmiExpression;
    }
}

