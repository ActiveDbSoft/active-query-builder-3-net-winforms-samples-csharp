namespace FullFeaturedMdiDemo.Reports
{
    partial class StimulsoftForm
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
            this.stiViewerControl1 = new Stimulsoft.Report.Viewer.StiViewerControl();
            this.buttonDesigner = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // stiViewerControl1
            // 
            this.stiViewerControl1.AllowDrop = true;
            this.stiViewerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stiViewerControl1.Location = new System.Drawing.Point(0, 0);
            this.stiViewerControl1.Name = "stiViewerControl1";
            this.stiViewerControl1.Report = null;
            this.stiViewerControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.stiViewerControl1.ShowZoom = true;
            this.stiViewerControl1.Size = new System.Drawing.Size(799, 409);
            this.stiViewerControl1.TabIndex = 0;
            // 
            // buttonDesigner
            // 
            this.buttonDesigner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDesigner.AutoSize = true;
            this.buttonDesigner.Location = new System.Drawing.Point(644, 415);
            this.buttonDesigner.Name = "buttonDesigner";
            this.buttonDesigner.Size = new System.Drawing.Size(144, 23);
            this.buttonDesigner.TabIndex = 1;
            this.buttonDesigner.Text = "Open designer";
            this.buttonDesigner.UseVisualStyleBackColor = true;
            this.buttonDesigner.Click += new System.EventHandler(this.buttonDesigner_Click);
            // 
            // StimulsoftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDesigner);
            this.Controls.Add(this.stiViewerControl1);
            this.Name = "StimulsoftForm";
            this.Text = "StimulsoftForm";
            this.Load += new System.EventHandler(this.StimulsoftForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Stimulsoft.Report.Viewer.StiViewerControl stiViewerControl1;
        private System.Windows.Forms.Button buttonDesigner;
    }
}