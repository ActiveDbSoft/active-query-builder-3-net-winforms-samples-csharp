namespace QueryStructureDemo
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
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pnlSampleQueries = new System.Windows.Forms.Panel();
            this.btnSampleUnions = new System.Windows.Forms.Button();
            this.btnSampleSelectFromJoinSubqueries = new System.Windows.Forms.Button();
            this.btnSampleSelectFromJoin = new System.Windows.Forms.Button();
            this.btnSampleSelectFromWhere = new System.Windows.Forms.Button();
            this.lblSampleQueries = new System.Windows.Forms.Label();
            this.btnSampleSelect = new System.Windows.Forms.Button();
            this.pageMisc = new System.Windows.Forms.TabControl();
            this.pageSQL = new System.Windows.Forms.TabPage();
            this.tbSQL = new System.Windows.Forms.TextBox();
            this.pageStatistics = new System.Windows.Forms.TabPage();
            this.tbStatistics = new System.Windows.Forms.TextBox();
            this.pageSubQueries = new System.Windows.Forms.TabPage();
            this.tbSubQueries = new System.Windows.Forms.TextBox();
            this.pageSubQueryStructure = new System.Windows.Forms.TabPage();
            this.tbSubQueryStructure = new System.Windows.Forms.TextBox();
            this.pageUnionSubQuery = new System.Windows.Forms.TabPage();
            this.tabctrlSubQueryStructureTabsheet = new System.Windows.Forms.TabControl();
            this.pageSelectedExpressions = new System.Windows.Forms.TabPage();
            this.tbSelectedExpressions = new System.Windows.Forms.TextBox();
            this.pageDataSources = new System.Windows.Forms.TabPage();
            this.tbDataSources = new System.Windows.Forms.TextBox();
            this.pageLinks = new System.Windows.Forms.TabPage();
            this.tbLinks = new System.Windows.Forms.TextBox();
            this.pageWhere = new System.Windows.Forms.TabPage();
            this.tbWhere = new System.Windows.Forms.TextBox();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.lblShowUnlinkedDatasourcesLegend = new System.Windows.Forms.Label();
            this.btnShowUnlinkedDatasourcesButton = new System.Windows.Forms.Button();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlSampleQueries.SuspendLayout();
            this.pageMisc.SuspendLayout();
            this.pageSQL.SuspendLayout();
            this.pageStatistics.SuspendLayout();
            this.pageSubQueries.SuspendLayout();
            this.pageSubQueryStructure.SuspendLayout();
            this.pageUnionSubQuery.SuspendLayout();
            this.tabctrlSubQueryStructureTabsheet.SuspendLayout();
            this.pageSelectedExpressions.SuspendLayout();
            this.pageDataSources.SuspendLayout();
            this.pageLinks.SuspendLayout();
            this.pageWhere.SuspendLayout();
            this.tabPage6.SuspendLayout();
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
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList32.Images.SetKeyName(0, "0.bmp");
            this.imageList32.Images.SetKeyName(1, "1.bmp");
            this.imageList32.Images.SetKeyName(2, "2.bmp");
            // 
            // queryBuilder
            // 
            this.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBuilder.DataSourceOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Bitmap)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder.Location = new System.Drawing.Point(0, 46);
            this.queryBuilder.Name = "queryBuilder";
            this.queryBuilder.QueryColumnListOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.queryBuilder.Size = new System.Drawing.Size(924, 381);
            // 
            // 
            // 
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            // 
            // 
            // 
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder.TabIndex = 0;
            this.queryBuilder.ActiveUnionSubQueryChanged += new System.EventHandler(this.queryBuilder_ActiveUnionSubQueryChanged);
            this.queryBuilder.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.queryBuilder);
            this.splitContainer1.Panel1.Controls.Add(this.pnlSampleQueries);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pageMisc);
            this.splitContainer1.Size = new System.Drawing.Size(924, 604);
            this.splitContainer1.SplitterDistance = 427;
            this.splitContainer1.TabIndex = 2;
            // 
            // pnlSampleQueries
            // 
            this.pnlSampleQueries.Controls.Add(this.btnSampleUnions);
            this.pnlSampleQueries.Controls.Add(this.btnSampleSelectFromJoinSubqueries);
            this.pnlSampleQueries.Controls.Add(this.btnSampleSelectFromJoin);
            this.pnlSampleQueries.Controls.Add(this.btnSampleSelectFromWhere);
            this.pnlSampleQueries.Controls.Add(this.lblSampleQueries);
            this.pnlSampleQueries.Controls.Add(this.btnSampleSelect);
            this.pnlSampleQueries.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSampleQueries.Location = new System.Drawing.Point(0, 0);
            this.pnlSampleQueries.Name = "pnlSampleQueries";
            this.pnlSampleQueries.Size = new System.Drawing.Size(924, 46);
            this.pnlSampleQueries.TabIndex = 1;
            // 
            // btnSampleUnions
            // 
            this.btnSampleUnions.Location = new System.Drawing.Point(675, 12);
            this.btnSampleUnions.Name = "btnSampleUnions";
            this.btnSampleUnions.Size = new System.Drawing.Size(106, 23);
            this.btnSampleUnions.TabIndex = 5;
            this.btnSampleUnions.Text = "Multiple UNIONs";
            this.btnSampleUnions.UseVisualStyleBackColor = true;
            this.btnSampleUnions.Click += new System.EventHandler(this.btnSampleUnions_Click);
            // 
            // btnSampleSelectFromJoinSubqueries
            // 
            this.btnSampleSelectFromJoinSubqueries.Location = new System.Drawing.Point(490, 12);
            this.btnSampleSelectFromJoinSubqueries.Name = "btnSampleSelectFromJoinSubqueries";
            this.btnSampleSelectFromJoinSubqueries.Size = new System.Drawing.Size(179, 23);
            this.btnSampleSelectFromJoinSubqueries.TabIndex = 4;
            this.btnSampleSelectFromJoinSubqueries.Text = "SELECT FROM with subqueries";
            this.btnSampleSelectFromJoinSubqueries.UseVisualStyleBackColor = true;
            this.btnSampleSelectFromJoinSubqueries.Click += new System.EventHandler(this.btnSampleSelectFromJoinSubqueries_Click);
            // 
            // btnSampleSelectFromJoin
            // 
            this.btnSampleSelectFromJoin.Location = new System.Drawing.Point(361, 12);
            this.btnSampleSelectFromJoin.Name = "btnSampleSelectFromJoin";
            this.btnSampleSelectFromJoin.Size = new System.Drawing.Size(123, 23);
            this.btnSampleSelectFromJoin.TabIndex = 3;
            this.btnSampleSelectFromJoin.Text = "SELECT FROM JOIN";
            this.btnSampleSelectFromJoin.UseVisualStyleBackColor = true;
            this.btnSampleSelectFromJoin.Click += new System.EventHandler(this.btnSampleSelectFromJoin_Click);
            // 
            // btnSampleSelectFromWhere
            // 
            this.btnSampleSelectFromWhere.Location = new System.Drawing.Point(206, 12);
            this.btnSampleSelectFromWhere.Name = "btnSampleSelectFromWhere";
            this.btnSampleSelectFromWhere.Size = new System.Drawing.Size(149, 23);
            this.btnSampleSelectFromWhere.TabIndex = 2;
            this.btnSampleSelectFromWhere.Text = "SELECT FROM WHERE";
            this.btnSampleSelectFromWhere.UseVisualStyleBackColor = true;
            this.btnSampleSelectFromWhere.Click += new System.EventHandler(this.btnSampleSelectFromWhere_Click);
            // 
            // lblSampleQueries
            // 
            this.lblSampleQueries.AutoSize = true;
            this.lblSampleQueries.Location = new System.Drawing.Point(12, 17);
            this.lblSampleQueries.Name = "lblSampleQueries";
            this.lblSampleQueries.Size = new System.Drawing.Size(107, 13);
            this.lblSampleQueries.TabIndex = 1;
            this.lblSampleQueries.Text = "Load sample queries:";
            // 
            // btnSampleSelect
            // 
            this.btnSampleSelect.Location = new System.Drawing.Point(125, 12);
            this.btnSampleSelect.Name = "btnSampleSelect";
            this.btnSampleSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSampleSelect.TabIndex = 0;
            this.btnSampleSelect.Text = "SELECT";
            this.btnSampleSelect.UseVisualStyleBackColor = true;
            this.btnSampleSelect.Click += new System.EventHandler(this.btnSampleSelect_Click);
            // 
            // pageMisc
            // 
            this.pageMisc.Controls.Add(this.pageSQL);
            this.pageMisc.Controls.Add(this.pageStatistics);
            this.pageMisc.Controls.Add(this.pageSubQueries);
            this.pageMisc.Controls.Add(this.pageSubQueryStructure);
            this.pageMisc.Controls.Add(this.pageUnionSubQuery);
            this.pageMisc.Controls.Add(this.tabPage6);
            this.pageMisc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pageMisc.Location = new System.Drawing.Point(0, 0);
            this.pageMisc.Name = "pageMisc";
            this.pageMisc.SelectedIndex = 0;
            this.pageMisc.Size = new System.Drawing.Size(924, 173);
            this.pageMisc.TabIndex = 0;
            // 
            // pageSQL
            // 
            this.pageSQL.Controls.Add(this.tbSQL);
            this.pageSQL.Location = new System.Drawing.Point(4, 22);
            this.pageSQL.Name = "pageSQL";
            this.pageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.pageSQL.Size = new System.Drawing.Size(916, 147);
            this.pageSQL.TabIndex = 0;
            this.pageSQL.Text = "SQL";
            this.pageSQL.UseVisualStyleBackColor = true;
            // 
            // tbSQL
            // 
            this.tbSQL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSQL.HideSelection = false;
            this.tbSQL.Location = new System.Drawing.Point(3, 3);
            this.tbSQL.Multiline = true;
            this.tbSQL.Name = "tbSQL";
            this.tbSQL.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSQL.Size = new System.Drawing.Size(910, 141);
            this.tbSQL.TabIndex = 1;
            this.tbSQL.Validating += new System.ComponentModel.CancelEventHandler(this.tbSQL_Validating);
            // 
            // pageStatistics
            // 
            this.pageStatistics.Controls.Add(this.tbStatistics);
            this.pageStatistics.Location = new System.Drawing.Point(4, 22);
            this.pageStatistics.Name = "pageStatistics";
            this.pageStatistics.Padding = new System.Windows.Forms.Padding(3);
            this.pageStatistics.Size = new System.Drawing.Size(916, 147);
            this.pageStatistics.TabIndex = 1;
            this.pageStatistics.Text = "Statistics";
            this.pageStatistics.UseVisualStyleBackColor = true;
            // 
            // tbStatistics
            // 
            this.tbStatistics.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbStatistics.HideSelection = false;
            this.tbStatistics.Location = new System.Drawing.Point(3, 3);
            this.tbStatistics.Multiline = true;
            this.tbStatistics.Name = "tbStatistics";
            this.tbStatistics.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbStatistics.Size = new System.Drawing.Size(910, 141);
            this.tbStatistics.TabIndex = 2;
            // 
            // pageSubQueries
            // 
            this.pageSubQueries.Controls.Add(this.tbSubQueries);
            this.pageSubQueries.Location = new System.Drawing.Point(4, 22);
            this.pageSubQueries.Name = "pageSubQueries";
            this.pageSubQueries.Padding = new System.Windows.Forms.Padding(3);
            this.pageSubQueries.Size = new System.Drawing.Size(916, 147);
            this.pageSubQueries.TabIndex = 2;
            this.pageSubQueries.Text = "SubQueries";
            this.pageSubQueries.UseVisualStyleBackColor = true;
            // 
            // tbSubQueries
            // 
            this.tbSubQueries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubQueries.HideSelection = false;
            this.tbSubQueries.Location = new System.Drawing.Point(3, 3);
            this.tbSubQueries.Multiline = true;
            this.tbSubQueries.Name = "tbSubQueries";
            this.tbSubQueries.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSubQueries.Size = new System.Drawing.Size(910, 141);
            this.tbSubQueries.TabIndex = 2;
            // 
            // pageSubQueryStructure
            // 
            this.pageSubQueryStructure.Controls.Add(this.tbSubQueryStructure);
            this.pageSubQueryStructure.Location = new System.Drawing.Point(4, 22);
            this.pageSubQueryStructure.Name = "pageSubQueryStructure";
            this.pageSubQueryStructure.Padding = new System.Windows.Forms.Padding(3);
            this.pageSubQueryStructure.Size = new System.Drawing.Size(916, 147);
            this.pageSubQueryStructure.TabIndex = 3;
            this.pageSubQueryStructure.Text = "SubQuery structure";
            this.pageSubQueryStructure.UseVisualStyleBackColor = true;
            // 
            // tbSubQueryStructure
            // 
            this.tbSubQueryStructure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSubQueryStructure.HideSelection = false;
            this.tbSubQueryStructure.Location = new System.Drawing.Point(3, 3);
            this.tbSubQueryStructure.Multiline = true;
            this.tbSubQueryStructure.Name = "tbSubQueryStructure";
            this.tbSubQueryStructure.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSubQueryStructure.Size = new System.Drawing.Size(910, 141);
            this.tbSubQueryStructure.TabIndex = 2;
            // 
            // pageUnionSubQuery
            // 
            this.pageUnionSubQuery.Controls.Add(this.tabctrlSubQueryStructureTabsheet);
            this.pageUnionSubQuery.Location = new System.Drawing.Point(4, 22);
            this.pageUnionSubQuery.Name = "pageUnionSubQuery";
            this.pageUnionSubQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pageUnionSubQuery.Size = new System.Drawing.Size(916, 147);
            this.pageUnionSubQuery.TabIndex = 4;
            this.pageUnionSubQuery.Text = "UnionSubQuery";
            this.pageUnionSubQuery.UseVisualStyleBackColor = true;
            // 
            // tabctrlSubQueryStructureTabsheet
            // 
            this.tabctrlSubQueryStructureTabsheet.Controls.Add(this.pageSelectedExpressions);
            this.tabctrlSubQueryStructureTabsheet.Controls.Add(this.pageDataSources);
            this.tabctrlSubQueryStructureTabsheet.Controls.Add(this.pageLinks);
            this.tabctrlSubQueryStructureTabsheet.Controls.Add(this.pageWhere);
            this.tabctrlSubQueryStructureTabsheet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabctrlSubQueryStructureTabsheet.Location = new System.Drawing.Point(3, 3);
            this.tabctrlSubQueryStructureTabsheet.Name = "tabctrlSubQueryStructureTabsheet";
            this.tabctrlSubQueryStructureTabsheet.SelectedIndex = 0;
            this.tabctrlSubQueryStructureTabsheet.Size = new System.Drawing.Size(910, 141);
            this.tabctrlSubQueryStructureTabsheet.TabIndex = 0;
            // 
            // pageSelectedExpressions
            // 
            this.pageSelectedExpressions.Controls.Add(this.tbSelectedExpressions);
            this.pageSelectedExpressions.Location = new System.Drawing.Point(4, 22);
            this.pageSelectedExpressions.Name = "pageSelectedExpressions";
            this.pageSelectedExpressions.Padding = new System.Windows.Forms.Padding(3);
            this.pageSelectedExpressions.Size = new System.Drawing.Size(902, 115);
            this.pageSelectedExpressions.TabIndex = 0;
            this.pageSelectedExpressions.Text = "Selected Expressions";
            this.pageSelectedExpressions.UseVisualStyleBackColor = true;
            // 
            // tbSelectedExpressions
            // 
            this.tbSelectedExpressions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbSelectedExpressions.HideSelection = false;
            this.tbSelectedExpressions.Location = new System.Drawing.Point(3, 3);
            this.tbSelectedExpressions.Multiline = true;
            this.tbSelectedExpressions.Name = "tbSelectedExpressions";
            this.tbSelectedExpressions.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbSelectedExpressions.Size = new System.Drawing.Size(896, 109);
            this.tbSelectedExpressions.TabIndex = 2;
            // 
            // pageDataSources
            // 
            this.pageDataSources.Controls.Add(this.tbDataSources);
            this.pageDataSources.Location = new System.Drawing.Point(4, 22);
            this.pageDataSources.Name = "pageDataSources";
            this.pageDataSources.Padding = new System.Windows.Forms.Padding(3);
            this.pageDataSources.Size = new System.Drawing.Size(902, 115);
            this.pageDataSources.TabIndex = 1;
            this.pageDataSources.Text = "DataSources";
            this.pageDataSources.UseVisualStyleBackColor = true;
            // 
            // tbDataSources
            // 
            this.tbDataSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbDataSources.HideSelection = false;
            this.tbDataSources.Location = new System.Drawing.Point(3, 3);
            this.tbDataSources.Multiline = true;
            this.tbDataSources.Name = "tbDataSources";
            this.tbDataSources.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbDataSources.Size = new System.Drawing.Size(896, 109);
            this.tbDataSources.TabIndex = 2;
            // 
            // pageLinks
            // 
            this.pageLinks.Controls.Add(this.tbLinks);
            this.pageLinks.Location = new System.Drawing.Point(4, 22);
            this.pageLinks.Name = "pageLinks";
            this.pageLinks.Padding = new System.Windows.Forms.Padding(3);
            this.pageLinks.Size = new System.Drawing.Size(902, 115);
            this.pageLinks.TabIndex = 2;
            this.pageLinks.Text = "Links";
            this.pageLinks.UseVisualStyleBackColor = true;
            // 
            // tbLinks
            // 
            this.tbLinks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLinks.HideSelection = false;
            this.tbLinks.Location = new System.Drawing.Point(3, 3);
            this.tbLinks.Multiline = true;
            this.tbLinks.Name = "tbLinks";
            this.tbLinks.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbLinks.Size = new System.Drawing.Size(896, 109);
            this.tbLinks.TabIndex = 2;
            // 
            // pageWhere
            // 
            this.pageWhere.Controls.Add(this.tbWhere);
            this.pageWhere.Location = new System.Drawing.Point(4, 22);
            this.pageWhere.Name = "pageWhere";
            this.pageWhere.Padding = new System.Windows.Forms.Padding(3);
            this.pageWhere.Size = new System.Drawing.Size(902, 115);
            this.pageWhere.TabIndex = 3;
            this.pageWhere.Text = "Where";
            this.pageWhere.UseVisualStyleBackColor = true;
            // 
            // tbWhere
            // 
            this.tbWhere.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbWhere.HideSelection = false;
            this.tbWhere.Location = new System.Drawing.Point(3, 3);
            this.tbWhere.Multiline = true;
            this.tbWhere.Name = "tbWhere";
            this.tbWhere.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbWhere.Size = new System.Drawing.Size(896, 109);
            this.tbWhere.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.lblShowUnlinkedDatasourcesLegend);
            this.tabPage6.Controls.Add(this.btnShowUnlinkedDatasourcesButton);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(916, 147);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Misc";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // lblShowUnlinkedDatasourcesLegend
            // 
            this.lblShowUnlinkedDatasourcesLegend.AutoSize = true;
            this.lblShowUnlinkedDatasourcesLegend.Location = new System.Drawing.Point(218, 15);
            this.lblShowUnlinkedDatasourcesLegend.Name = "lblShowUnlinkedDatasourcesLegend";
            this.lblShowUnlinkedDatasourcesLegend.Size = new System.Drawing.Size(355, 13);
            this.lblShowUnlinkedDatasourcesLegend.TabIndex = 1;
            this.lblShowUnlinkedDatasourcesLegend.Text = "List DataSources not reachable by links from first DataSource of the query";
            // 
            // btnShowUnlinkedDatasourcesButton
            // 
            this.btnShowUnlinkedDatasourcesButton.Location = new System.Drawing.Point(8, 10);
            this.btnShowUnlinkedDatasourcesButton.Name = "btnShowUnlinkedDatasourcesButton";
            this.btnShowUnlinkedDatasourcesButton.Size = new System.Drawing.Size(204, 23);
            this.btnShowUnlinkedDatasourcesButton.TabIndex = 0;
            this.btnShowUnlinkedDatasourcesButton.Text = "List unlinked DataSources";
            this.btnShowUnlinkedDatasourcesButton.UseVisualStyleBackColor = true;
            this.btnShowUnlinkedDatasourcesButton.Click += new System.EventHandler(this.btnShowUnlinkedDatasourcesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 604);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Query Structure Demo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.pnlSampleQueries.ResumeLayout(false);
            this.pnlSampleQueries.PerformLayout();
            this.pageMisc.ResumeLayout(false);
            this.pageSQL.ResumeLayout(false);
            this.pageSQL.PerformLayout();
            this.pageStatistics.ResumeLayout(false);
            this.pageStatistics.PerformLayout();
            this.pageSubQueries.ResumeLayout(false);
            this.pageSubQueries.PerformLayout();
            this.pageSubQueryStructure.ResumeLayout(false);
            this.pageSubQueryStructure.PerformLayout();
            this.pageUnionSubQuery.ResumeLayout(false);
            this.tabctrlSubQueryStructureTabsheet.ResumeLayout(false);
            this.pageSelectedExpressions.ResumeLayout(false);
            this.pageSelectedExpressions.PerformLayout();
            this.pageDataSources.ResumeLayout(false);
            this.pageDataSources.PerformLayout();
            this.pageLinks.ResumeLayout(false);
            this.pageLinks.PerformLayout();
            this.pageWhere.ResumeLayout(false);
            this.pageWhere.PerformLayout();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ImageList imageList16;
		private System.Windows.Forms.ImageList imageList32;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
		private System.Windows.Forms.TabControl pageMisc;
		private System.Windows.Forms.TabPage pageSQL;
		private System.Windows.Forms.TextBox tbSQL;
		private System.Windows.Forms.TabPage pageStatistics;
		private System.Windows.Forms.TextBox tbStatistics;
		private System.Windows.Forms.Panel pnlSampleQueries;
		private System.Windows.Forms.Button btnSampleSelectFromWhere;
		private System.Windows.Forms.Label lblSampleQueries;
		private System.Windows.Forms.Button btnSampleSelect;
		private System.Windows.Forms.Button btnSampleSelectFromJoinSubqueries;
		private System.Windows.Forms.Button btnSampleSelectFromJoin;
		private System.Windows.Forms.Button btnSampleUnions;
		private System.Windows.Forms.TabPage pageSubQueries;
		private System.Windows.Forms.TabPage pageSubQueryStructure;
		private System.Windows.Forms.TabPage pageUnionSubQuery;
		private System.Windows.Forms.TabPage tabPage6;
		private System.Windows.Forms.TextBox tbSubQueries;
		private System.Windows.Forms.TextBox tbSubQueryStructure;
		private System.Windows.Forms.TabControl tabctrlSubQueryStructureTabsheet;
		private System.Windows.Forms.TabPage pageSelectedExpressions;
		private System.Windows.Forms.TabPage pageDataSources;
		private System.Windows.Forms.TabPage pageLinks;
		private System.Windows.Forms.TabPage pageWhere;
		private System.Windows.Forms.TextBox tbSelectedExpressions;
		private System.Windows.Forms.TextBox tbDataSources;
		private System.Windows.Forms.TextBox tbLinks;
		private System.Windows.Forms.TextBox tbWhere;
		private System.Windows.Forms.Button btnShowUnlinkedDatasourcesButton;
		private System.Windows.Forms.Label lblShowUnlinkedDatasourcesLegend;
	}
}

