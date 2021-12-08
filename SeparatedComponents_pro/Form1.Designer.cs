using System.Drawing;
using System.Windows.Forms;

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
            ActiveQueryBuilder.Core.BehaviorOptions behaviorOptions1 = new ActiveQueryBuilder.Core.BehaviorOptions();
            ActiveQueryBuilder.Core.MetadataStructure metadataStructure1 = new ActiveQueryBuilder.Core.MetadataStructure();
            ActiveQueryBuilder.Core.MetadataFilter metadataFilter1 = new ActiveQueryBuilder.Core.MetadataFilter();
            ActiveQueryBuilder.Core.MetadataStructureOptions metadataStructureOptions1 = new ActiveQueryBuilder.Core.MetadataStructureOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess linkPainterAccess1 = new ActiveQueryBuilder.View.WinForms.QueryView.LinkPainterAccess();
            this.mssqlSyntaxProvider1 = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider(this.components);
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.mainMenu1 = new System.Windows.Forms.MenuStrip();
            this.menuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMetadataMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.loadMetadataFromXMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMetadataToXMLMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStatisticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.errorBox1 = new GeneralAssembly.Common.SqlErrorBox();
            this.mainMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlContext1.SQLGenerationOptionsForServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryView1.SQLGenerationOptions)).BeginInit();
            this.queryView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryColumnListControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSchemaView1)).BeginInit();
            this.SuspendLayout();
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.DetectServerVersion = true;
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
            this.mainMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem3,
            this.queryStatisticsMenuItem,
            this.aboutMenuItem});
            this.mainMenu1.Location = new System.Drawing.Point(5, 5);
            this.mainMenu1.Name = "mainMenu1";
            this.mainMenu1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenu1.Size = new System.Drawing.Size(1570, 24);
            this.mainMenu1.TabIndex = 0;
            // 
            // menuItem3
            // 
            this.menuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMetadataMenuItem,
            this.editMetadataMenuItem,
            this.clearMetadataMenuItem,
            this.menuItem4,
            this.loadMetadataFromXMLMenuItem,
            this.saveMetadataToXMLMenuItem});
            this.menuItem3.Name = "menuItem3";
            this.menuItem3.Size = new System.Drawing.Size(69, 20);
            this.menuItem3.Text = "Metadata";
            // 
            // refreshMetadataMenuItem
            // 
            this.refreshMetadataMenuItem.Name = "refreshMetadataMenuItem";
            this.refreshMetadataMenuItem.Size = new System.Drawing.Size(218, 22);
            this.refreshMetadataMenuItem.Text = "Refresh Metadata";
            this.refreshMetadataMenuItem.Click += new System.EventHandler(this.refreshMetadataMenuItem_Click);
            // 
            // editMetadataMenuItem
            // 
            this.editMetadataMenuItem.Name = "editMetadataMenuItem";
            this.editMetadataMenuItem.Size = new System.Drawing.Size(218, 22);
            this.editMetadataMenuItem.Text = "Edit Metadata...";
            this.editMetadataMenuItem.Click += new System.EventHandler(this.editMetadataMenuItem_Click);
            // 
            // clearMetadataMenuItem
            // 
            this.clearMetadataMenuItem.Name = "clearMetadataMenuItem";
            this.clearMetadataMenuItem.Size = new System.Drawing.Size(218, 22);
            this.clearMetadataMenuItem.Text = "Clear Metadata";
            this.clearMetadataMenuItem.Click += new System.EventHandler(this.clearMetadataMenuItem_Click);
            // 
            // menuItem4
            // 
            this.menuItem4.Name = "menuItem4";
            this.menuItem4.Size = new System.Drawing.Size(215, 6);
            // 
            // loadMetadataFromXMLMenuItem
            // 
            this.loadMetadataFromXMLMenuItem.Name = "loadMetadataFromXMLMenuItem";
            this.loadMetadataFromXMLMenuItem.Size = new System.Drawing.Size(218, 22);
            this.loadMetadataFromXMLMenuItem.Text = "Load Metadata from XML...";
            this.loadMetadataFromXMLMenuItem.Click += new System.EventHandler(this.loadMetadataFromXMLMenuItem_Click);
            // 
            // saveMetadataToXMLMenuItem
            // 
            this.saveMetadataToXMLMenuItem.Name = "saveMetadataToXMLMenuItem";
            this.saveMetadataToXMLMenuItem.Size = new System.Drawing.Size(218, 22);
            this.saveMetadataToXMLMenuItem.Text = "Save Metadata to XML...";
            this.saveMetadataToXMLMenuItem.Click += new System.EventHandler(this.saveMetadataToXMLMenuItem_Click);
            // 
            // queryStatisticsMenuItem
            // 
            this.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem";
            this.queryStatisticsMenuItem.Size = new System.Drawing.Size(109, 20);
            this.queryStatisticsMenuItem.Text = "Query Statistics...";
            this.queryStatisticsMenuItem.Click += new System.EventHandler(this.queryStatisticsMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutMenuItem.Text = "About...";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // sqlQuery1
            // 
            this.sqlQuery1.BehaviorOptions = behaviorOptions1;
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
            metadataStructure1.AllowChildAutoItems = false;
            metadataStructure1.Caption = null;
            metadataStructure1.ImageIndex = -1;
            metadataStructure1.IsDynamic = false;
            metadataStructure1.LoadDynamicNodes = true;
            metadataFilter1.OwnObjects = true;
            metadataStructure1.MetadataFilter = metadataFilter1;
            metadataStructure1.MetadataName = null;
            metadataStructureOptions1.AllowFavourites = false;
            metadataStructure1.Options = metadataStructureOptions1;
            metadataStructure1.Tag = null;
            metadataStructure1.XML = resources.GetString("metadataStructure1.XML");
            this.sqlContext1.UserQueriesStructure = metadataStructure1;
            // 
            // queryNavigationBar1
            // 
            this.queryNavigationBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryNavigationBar1.AutoSize = true;
            this.queryNavigationBar1.BackColor = System.Drawing.Color.Cornsilk;
            this.queryNavigationBar1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryNavigationBar1.Location = new System.Drawing.Point(290, 32);
            this.queryNavigationBar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.queryNavigationBar1.MinimumSize = new System.Drawing.Size(140, 34);
            this.queryNavigationBar1.Name = "queryNavigationBar1";
            this.queryNavigationBar1.Options.ActionButtonBackColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.ActionButtonBorderColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.ActiveSubQueryItemBackColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.ActiveSubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.AddCteCircleColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.AddUnionSubQueryCircleColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.BreadcrumbsBackgroundColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.CTEButtonBaseColor = System.Drawing.Color.Green;
            this.queryNavigationBar1.Options.DisableQueryNavigationBarPopup = false;
            this.queryNavigationBar1.Options.DragIndicatorColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.DragIndicatorHoverColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.ForeColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.GraphLineColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.GroupBackColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.GroupTextColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.OverflowButtonBaseColor = System.Drawing.Color.DarkRed;
            this.queryNavigationBar1.Options.RootQueryButtonBaseColor = System.Drawing.Color.Black;
            this.queryNavigationBar1.Options.SubQueryButtonBaseColor = System.Drawing.Color.Blue;
            this.queryNavigationBar1.Options.SubQueryItemBackColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.SubQueryItemBorderColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.SubQueryMarkerColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.SubQueryPopupBackColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Options.TextHoverColor = System.Drawing.Color.Empty;
            this.queryNavigationBar1.Padding = new System.Windows.Forms.Padding(9);
            this.queryNavigationBar1.Query = this.sqlQuery1;
            this.queryNavigationBar1.QueryView = this.queryView1;
            this.queryNavigationBar1.Size = new System.Drawing.Size(1281, 47);
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
            this.queryView1.Location = new System.Drawing.Point(290, 85);
            this.queryView1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.queryView1.Name = "queryView1";
            this.queryView1.Padding = new System.Windows.Forms.Padding(5);
            this.queryView1.Query = this.sqlQuery1;
            this.queryView1.Size = new System.Drawing.Size(1281, 482);
            // 
            // 
            // 
            this.queryView1.SQLGenerationOptions.ExpandVirtualFields = false;
            this.queryView1.SQLGenerationOptions.ExpandVirtualObjects = false;
            this.queryView1.TabIndex = 1;
            // 
            // addObjectDialog1
            // 
            this.addObjectDialog1.Options.Location = new System.Drawing.Point(0, 0);
            this.addObjectDialog1.Options.Size = new System.Drawing.Size(430, 430);
            this.addObjectDialog1.Options.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.addObjectDialog1.Options.StartWithDefaultNamespaceType = ActiveQueryBuilder.Core.MetadataType.Database;
            this.addObjectDialog1.Options.StartWithMetadataStructurePath = null;
            this.addObjectDialog1.QueryView = this.queryView1;
            // 
            // queryColumnListControl1
            // 
            this.queryColumnListControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryColumnListControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryColumnListControl1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.queryColumnListControl1.Location = new System.Drawing.Point(8, 338);
            this.queryColumnListControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.queryColumnListControl1.Name = "queryColumnListControl1";
            this.queryColumnListControl1.Options.Font = null;
            this.queryColumnListControl1.Options.InitialOrColumnsCount = 2;
            this.queryColumnListControl1.Options.NullOrderingInOrderBy = false;
            this.queryColumnListControl1.Options.UseCustomExpressionBuilder = ActiveQueryBuilder.View.QueryView.AffectedColumns.None;
            this.queryColumnListControl1.SelectedItems = new int[0];
            this.queryColumnListControl1.Size = new System.Drawing.Size(1262, 134);
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
            this.designPaneControl1.DataSourceOptions.ColumnsOptions.InformationButtonsColumnOptions.Color = System.Drawing.Color.Black;
            this.designPaneControl1.Location = new System.Drawing.Point(8, 8);
            this.designPaneControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.designPaneControl1.Name = "designPaneControl1";
            this.designPaneControl1.Options.Background = System.Drawing.SystemColors.Window;
            linkPainterAccess1.LinkColor = System.Drawing.Color.Black;
            linkPainterAccess1.LinkColorFocused = System.Drawing.Color.Black;
            linkPainterAccess1.MarkColor = System.Drawing.SystemColors.Control;
            linkPainterAccess1.MarkColorFocused = System.Drawing.SystemColors.ControlDark;
            linkPainterAccess1.MarkStyle = ActiveQueryBuilder.View.QueryView.LinkMarkStyle.Access;
            this.designPaneControl1.Options.LinkPainterOptions = linkPainterAccess1;
            this.designPaneControl1.Options.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.designPaneControl1.Size = new System.Drawing.Size(1262, 323);
            this.designPaneControl1.TabIndex = 0;
            // 
            // expressionEditor1
            // 
            this.expressionEditor1.SQLFormattingOptions = null;
            // 
            // sqlTextEditor1
            // 
            this.sqlTextEditor1.AllowShowSuggestionByMouse = false;
            this.sqlTextEditor1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sqlTextEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sqlTextEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqlTextEditor1.ForeColor = System.Drawing.Color.White;
            this.sqlTextEditor1.Location = new System.Drawing.Point(8, 575);
            this.sqlTextEditor1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.sqlTextEditor1.Name = "sqlTextEditor1";
            this.sqlTextEditor1.Options.Padding = new System.Windows.Forms.Padding(6, 3, 3, 3);
            this.sqlTextEditor1.QueryProvider = this.sqlQuery1;
            this.sqlTextEditor1.Size = new System.Drawing.Size(1563, 107);
            this.sqlTextEditor1.SQLContext = this.sqlContext1;
            this.sqlTextEditor1.SqlOptions.KeywordColor = System.Drawing.Color.LightSkyBlue;
            this.sqlTextEditor1.SqlOptions.SuggestionWindowSize = new System.Drawing.Size(200, 200);
            this.sqlTextEditor1.TabIndex = 2;
            this.sqlTextEditor1.Validating += new System.ComponentModel.CancelEventHandler(this.sqlTextEditor1_Validating);
            // 
            // databaseSchemaView1
            // 
            this.databaseSchemaView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.databaseSchemaView1.BackColor = System.Drawing.SystemColors.Window;
            this.databaseSchemaView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.databaseSchemaView1.Location = new System.Drawing.Point(8, 32);
            this.databaseSchemaView1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.databaseSchemaView1.Name = "databaseSchemaView1";
            this.databaseSchemaView1.Options.AllowDrop = true;
            this.databaseSchemaView1.Options.DrawTreeLines = false;
            this.databaseSchemaView1.Options.ImageIndices.FilterImageIndex = 14;
            this.databaseSchemaView1.Options.ImageList = null;
            this.databaseSchemaView1.QueryView = this.queryView1;
            this.databaseSchemaView1.SelectedItems = new ActiveQueryBuilder.Core.MetadataStructureItem[0];
            this.databaseSchemaView1.Size = new System.Drawing.Size(275, 535);
            this.databaseSchemaView1.SQLContext = this.sqlContext1;
            this.databaseSchemaView1.TabIndex = 0;
            // 
            // errorBox1
            // 
            this.errorBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.errorBox1.AutoSize = true;
            this.errorBox1.BackColor = System.Drawing.Color.LightPink;
            this.errorBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.errorBox1.CurrentSyntaxProvider = null;
            this.errorBox1.IsVisibleCheckSyntaxPanel = false;
            this.errorBox1.Location = new System.Drawing.Point(1195, 611);
            this.errorBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.errorBox1.Name = "errorBox1";
            this.errorBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.errorBox1.Size = new System.Drawing.Size(367, 71);
            this.errorBox1.TabIndex = 4;
            this.errorBox1.Visible = false;
            this.errorBox1.GoToErrorPosition += new System.EventHandler(this.ErrorBox1_GoToErrorPositionEvent);
            this.errorBox1.RevertValidText += new System.EventHandler(this.ErrorBox1_RevertValidTextEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1580, 690);
            this.Controls.Add(this.mainMenu1);
            this.Controls.Add(this.errorBox1);
            this.Controls.Add(this.queryNavigationBar1);
            this.Controls.Add(this.sqlTextEditor1);
            this.Controls.Add(this.queryView1);
            this.Controls.Add(this.databaseSchemaView1);
            this.MainMenuStrip = this.mainMenu1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.mainMenu1.ResumeLayout(false);
            this.mainMenu1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sqlContext1.SQLGenerationOptionsForServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryView1.SQLGenerationOptions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.queryView1)).EndInit();
            this.queryView1.ResumeLayout(false);
            this.queryView1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryColumnListControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseSchemaView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
		private System.Windows.Forms.MenuStrip mainMenu1;
		private System.Windows.Forms.ToolStripMenuItem menuItem3;
		private System.Windows.Forms.ToolStripMenuItem refreshMetadataMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMetadataMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearMetadataMenuItem;
		private System.Windows.Forms.ToolStripSeparator menuItem4;
		private System.Windows.Forms.ToolStripMenuItem loadMetadataFromXMLMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveMetadataToXMLMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem queryStatisticsMenuItem;
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
        private GeneralAssembly.Common.SqlErrorBox errorBox1;
    }
}

