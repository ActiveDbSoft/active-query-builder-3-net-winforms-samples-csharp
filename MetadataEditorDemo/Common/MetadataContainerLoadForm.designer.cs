namespace MetadataEditorDemo.Common
{
	partial class MetadataContainerLoadForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.bBack = new System.Windows.Forms.Button();
            this.bNext = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            // 
            // panelBottom
            // 
            this.panelBottom.AutoSize = true;
            this.panelBottom.Controls.Add(this.bBack);
            this.panelBottom.Controls.Add(this.bNext);
            this.panelBottom.Controls.Add(this.bCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 701);
            this.panelBottom.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(1158, 82);
            this.panelBottom.TabIndex = 0;
            // 
            // bBack
            // 
            this.bBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bBack.AutoSize = true;
            this.bBack.Enabled = false;
            this.bBack.Location = new System.Drawing.Point(588, 24);
            this.bBack.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(176, 35);
            this.bBack.TabIndex = 2;
            this.bBack.Text = "< &Back";
            this.bBack.UseVisualStyleBackColor = true;
            // 
            // bNext
            // 
            this.bNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bNext.AutoSize = true;
            this.bNext.Location = new System.Drawing.Point(776, 24);
            this.bNext.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bNext.Name = "bNext";
            this.bNext.Size = new System.Drawing.Size(168, 35);
            this.bNext.TabIndex = 1;
            this.bNext.Text = "&Next >";
            this.bNext.UseVisualStyleBackColor = true;
            // 
            // bCancel
            // 
            this.bCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCancel.AutoSize = true;
            this.bCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bCancel.Location = new System.Drawing.Point(956, 24);
            this.bCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(178, 35);
            this.bCancel.TabIndex = 0;
            this.bCancel.Text = "&Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // MetadataContainerLoadForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bCancel;
            this.ClientSize = new System.Drawing.Size(1158, 783);
            this.Controls.Add(this.panelBottom);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MinimumSize = new System.Drawing.Size(634, 688);
            this.Name = "MetadataContainerLoadForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load Metadata Wizard";
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.Panel panelBottom;
		private System.Windows.Forms.Button bBack;
		private System.Windows.Forms.Button bNext;
		private System.Windows.Forms.Button bCancel;
	}
}
