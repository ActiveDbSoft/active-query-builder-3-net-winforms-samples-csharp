namespace MetadataEditorDemo.Common
{
	internal partial class MetadataFilterControl
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbInclude = new System.Windows.Forms.ListBox();
            this.toolbarInclude = new System.Windows.Forms.ToolStrip();
            this.tsbAddInclude = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteInclude = new System.Windows.Forms.ToolStripButton();
            this.tsbEditInclude = new System.Windows.Forms.ToolStripButton();
            this.lblInclude = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbExclude = new System.Windows.Forms.ListBox();
            this.toolbarExclude = new System.Windows.Forms.ToolStrip();
            this.tsbAddExclude = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteExclude = new System.Windows.Forms.ToolStripButton();
            this.tsbEditExclude = new System.Windows.Forms.ToolStripButton();
            this.lblExclude = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.toolbarInclude.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolbarExclude.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.lblInclude);
            this.splitContainer1.Panel1MinSize = 90;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.lblExclude);
            this.splitContainer1.Panel2MinSize = 90;
            this.splitContainer1.Size = new System.Drawing.Size(303, 187);
            this.splitContainer1.SplitterDistance = 90;
            this.splitContainer1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbInclude);
            this.panel2.Controls.Add(this.toolbarInclude);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 74);
            this.panel2.TabIndex = 21;
            // 
            // lbInclude
            // 
            this.lbInclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbInclude.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbInclude.FormattingEnabled = true;
            this.lbInclude.IntegralHeight = false;
            this.lbInclude.Location = new System.Drawing.Point(0, 0);
            this.lbInclude.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbInclude.Name = "lbInclude";
            this.lbInclude.Size = new System.Drawing.Size(277, 74);
            this.lbInclude.TabIndex = 2;
            this.lbInclude.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbInclude_DrawItem);
            this.lbInclude.DoubleClick += new System.EventHandler(this.lbInclude_DoubleClick);
            this.lbInclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbInclude_KeyDown);
            // 
            // toolbarInclude
            // 
            this.toolbarInclude.AutoSize = false;
            this.toolbarInclude.BackColor = System.Drawing.Color.Transparent;
            this.toolbarInclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolbarInclude.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarInclude.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddInclude,
            this.tsbDeleteInclude,
            this.tsbEditInclude});
            this.toolbarInclude.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolbarInclude.Location = new System.Drawing.Point(277, 0);
            this.toolbarInclude.Name = "toolbarInclude";
            this.toolbarInclude.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbarInclude.Size = new System.Drawing.Size(26, 74);
            this.toolbarInclude.TabIndex = 3;
            this.toolbarInclude.Text = "toolStrip1";
            // 
            // tsbAddInclude
            // 
            this.tsbAddInclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddInclude.Image = global::MetadataEditorDemo.Properties.Resources.add;
            this.tsbAddInclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddInclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddInclude.Name = "tsbAddInclude";
            this.tsbAddInclude.Size = new System.Drawing.Size(23, 20);
            this.tsbAddInclude.Text = "toolStripButton1";
            // 
            // tsbDeleteInclude
            // 
            this.tsbDeleteInclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteInclude.Image = global::MetadataEditorDemo.Properties.Resources.delete;
            this.tsbDeleteInclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteInclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteInclude.Name = "tsbDeleteInclude";
            this.tsbDeleteInclude.Size = new System.Drawing.Size(23, 20);
            this.tsbDeleteInclude.Text = "toolStripButton2";
            // 
            // tsbEditInclude
            // 
            this.tsbEditInclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditInclude.Image = global::MetadataEditorDemo.Properties.Resources.pencil;
            this.tsbEditInclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditInclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditInclude.Name = "tsbEditInclude";
            this.tsbEditInclude.Size = new System.Drawing.Size(23, 20);
            this.tsbEditInclude.Text = "toolStripButton5";
            // 
            // lblInclude
            // 
            this.lblInclude.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblInclude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInclude.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblInclude.Location = new System.Drawing.Point(0, 0);
            this.lblInclude.Name = "lblInclude";
            this.lblInclude.Size = new System.Drawing.Size(303, 16);
            this.lblInclude.TabIndex = 3;
            this.lblInclude.Text = "Include:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbExclude);
            this.panel1.Controls.Add(this.toolbarExclude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 77);
            this.panel1.TabIndex = 21;
            // 
            // lbExclude
            // 
            this.lbExclude.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbExclude.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbExclude.FormattingEnabled = true;
            this.lbExclude.IntegralHeight = false;
            this.lbExclude.Location = new System.Drawing.Point(0, 0);
            this.lbExclude.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lbExclude.Name = "lbExclude";
            this.lbExclude.Size = new System.Drawing.Size(277, 77);
            this.lbExclude.TabIndex = 3;
            this.lbExclude.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbExclude_DrawItem);
            this.lbExclude.DoubleClick += new System.EventHandler(this.lbExclude_DoubleClick);
            this.lbExclude.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbExclude_KeyDown);
            // 
            // toolbarExclude
            // 
            this.toolbarExclude.AutoSize = false;
            this.toolbarExclude.BackColor = System.Drawing.Color.Transparent;
            this.toolbarExclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolbarExclude.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbarExclude.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddExclude,
            this.tsbDeleteExclude,
            this.tsbEditExclude});
            this.toolbarExclude.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolbarExclude.Location = new System.Drawing.Point(277, 0);
            this.toolbarExclude.Name = "toolbarExclude";
            this.toolbarExclude.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolbarExclude.Size = new System.Drawing.Size(26, 77);
            this.toolbarExclude.TabIndex = 4;
            this.toolbarExclude.Text = "toolStrip1";
            // 
            // tsbAddExclude
            // 
            this.tsbAddExclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddExclude.Image = global::MetadataEditorDemo.Properties.Resources.add;
            this.tsbAddExclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddExclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddExclude.Name = "tsbAddExclude";
            this.tsbAddExclude.Size = new System.Drawing.Size(24, 20);
            this.tsbAddExclude.Text = "toolStripButton1";
            // 
            // tsbDeleteExclude
            // 
            this.tsbDeleteExclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteExclude.Image = global::MetadataEditorDemo.Properties.Resources.delete;
            this.tsbDeleteExclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteExclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteExclude.Name = "tsbDeleteExclude";
            this.tsbDeleteExclude.Size = new System.Drawing.Size(24, 20);
            this.tsbDeleteExclude.Text = "toolStripButton2";
            // 
            // tsbEditExclude
            // 
            this.tsbEditExclude.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditExclude.Image = global::MetadataEditorDemo.Properties.Resources.pencil;
            this.tsbEditExclude.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditExclude.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditExclude.Name = "tsbEditExclude";
            this.tsbEditExclude.Size = new System.Drawing.Size(24, 20);
            this.tsbEditExclude.Text = "toolStripButton4";
            // 
            // lblExclude
            // 
            this.lblExclude.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblExclude.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblExclude.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblExclude.Location = new System.Drawing.Point(0, 0);
            this.lblExclude.Name = "lblExclude";
            this.lblExclude.Size = new System.Drawing.Size(303, 16);
            this.lblExclude.TabIndex = 4;
            this.lblExclude.Text = "Exclude:";
            // 
            // MetadataFilterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "MetadataFilterControl";
            this.Size = new System.Drawing.Size(303, 187);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.toolbarInclude.ResumeLayout(false);
            this.toolbarInclude.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolbarExclude.ResumeLayout(false);
            this.toolbarExclude.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblInclude;
        private System.Windows.Forms.Label lblExclude;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbInclude;
        private System.Windows.Forms.ToolStrip toolbarInclude;
        private System.Windows.Forms.ToolStripButton tsbAddInclude;
        private System.Windows.Forms.ToolStripButton tsbDeleteInclude;
        private System.Windows.Forms.ToolStripButton tsbEditInclude;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbExclude;
        private System.Windows.Forms.ToolStrip toolbarExclude;
        private System.Windows.Forms.ToolStripButton tsbAddExclude;
        private System.Windows.Forms.ToolStripButton tsbDeleteExclude;
        private System.Windows.Forms.ToolStripButton tsbEditExclude;
    }
}
