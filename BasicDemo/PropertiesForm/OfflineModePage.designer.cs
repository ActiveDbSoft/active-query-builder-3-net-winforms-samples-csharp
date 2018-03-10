namespace BasicDemo
{
	partial class OfflineModePage
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
			this.bEditMetadata = new System.Windows.Forms.Button();
			this.bSaveToXML = new System.Windows.Forms.Button();
			this.bLoadFromXML = new System.Windows.Forms.Button();
			this.lMetadataObjectCount = new System.Windows.Forms.Label();
			this.bLoadMetadata = new System.Windows.Forms.Button();
			this.cbOfflineMode = new System.Windows.Forms.CheckBox();
			this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
			this.SaveDialog = new System.Windows.Forms.SaveFileDialog();
			this.SuspendLayout();
			//
			// bEditMetadata
			//
			this.bEditMetadata.Location = new System.Drawing.Point(3, 128);
			this.bEditMetadata.Name = "bEditMetadata";
			this.bEditMetadata.Size = new System.Drawing.Size(337, 23);
			this.bEditMetadata.TabIndex = 12;
			this.bEditMetadata.Text = "Edit Metadata Container...";
			this.bEditMetadata.UseVisualStyleBackColor = true;
			//
			// bSaveToXML
			//
			this.bSaveToXML.Location = new System.Drawing.Point(175, 99);
			this.bSaveToXML.Name = "bSaveToXML";
			this.bSaveToXML.Size = new System.Drawing.Size(165, 23);
			this.bSaveToXML.TabIndex = 13;
			this.bSaveToXML.Text = "Save to XML...";
			this.bSaveToXML.UseVisualStyleBackColor = true;
			//
			// bLoadFromXML
			//
			this.bLoadFromXML.Location = new System.Drawing.Point(3, 99);
			this.bLoadFromXML.Name = "bLoadFromXML";
			this.bLoadFromXML.Size = new System.Drawing.Size(166, 23);
			this.bLoadFromXML.TabIndex = 14;
			this.bLoadFromXML.Text = "Load from XML...";
			this.bLoadFromXML.UseVisualStyleBackColor = true;
			//
			// lMetadataObjectCount
			//
			this.lMetadataObjectCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lMetadataObjectCount.Location = new System.Drawing.Point(3, 56);
			this.lMetadataObjectCount.Name = "lMetadataObjectCount";
			this.lMetadataObjectCount.Size = new System.Drawing.Size(349, 40);
			this.lMetadataObjectCount.TabIndex = 11;
			this.lMetadataObjectCount.Text = "Loaded Metadata: {0} tables, {1} views, {2} procedures.";
			//
			// bLoadMetadata
			//
			this.bLoadMetadata.Location = new System.Drawing.Point(3, 26);
			this.bLoadMetadata.Name = "bLoadMetadata";
			this.bLoadMetadata.Size = new System.Drawing.Size(337, 23);
			this.bLoadMetadata.TabIndex = 10;
			this.bLoadMetadata.Text = "Load metadata to work in Offline mode...";
			this.bLoadMetadata.UseVisualStyleBackColor = true;
			//
			// cbOfflineMode
			//
			this.cbOfflineMode.Location = new System.Drawing.Point(3, 3);
			this.cbOfflineMode.Name = "cbOfflineMode";
			this.cbOfflineMode.Size = new System.Drawing.Size(394, 17);
			this.cbOfflineMode.TabIndex = 9;
			this.cbOfflineMode.Text = "Enable Offline Mode";
			this.cbOfflineMode.UseVisualStyleBackColor = true;
			//
			// OpenDialog
			//
			this.OpenDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			this.OpenDialog.Title = "Select XML file to load metadata from";
			//
			// SaveDialog
			//
			this.SaveDialog.Filter = "XML files (*.xml)|*.xml|All files (*.*)|*.*";
			this.SaveDialog.Title = "Select XML file to save metadata to";
			//
			// OfflineModePage
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.bEditMetadata);
			this.Controls.Add(this.bSaveToXML);
			this.Controls.Add(this.bLoadFromXML);
			this.Controls.Add(this.lMetadataObjectCount);
			this.Controls.Add(this.bLoadMetadata);
			this.Controls.Add(this.cbOfflineMode);
			this.Name = "OfflineModePage";
			this.Size = new System.Drawing.Size(355, 177);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bEditMetadata;
		private System.Windows.Forms.Button bSaveToXML;
		private System.Windows.Forms.Button bLoadFromXML;
		private System.Windows.Forms.Label lMetadataObjectCount;
		private System.Windows.Forms.Button bLoadMetadata;
		private System.Windows.Forms.CheckBox cbOfflineMode;
		private System.Windows.Forms.OpenFileDialog OpenDialog;
		private System.Windows.Forms.SaveFileDialog SaveDialog;
	}
}
