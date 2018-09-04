using ActiveQueryBuilder.View.WinForms;

namespace AlternateNames
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.editMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.imageList32 = new System.Windows.Forms.ImageList(this.components);
			this.queryBuilder1 = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
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
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editMetadataToolStripMenuItem,
            this.aboutToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
			this.menuStrip1.Size = new System.Drawing.Size(793, 24);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// editMetadataToolStripMenuItem
			// 
			this.editMetadataToolStripMenuItem.Name = "editMetadataToolStripMenuItem";
			this.editMetadataToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
			this.editMetadataToolStripMenuItem.Text = "Edit Metadata...";
			this.editMetadataToolStripMenuItem.Click += new System.EventHandler(this.editMetadataToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
			this.aboutToolStripMenuItem.Text = "About...";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// imageList32
			// 
			this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
			this.imageList32.TransparentColor = System.Drawing.Color.Magenta;
			this.imageList32.Images.SetKeyName(0, "0.bmp");
			this.imageList32.Images.SetKeyName(1, "1.bmp");
			this.imageList32.Images.SetKeyName(2, "2.bmp");
			// 
			// queryBuilder1
			// 
			this.queryBuilder1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.queryBuilder1.DataSourceOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.queryBuilder1.DataSourceOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Bitmap)(resources.GetObject("resource.PrimaryKeyIcon")));
			this.queryBuilder1.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
			this.queryBuilder1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.queryBuilder1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.queryBuilder1.Location = new System.Drawing.Point(0, 0);
			this.queryBuilder1.Name = "queryBuilder1";
			this.queryBuilder1.PanesConfigurationOptions.DatabaseSchemaViewWidth = 250;
			this.queryBuilder1.Size = new System.Drawing.Size(793, 358);
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
			this.queryBuilder1.TabIndex = 0;
			this.queryBuilder1.SQLUpdated += new System.EventHandler(this.queryBuilder_SQLUpdated);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.queryBuilder1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
			this.splitContainer1.Size = new System.Drawing.Size(793, 506);
			this.splitContainer1.SplitterDistance = 358;
			this.splitContainer1.TabIndex = 2;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(793, 144);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(785, 118);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Query text with alternate object names";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.HideSelection = false;
			this.textBox1.Location = new System.Drawing.Point(3, 3);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(779, 112);
			this.textBox1.TabIndex = 1;
			this.textBox1.Validating += new System.ComponentModel.CancelEventHandler(this.textBox1_Validating);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(785, 118);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Query text with real object names";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.textBox2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox2.HideSelection = false;
			this.textBox2.Location = new System.Drawing.Point(3, 3);
			this.textBox2.Multiline = true;
			this.textBox2.Name = "textBox2";
			this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox2.Size = new System.Drawing.Size(779, 112);
			this.textBox2.TabIndex = 2;
			this.textBox2.Validating += new System.ComponentModel.CancelEventHandler(this.textBox2_Validating);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(793, 530);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.menuStrip1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AlternateNames Demo";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ImageList imageList16;
		private System.Windows.Forms.ImageList imageList32;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.ToolStripMenuItem editMetadataToolStripMenuItem;
	}
}

