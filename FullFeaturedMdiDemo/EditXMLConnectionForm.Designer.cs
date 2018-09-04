using ActiveQueryBuilder.View.WinForms.QueryView;

namespace FullFeaturedMdiDemo
{
    partial class EditXMLConnectionForm
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSyntax = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbConnectionName = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openDialog = new System.Windows.Forms.OpenFileDialog();
            this.pbSyntax = new ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar();
            this.pnlFilePath = new System.Windows.Forms.Panel();
            this.btnOpenDialog = new System.Windows.Forms.Button();
            this.tbXmlPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.pnlFilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.cbSyntax);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Controls.Add(this.tbConnectionName);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(6);
            this.pnlTop.Size = new System.Drawing.Size(509, 68);
            this.pnlTop.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Syntax";
            // 
            // cbSyntax
            // 
            this.cbSyntax.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSyntax.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyntax.FormattingEnabled = true;
            this.cbSyntax.Location = new System.Drawing.Point(120, 36);
            this.cbSyntax.Name = "cbSyntax";
            this.cbSyntax.Size = new System.Drawing.Size(378, 21);
            this.cbSyntax.TabIndex = 4;
            this.cbSyntax.SelectedIndexChanged += new System.EventHandler(this.cbSyntax_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(9, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Connection Name";
            // 
            // tbConnectionName
            // 
            this.tbConnectionName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConnectionName.Location = new System.Drawing.Point(120, 9);
            this.tbConnectionName.Name = "tbConnectionName";
            this.tbConnectionName.Size = new System.Drawing.Size(378, 20);
            this.tbConnectionName.TabIndex = 0;
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.Location = new System.Drawing.Point(338, 169);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(78, 23);
            this.btnOk.TabIndex = 15;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(421, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // openDialog
            // 
            this.openDialog.Filter = "XML files|*xml|All files|*.*";
            // 
            // pbSyntax
            // 
            this.pbSyntax.AutoScroll = true;
            this.pbSyntax.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSyntax.InformationMessageHost = null;
            this.pbSyntax.Location = new System.Drawing.Point(0, 68);
            this.pbSyntax.Name = "pbSyntax";
            this.pbSyntax.Size = new System.Drawing.Size(509, 50);
            this.pbSyntax.TabIndex = 18;
            // 
            // pnlFilePath
            // 
            this.pnlFilePath.Controls.Add(this.btnOpenDialog);
            this.pnlFilePath.Controls.Add(this.tbXmlPath);
            this.pnlFilePath.Controls.Add(this.label4);
            this.pnlFilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilePath.Location = new System.Drawing.Point(0, 118);
            this.pnlFilePath.Name = "pnlFilePath";
            this.pnlFilePath.Size = new System.Drawing.Size(509, 30);
            this.pnlFilePath.TabIndex = 19;
            // 
            // btnOpenDialog
            // 
            this.btnOpenDialog.Location = new System.Drawing.Point(474, 5);
            this.btnOpenDialog.Name = "btnOpenDialog";
            this.btnOpenDialog.Size = new System.Drawing.Size(25, 22);
            this.btnOpenDialog.TabIndex = 17;
            this.btnOpenDialog.Text = "...";
            this.btnOpenDialog.UseVisualStyleBackColor = true;
            this.btnOpenDialog.Click += new System.EventHandler(this.btnOpenDialog_Click);
            // 
            // tbXmlPath
            // 
            this.tbXmlPath.Location = new System.Drawing.Point(121, 6);
            this.tbXmlPath.Name = "tbXmlPath";
            this.tbXmlPath.Size = new System.Drawing.Size(350, 20);
            this.tbXmlPath.TabIndex = 16;
            this.tbXmlPath.TextChanged += new System.EventHandler(this.tbXmlPath_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "XML file path:";
            // 
            // EditXMLConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 199);
            this.Controls.Add(this.pnlFilePath);
            this.Controls.Add(this.pbSyntax);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditXMLConnectionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit XML Connection";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlFilePath.ResumeLayout(false);
            this.pnlFilePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSyntax;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbConnectionName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.OpenFileDialog openDialog;
        private ActiveQueryBuilder.View.WinForms.QueryView.PropertiesBar pbSyntax;
        private System.Windows.Forms.Panel pnlFilePath;
        private System.Windows.Forms.Button btnOpenDialog;
        private System.Windows.Forms.TextBox tbXmlPath;
        private System.Windows.Forms.Label label4;
    }
}
