namespace FullFeaturedMdiDemo.Common
{
    partial class CreateReportForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbActiveReport = new System.Windows.Forms.RadioButton();
            this.rbStimulsoft = new System.Windows.Forms.RadioButton();
            this.rbFastReport = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select one of the reporting:";
            // 
            // rbActiveReport
            // 
            this.rbActiveReport.AutoSize = true;
            this.rbActiveReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbActiveReport.Location = new System.Drawing.Point(10, 23);
            this.rbActiveReport.Name = "rbActiveReport";
            this.rbActiveReport.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.rbActiveReport.Size = new System.Drawing.Size(255, 27);
            this.rbActiveReport.TabIndex = 1;
            this.rbActiveReport.TabStop = true;
            this.rbActiveReport.Text = "Active Reports";
            this.rbActiveReport.UseVisualStyleBackColor = true;
            this.rbActiveReport.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbStimulsoft
            // 
            this.rbStimulsoft.AutoSize = true;
            this.rbStimulsoft.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbStimulsoft.Location = new System.Drawing.Point(10, 50);
            this.rbStimulsoft.Margin = new System.Windows.Forms.Padding(0);
            this.rbStimulsoft.Name = "rbStimulsoft";
            this.rbStimulsoft.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.rbStimulsoft.Size = new System.Drawing.Size(255, 22);
            this.rbStimulsoft.TabIndex = 1;
            this.rbStimulsoft.TabStop = true;
            this.rbStimulsoft.Text = "Stimulsoft Reports";
            this.rbStimulsoft.UseVisualStyleBackColor = true;
            this.rbStimulsoft.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbFastReport
            // 
            this.rbFastReport.AutoSize = true;
            this.rbFastReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.rbFastReport.Location = new System.Drawing.Point(10, 72);
            this.rbFastReport.Name = "rbFastReport";
            this.rbFastReport.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.rbFastReport.Size = new System.Drawing.Size(255, 32);
            this.rbFastReport.TabIndex = 1;
            this.rbFastReport.TabStop = true;
            this.rbFastReport.Text = "FastReport";
            this.rbFastReport.UseVisualStyleBackColor = true;
            this.rbFastReport.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(255, 26);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(130, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 20);
            this.button2.TabIndex = 0;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // CreateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 139);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.rbFastReport);
            this.Controls.Add(this.rbStimulsoft);
            this.Controls.Add(this.rbActiveReport);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateReportForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Type reports";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbActiveReport;
        private System.Windows.Forms.RadioButton rbStimulsoft;
        private System.Windows.Forms.RadioButton rbFastReport;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
