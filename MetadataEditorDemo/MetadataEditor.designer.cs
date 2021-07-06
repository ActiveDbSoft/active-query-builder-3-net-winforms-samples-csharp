using System.Windows.Forms;
using MetadataEditorDemo.Common;

namespace MetadataEditorDemo
{
    internal partial class MetadataEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLoadFromDatabase = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportContainer = new System.Windows.Forms.ToolStripMenuItem();
            this.structureToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiImportStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExportStructure = new System.Windows.Forms.ToolStripMenuItem();
            this.cbSyntaxProvider = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.metadataEditorControl = new MetadataEditorDemo.Common.MetadataEditorControl();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.containerToolStripMenuItem,
            this.structureToolStripMenuItem,
            this.cbSyntaxProvider,
            this.toolStripLabel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 27);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadFromDatabase,
            this.tsmiImportContainer,
            this.tsmiExportContainer});
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(71, 23);
            this.containerToolStripMenuItem.Text = "Container";
            // 
            // tsmiLoadFromDatabase
            // 
            this.tsmiLoadFromDatabase.Name = "tsmiLoadFromDatabase";
            this.tsmiLoadFromDatabase.Size = new System.Drawing.Size(180, 22);
            this.tsmiLoadFromDatabase.Text = "Load from database";
            // 
            // tsmiImportContainer
            // 
            this.tsmiImportContainer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiImportContainer.Name = "tsmiImportContainer";
            this.tsmiImportContainer.Size = new System.Drawing.Size(180, 22);
            this.tsmiImportContainer.Text = "Import from XML";
            // 
            // tsmiExportContainer
            // 
            this.tsmiExportContainer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiExportContainer.Name = "tsmiExportContainer";
            this.tsmiExportContainer.Size = new System.Drawing.Size(180, 22);
            this.tsmiExportContainer.Text = "Export to XML";
            // 
            // structureToolStripMenuItem
            // 
            this.structureToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiImportStructure,
            this.tsmiExportStructure});
            this.structureToolStripMenuItem.Name = "structureToolStripMenuItem";
            this.structureToolStripMenuItem.Size = new System.Drawing.Size(67, 23);
            this.structureToolStripMenuItem.Text = "Structure";
            // 
            // tsmiImportStructure
            // 
            this.tsmiImportStructure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiImportStructure.Name = "tsmiImportStructure";
            this.tsmiImportStructure.Size = new System.Drawing.Size(166, 22);
            this.tsmiImportStructure.Text = "Import from XML";
            // 
            // tsmiExportStructure
            // 
            this.tsmiExportStructure.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsmiExportStructure.Name = "tsmiExportStructure";
            this.tsmiExportStructure.Size = new System.Drawing.Size(166, 22);
            this.tsmiExportStructure.Text = "Export to XML";
            // 
            // cbSyntaxProvider
            // 
            this.cbSyntaxProvider.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.cbSyntaxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSyntaxProvider.Name = "cbSyntaxProvider";
            this.cbSyntaxProvider.Size = new System.Drawing.Size(160, 23);
            // 
            // toolStripLabel
            // 
            this.toolStripLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripLabel.Name = "toolStripLabel";
            this.toolStripLabel.Size = new System.Drawing.Size(92, 20);
            this.toolStripLabel.Text = "Syntax Provider:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPreview);
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.lblProgress);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 416);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 34);
            this.panel1.TabIndex = 19;
            // 
            // btnPreview
            // 
            this.btnPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPreview.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.Location = new System.Drawing.Point(864, 5);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 23);
            this.btnPreview.TabIndex = 27;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Image = global::MetadataEditorDemo.Properties.Resources.cancel;
            this.btnStop.Location = new System.Drawing.Point(258, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(24, 24);
            this.btnStop.TabIndex = 26;
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(6, 9);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(82, 13);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status message";
            this.lblStatus.Visible = false;
            // 
            // lblProgress
            // 
            this.lblProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblProgress.AutoSize = true;
            this.lblProgress.Location = new System.Drawing.Point(161, 9);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(91, 13);
            this.lblProgress.TabIndex = 24;
            this.lblProgress.Text = "Loading objects...";
            this.lblProgress.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.progressBar1.Location = new System.Drawing.Point(5, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(150, 21);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 23;
            this.progressBar1.Visible = false;
            // 
            // metadataEditorControl
            // 
            this.metadataEditorControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metadataEditorControl.HideVirtualObjects = false;
            this.metadataEditorControl.IsChanged = false;
            this.metadataEditorControl.Location = new System.Drawing.Point(0, 27);
            this.metadataEditorControl.MinimumSize = new System.Drawing.Size(100, 100);
            this.metadataEditorControl.Name = "metadataEditorControl";
            this.metadataEditorControl.OpenContainerLoadFormIfNotConnected = false;
            this.metadataEditorControl.Size = new System.Drawing.Size(967, 389);
            this.metadataEditorControl.StructureTreeVisible = true;
            this.metadataEditorControl.TabIndex = 17;
            // 
            // MetadataEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 450);
            this.Controls.Add(this.metadataEditorControl);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MetadataEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MetadataEditorStandalone";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetadataEditorControl metadataEditorControl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem containerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem structureToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadFromDatabase;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportContainer;
        private System.Windows.Forms.ToolStripMenuItem tsmiImportStructure;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportStructure;
        private System.Windows.Forms.ToolStripMenuItem tsmiExportContainer;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripComboBox cbSyntaxProvider;
        private System.Windows.Forms.ToolStripLabel toolStripLabel;
        private Button btnPreview;
    }
}