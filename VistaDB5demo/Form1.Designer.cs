namespace VistaDB5demo
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
            this.vistaDb5MetadataProvider1 = new ActiveQueryBuilder.Core.VistaDB5MetadataProvider(this.components);
            this.vistaDbSyntaxProvider1 = new ActiveQueryBuilder.Core.VistaDBSyntaxProvider(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPageData = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connectMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.loadFromXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryStatisticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMetadataFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMetadataFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPageSQL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabPageData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageSQL);
            this.tabControl1.Controls.Add(this.tabPageData);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 506);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPageSQL
            // 
            this.tabPageSQL.Controls.Add(this.splitContainer1);
            this.tabPageSQL.Location = new System.Drawing.Point(4, 22);
            this.tabPageSQL.Name = "tabPageSQL";
            this.tabPageSQL.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSQL.Size = new System.Drawing.Size(785, 480);
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
            this.splitContainer1.Size = new System.Drawing.Size(779, 474);
            this.splitContainer1.SplitterDistance = 364;
            this.splitContainer1.TabIndex = 0;
            // 
            // queryBuilder1
            // 
            this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBuilder1.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Bitmap)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
            this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder1.MetadataProvider = this.vistaDb5MetadataProvider1;
            this.queryBuilder1.Name = "queryBuilder1";
            this.queryBuilder1.Size = new System.Drawing.Size(779, 364);
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
            this.queryBuilder1.SyntaxProvider = this.vistaDbSyntaxProvider1;
            this.queryBuilder1.TabIndex = 0;
            this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder1_SQLUpdated);
            // 
            // vistaDb5MetadataProvider1
            // 
            this.vistaDb5MetadataProvider1.Connection = null;
            // 
            // vistaDbSyntaxProvider1
            // 
            this.vistaDbSyntaxProvider1.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            this.vistaDbSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(779, 106);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
            // 
            // tabPageData
            // 
            this.tabPageData.Controls.Add(this.dataGridView1);
            this.tabPageData.Location = new System.Drawing.Point(4, 22);
            this.tabPageData.Name = "tabPageData";
            this.tabPageData.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageData.Size = new System.Drawing.Size(785, 480);
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
            this.dataGridView1.Size = new System.Drawing.Size(779, 474);
            this.dataGridView1.TabIndex = 0;
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectMetadataToolStripMenuItem,
            this.metadataToolStripMenuItem,
            this.queryStatisticsMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connectMetadataToolStripMenuItem
            // 
            this.connectMetadataToolStripMenuItem.Name = "connectMetadataToolStripMenuItem";
            this.connectMetadataToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.connectMetadataToolStripMenuItem.Text = "Connect...";
            this.connectMetadataToolStripMenuItem.Click += new System.EventHandler(this.connectMetadataToolStripMenuItem_Click);
            // 
            // metadataToolStripMenuItem
            // 
            this.metadataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshMetadataToolStripMenuItem,
            this.editMetadataToolStripMenuItem,
            this.clearMetadataToolStripMenuItem,
            this.toolStripSeparator1,
            this.loadFromXMLToolStripMenuItem,
            this.saveToXMLToolStripMenuItem});
            this.metadataToolStripMenuItem.Name = "metadataToolStripMenuItem";
            this.metadataToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.metadataToolStripMenuItem.Text = "Metadata";
            // 
            // refreshMetadataToolStripMenuItem
            // 
            this.refreshMetadataToolStripMenuItem.Name = "refreshMetadataToolStripMenuItem";
            this.refreshMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.refreshMetadataToolStripMenuItem.Text = "Refresh Metadata";
            this.refreshMetadataToolStripMenuItem.Click += new System.EventHandler(this.refreshMetadataToolStripMenuItem_Click);
            // 
            // editMetadataToolStripMenuItem
            // 
            this.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem";
            this.editMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.editMetadataToolStripMenuItem.Text = "Edit Metadata...";
            this.editMetadataToolStripMenuItem.Click += new System.EventHandler(this.editMetadataToolStripMenuItem_Click);
            // 
            // clearMetadataToolStripMenuItem
            // 
            this.clearMetadataToolStripMenuItem.Name = "clearMetadataToolStripMenuItem";
            this.clearMetadataToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.clearMetadataToolStripMenuItem.Text = "Clear Metadata";
            this.clearMetadataToolStripMenuItem.Click += new System.EventHandler(this.clearMetadataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(163, 6);
            // 
            // loadFromXMLToolStripMenuItem
            // 
            this.loadFromXMLToolStripMenuItem.Name = "loadFromXMLToolStripMenuItem";
            this.loadFromXMLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.loadFromXMLToolStripMenuItem.Text = "Load from XML...";
            this.loadFromXMLToolStripMenuItem.Click += new System.EventHandler(this.loadFromXMLToolStripMenuItem_Click);
            // 
            // saveToXMLToolStripMenuItem
            // 
            this.saveToXMLToolStripMenuItem.Name = "saveToXMLToolStripMenuItem";
            this.saveToXMLToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.saveToXMLToolStripMenuItem.Text = "Save to XML...";
            this.saveToXMLToolStripMenuItem.Click += new System.EventHandler(this.saveToXMLToolStripMenuItem_Click);
            // 
            // queryStatisticsMenuItem
            // 
            this.queryStatisticsMenuItem.Name = "queryStatisticsMenuItem";
            this.queryStatisticsMenuItem.Size = new System.Drawing.Size(109, 20);
            this.queryStatisticsMenuItem.Text = "Query Statistics...";
            this.queryStatisticsMenuItem.Click += new System.EventHandler(this.queryStatisticsMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // openMetadataFileDialog
            // 
            this.openMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // saveMetadataFileDialog
            // 
            this.saveMetadataFileDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList32.Images.SetKeyName(0, "0.bmp");
            this.imageList32.Images.SetKeyName(1, "1.bmp");
            this.imageList32.Images.SetKeyName(2, "2.bmp");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 530);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageSQL.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabPageData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem connectMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem metadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem refreshMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clearMetadataToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem saveToXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadFromXMLToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openMetadataFileDialog;
		private System.Windows.Forms.SaveFileDialog saveMetadataFileDialog;
		private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ImageList imageList32;
		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
		private ActiveQueryBuilder.Core.VistaDBSyntaxProvider vistaDbSyntaxProvider1;
		private ActiveQueryBuilder.Core.VistaDB5MetadataProvider vistaDb5MetadataProvider1;
		private System.Windows.Forms.ToolStripMenuItem queryStatisticsMenuItem;
	}
}

