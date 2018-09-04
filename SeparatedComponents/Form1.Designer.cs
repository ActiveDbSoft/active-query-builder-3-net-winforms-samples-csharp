using System.Drawing;

namespace SeparatedComponents
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
            this.mssqlSyntaxProvider1 = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.refreshMetadataMenuItem = new System.Windows.Forms.MenuItem();
            this.editMetadataMenuItem = new System.Windows.Forms.MenuItem();
            this.clearMetadataMenuItem = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.loadMetadataFromXMLMenuItem = new System.Windows.Forms.MenuItem();
            this.saveMetadataToXMLMenuItem = new System.Windows.Forms.MenuItem();
            this.queryStatisticsMenuItem = new System.Windows.Forms.MenuItem();
            this.aboutMenuItem = new System.Windows.Forms.MenuItem();
            this.sqlQuery1 = new ActiveQueryBuilder.Core.SQLQuery(this.components);
            this.sqlContext1 = new ActiveQueryBuilder.Core.SQLContext(this.components);
            this.queryNavigationBar1 = new ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar();
            this.queryView1 = new ActiveQueryBuilder.View.WinForms.QueryView.QueryView();
            this.addObjectDialog1 = new ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog(this.components);
            this.queryColumnListControl1 = new ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl();
            this.designPaneControl1 = new ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl();
            this.expressionEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor(this.components);
            this.sqlTextEditor1 = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.databaseSchemaView1 = new ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView();
            ((System.ComponentModel.ISupportInitialize)(this.queryView1)).BeginInit();
            this.queryView1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.queryStatisticsMenuItem,
            this.aboutMenuItem});
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
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
            this.queryStatisticsMenuItem.Index = 1;
            this.queryStatisticsMenuItem.Text = "Query Statistics...";
            this.queryStatisticsMenuItem.Click += new System.EventHandler(this.queryStatisticsMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Index = 2;
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // sqlQuery1
            // 
            this.sqlQuery1.SQLContext = this.sqlContext1;
            this.sqlQuery1.SQLUpdated += new System.EventHandler(this.sqlQuery_SQLUpdated);
            // 
            // sqlContext1
            // 
            this.sqlContext1.MetadataProvider = null;
            // 
            // 
            // 
            this.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualFields = true;
            this.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualObjects = true;
            this.sqlContext1.SQLGenerationOptionsForServer.UseAltNames = false;
            this.sqlContext1.SyntaxProvider = this.mssqlSyntaxProvider1;
            // 
            // queryNavigationBar1
            // 
            this.queryNavigationBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryNavigationBar1.AutoSize = true;
            this.queryNavigationBar1.BackColor = System.Drawing.Color.Cornsilk;
            this.queryNavigationBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryNavigationBar1.Location = new System.Drawing.Point(249, 7);
            this.queryNavigationBar1.Name = "queryNavigationBar1";
            this.queryNavigationBar1.Query = this.sqlQuery1;
            this.queryNavigationBar1.QueryView = this.queryView1;
            this.queryNavigationBar1.Size = new System.Drawing.Size(1098, 41);
            this.queryNavigationBar1.TabIndex = 3;
            this.queryNavigationBar1.TabStop = false;
            // 
            // queryView1
            // 
            this.queryView1.AddObjectDialog = this.addObjectDialog1;
            this.queryView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryView1.BackColor = System.Drawing.Color.MistyRose;
            this.queryView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryView1.Controls.Add(this.queryColumnListControl1);
            this.queryView1.Controls.Add(this.designPaneControl1);
            this.queryView1.ExpressionEditor = this.expressionEditor1;
            this.queryView1.Location = new System.Drawing.Point(249, 52);
            this.queryView1.Name = "queryView1";
            this.queryView1.Padding = new System.Windows.Forms.Padding(4);
            this.queryView1.Query = this.sqlQuery1;
            this.queryView1.Size = new System.Drawing.Size(1098, 440);
            // 
            // 
            // 
            this.queryView1.SQLGenerationOptions.ExpandVirtualFields = false;
            this.queryView1.SQLGenerationOptions.ExpandVirtualObjects = false;
            this.queryView1.TabIndex = 1;
            // 
            // addObjectDialog1
            // 
            this.addObjectDialog1.QueryView = this.queryView1;
            // 
            // queryColumnListControl1
            // 
            this.queryColumnListControl1.AlternateRowColor = System.Drawing.SystemColors.Window;
            this.queryColumnListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryColumnListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryColumnListControl1.HideAsteriskItem = false;
            this.queryColumnListControl1.Location = new System.Drawing.Point(7, 315);
            this.queryColumnListControl1.Name = "queryColumnListControl1";
            this.queryColumnListControl1.Size = new System.Drawing.Size(1082, 116);
            this.queryColumnListControl1.TabIndex = 1;
            // 
            // designPaneControl1
            // 
            this.designPaneControl1.AllowDrop = true;
            this.designPaneControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.designPaneControl1.AutoScroll = true;
            this.designPaneControl1.AutoScrollMargin = new System.Drawing.Size(20, 20);
            this.designPaneControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.designPaneControl1.Location = new System.Drawing.Point(7, 7);
            this.designPaneControl1.Name = "designPaneControl1";
            this.designPaneControl1.Size = new System.Drawing.Size(1082, 302);
            this.designPaneControl1.TabIndex = 0;
            // 
            // expressionEditor1
            // 
            this.expressionEditor1.ActiveUnionSubQuery = null;
            this.expressionEditor1.CloseOnEscape = false;
            this.expressionEditor1.Expression = "";
            this.expressionEditor1.Height = 531;
            this.expressionEditor1.TextEditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expressionEditor1.Width = 754;
            // 
            // sqlTextEditor1
            // 
            this.sqlTextEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlTextEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqlTextEditor1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sqlTextEditor1.KeywordColor = System.Drawing.Color.LightSkyBlue;
            this.sqlTextEditor1.Location = new System.Drawing.Point(7, 498);
            this.sqlTextEditor1.Name = "sqlTextEditor1";
            this.sqlTextEditor1.Query = this.sqlQuery1;
            this.sqlTextEditor1.QueryProvider = this.sqlQuery1;
            this.sqlTextEditor1.Size = new System.Drawing.Size(1340, 93);
            this.sqlTextEditor1.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.sqlTextEditor1.TabIndex = 2;
            this.sqlTextEditor1.Text = "sqlTextEditor1";
            this.sqlTextEditor1.TextColor = System.Drawing.Color.White;
            this.sqlTextEditor1.TextPadding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.sqlTextEditor1.Validating += new System.ComponentModel.CancelEventHandler(this.sqlTextEditor1_Validating);
            // 
            // databaseSchemaView1
            // 
            this.databaseSchemaView1.AllowRenameNodes = false;
            this.databaseSchemaView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.databaseSchemaView1.BackColor = System.Drawing.Color.White;
            this.databaseSchemaView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseSchemaView1.FilterImageIndex = 14;
            this.databaseSchemaView1.Location = new System.Drawing.Point(7, 7);
            this.databaseSchemaView1.MaxToolTipWidth = 300;
            this.databaseSchemaView1.Name = "databaseSchemaView1";
            this.databaseSchemaView1.QueryView = this.queryView1;
            this.databaseSchemaView1.Size = new System.Drawing.Size(236, 485);
            this.databaseSchemaView1.SQLContext = this.sqlContext1;
            this.databaseSchemaView1.TabIndex = 0;
            this.databaseSchemaView1.ViewMode = ActiveQueryBuilder.View.DatabaseSchemaView.ViewMode.Tree;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 598);
            this.Controls.Add(this.queryNavigationBar1);
            this.Controls.Add(this.sqlTextEditor1);
            this.Controls.Add(this.queryView1);
            this.Controls.Add(this.databaseSchemaView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.queryView1)).EndInit();
            this.queryView1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
		private System.Windows.Forms.MainMenu mainMenu1;
		private System.Windows.Forms.MenuItem menuItem3;
		private System.Windows.Forms.MenuItem refreshMetadataMenuItem;
		private System.Windows.Forms.MenuItem editMetadataMenuItem;
		private System.Windows.Forms.MenuItem clearMetadataMenuItem;
		private System.Windows.Forms.MenuItem menuItem4;
		private System.Windows.Forms.MenuItem loadMetadataFromXMLMenuItem;
		private System.Windows.Forms.MenuItem saveMetadataToXMLMenuItem;
		private System.Windows.Forms.MenuItem aboutMenuItem;
		private System.Windows.Forms.MenuItem queryStatisticsMenuItem;
		private ActiveQueryBuilder.Core.SQLQuery sqlQuery1;
		private ActiveQueryBuilder.Core.SQLContext sqlContext1;
		private ActiveQueryBuilder.View.WinForms.DatabaseSchemaView.DatabaseSchemaView databaseSchemaView1;
		private ActiveQueryBuilder.View.WinForms.QueryView.QueryView queryView1;
		private ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor sqlTextEditor1;
		private ActiveQueryBuilder.View.WinForms.NavigationBar.QueryNavigationBar queryNavigationBar1;
		private ActiveQueryBuilder.View.WinForms.QueryView.QueryColumnListControl queryColumnListControl1;
		private ActiveQueryBuilder.View.WinForms.QueryView.DesignPaneControl designPaneControl1;
		private ActiveQueryBuilder.View.WinForms.QueryView.AddObjectDialog addObjectDialog1;
		private ActiveQueryBuilder.View.WinForms.ExpressionEditor.ExpressionEditor expressionEditor1;
	}
}

