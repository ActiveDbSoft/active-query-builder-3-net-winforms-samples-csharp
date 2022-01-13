namespace FullFeaturedMdiDemo.Reports
{
    partial class FastReportForm
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
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonDesigner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.Location = new System.Drawing.Point(10, 10);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(197, 23);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "Show report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonDesigner
            // 
            this.buttonDesigner.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDesigner.Location = new System.Drawing.Point(10, 33);
            this.buttonDesigner.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDesigner.Name = "buttonDesigner";
            this.buttonDesigner.Size = new System.Drawing.Size(197, 23);
            this.buttonDesigner.TabIndex = 0;
            this.buttonDesigner.Text = "Show designer";
            this.buttonDesigner.UseVisualStyleBackColor = true;
            this.buttonDesigner.Click += new System.EventHandler(this.buttonDesigner_Click);
            // 
            // FastReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 63);
            this.Controls.Add(this.buttonDesigner);
            this.Controls.Add(this.buttonReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FastReportForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FastReport";
            this.Load += new System.EventHandler(this.FastReportForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonDesigner;
    }
}
