namespace MetadataEditorDemo.Common
{
    partial class MetadataFilterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MetadataFilterForm));
            this.filterControl = new MetadataFilterControl();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlInfo = new InformationPanel();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // filterControl
            // 
            this.filterControl.DatabaseList = ((System.Collections.Generic.List<string>)(resources.GetObject("filterControl.DatabaseList")));
            this.filterControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterControl.Location = new System.Drawing.Point(0, 7);
            this.filterControl.MetadataFilter = null;
            this.filterControl.Name = "filterControl";
            this.filterControl.Padding = new System.Windows.Forms.Padding(3);
            this.filterControl.SchemaList = ((System.Collections.Generic.List<string>)(resources.GetObject("filterControl.SchemaList")));
            this.filterControl.ShowDatabase = true;
            this.filterControl.ShowPackage = false;
            this.filterControl.ShowSchema = true;
            this.filterControl.ShowServer = false;
            this.filterControl.Size = new System.Drawing.Size(545, 300);
            this.filterControl.TabIndex = 0;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.btnCancel);
            this.pnlBottom.Controls.Add(this.btnOk);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 307);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(545, 36);
            this.pnlBottom.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(458, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(377, 6);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // pnlInfo
            // 
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInfo.IconLocation = ActiveQueryBuilder.View.InfoIconLocation.Left;
            this.pnlInfo.IconTooltip = "";
            this.pnlInfo.InfoText = "";
            this.pnlInfo.Location = new System.Drawing.Point(0, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.ShowIcon = true;
            this.pnlInfo.Size = new System.Drawing.Size(545, 7);
            this.pnlInfo.TabIndex = 2;
            this.pnlInfo.Tooltip = "";
            // 
            // MetadataFilterForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(545, 343);
            this.Controls.Add(this.filterControl);
            this.Controls.Add(this.pnlInfo);
            this.Controls.Add(this.pnlBottom);
            this.Name = "MetadataFilterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Advanced Metadata Filtration";
            this.pnlBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetadataFilterControl filterControl;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private InformationPanel pnlInfo;
    }
}