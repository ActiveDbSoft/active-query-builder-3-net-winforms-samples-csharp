namespace GeneralAssembly.ConnectionFrames
{
	sealed partial class OLEDBConnectionFrame
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tbConnectionString = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnBuild = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbConnectionString
			// 
			this.tbConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tbConnectionString.Location = new System.Drawing.Point(3, 32);
			this.tbConnectionString.Multiline = true;
			this.tbConnectionString.Name = "tbConnectionString";
			this.tbConnectionString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbConnectionString.Size = new System.Drawing.Size(281, 164);
			this.tbConnectionString.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Margin = new System.Windows.Forms.Padding(3);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Enter Connection String:";
			// 
			// btnBuild
			// 
			this.btnBuild.Location = new System.Drawing.Point(197, 3);
			this.btnBuild.Name = "btnBuild";
			this.btnBuild.Size = new System.Drawing.Size(87, 23);
			this.btnBuild.TabIndex = 5;
			this.btnBuild.Text = "Build...";
			this.btnBuild.UseVisualStyleBackColor = true;
			this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
			// 
			// OLEDBConnectionFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnBuild);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbConnectionString);
			this.Name = "OLEDBConnectionFrame";
			this.Size = new System.Drawing.Size(287, 199);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbConnectionString;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnBuild;
	}
}
