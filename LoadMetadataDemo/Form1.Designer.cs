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
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.openMetadataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMetadataFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.connectToMSSQLServerMenuItem = new System.Windows.Forms.MenuItem();
            this.connectToOracleServerMenuItem = new System.Windows.Forms.MenuItem();
            this.connectToAccessDatabaseMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.connectOleDbMenuItem = new System.Windows.Forms.MenuItem();
            this.connectODBCMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
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
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
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
            this.connectODBCMenuItem});
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
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 1;
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
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBuilder1.DatabaseSchemaViewOptions.ImageList = this.imageList16;
            this.queryBuilder1.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Bitmap)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.Size = new System.Drawing.Size(764, 346);
            // 
            // 
            // 
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder1.SQLFormattingOptions.ExpandVirtualObjects = false;
            // 
            // 
            // 
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder1.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder1.SyntaxProvider = this.genericSyntaxProvider1;
            this.queryBuilder1.TabIndex = 0;
            this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder1_SQLUpdated);
            // 
            // genericSyntaxProvider1
            // 
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 604);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
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
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem1;
		private System.Windows.Forms.MenuItem connectToMSSQLServerMenuItem;
		private System.Windows.Forms.MenuItem connectToOracleServerMenuItem;
		private System.Windows.Forms.MenuItem connectToAccessDatabaseMenuItem;
		private System.Windows.Forms.MenuItem menuItem2;
		private System.Windows.Forms.MenuItem connectOleDbMenuItem;
		private System.Windows.Forms.MenuItem connectODBCMenuItem;
		private System.Windows.Forms.MenuItem aboutMenuItem;
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
	}
}

