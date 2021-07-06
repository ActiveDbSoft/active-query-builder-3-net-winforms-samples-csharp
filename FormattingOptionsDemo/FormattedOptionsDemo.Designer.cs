namespace FormattingOptionsDemo
{
    partial class FormattedOptionsDemo
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            ActiveQueryBuilder.Core.MetadataStructure metadataStructure2 = new ActiveQueryBuilder.Core.MetadataStructure();
            ActiveQueryBuilder.Core.MetadataFilter metadataFilter2 = new ActiveQueryBuilder.Core.MetadataFilter();
            ActiveQueryBuilder.Core.MetadataStructureOptions metadataStructureOptions2 = new ActiveQueryBuilder.Core.MetadataStructureOptions();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormattedOptionsDemo));
            this.sqlContext1 = new ActiveQueryBuilder.Core.SQLContext(this.components);
            this.mssqlSyntaxProvider1 = new ActiveQueryBuilder.Core.MSSQLSyntaxProvider(this.components);
            this.buttonSave = new System.Windows.Forms.Button();
            this.cmBxCurrentScheme = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.formattingOptions1 = new FormattingOptionsDemo.OptionsControls.FormattingOptions();
            this.SuspendLayout();
            // 
            // sqlContext1
            // 
            this.sqlContext1.MetadataProvider = null;
            // 
            // 
            // 
            this.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualFields = true;
            this.sqlContext1.SQLGenerationOptionsForServer.ExpandVirtualObjects = true;
            this.sqlContext1.SQLGenerationOptionsForServer.UseAltNames = false;
            this.sqlContext1.SyntaxProvider = this.mssqlSyntaxProvider1;
            metadataStructure2.AllowChildAutoItems = true;
            metadataStructure2.Caption = null;
            metadataStructure2.ImageIndex = -1;
            metadataStructure2.IsDynamic = false;
            metadataFilter2.OwnObjects = true;
            metadataStructure2.MetadataFilter = metadataFilter2;
            metadataStructure2.MetadataName = null;
            metadataStructureOptions2.ProceduresFolderText = "Procedures";
            metadataStructureOptions2.SynonymsFolderText = "Synonyms";
            metadataStructureOptions2.TablesFolderText = "Tables";
            metadataStructureOptions2.ViewsFolderText = "Views";
            metadataStructure2.Options = metadataStructureOptions2;
            metadataStructure2.XML = resources.GetString("metadataStructure2.XML");
            this.sqlContext1.UserQueriesStructure = metadataStructure2;
            // 
            // mssqlSyntaxProvider1
            // 
            this.mssqlSyntaxProvider1.OnCalcExpressionType = null;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(912, 6);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(127, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save options";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // cmBxCurrentScheme
            // 
            this.cmBxCurrentScheme.FormattingEnabled = true;
            this.cmBxCurrentScheme.Items.AddRange(new object[] {
            "Default"});
            this.cmBxCurrentScheme.Location = new System.Drawing.Point(726, 6);
            this.cmBxCurrentScheme.Name = "cmBxCurrentScheme";
            this.cmBxCurrentScheme.Size = new System.Drawing.Size(180, 21);
            this.cmBxCurrentScheme.TabIndex = 3;
            this.cmBxCurrentScheme.Text = "Default";
            this.cmBxCurrentScheme.SelectedIndexChanged += new System.EventHandler(this.cmBxCurrentScheme_SelectedIndexChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1045, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(127, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(671, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Scheme:";
            // 
            // formattingOptions1
            // 
            this.formattingOptions1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formattingOptions1.Location = new System.Drawing.Point(12, 35);
            this.formattingOptions1.Name = "formattingOptions1";
            this.formattingOptions1.Size = new System.Drawing.Size(1079, 676);
            this.formattingOptions1.SqlContext = this.sqlContext1;
            this.formattingOptions1.TabIndex = 7;
            // 
            // FormattedOptionsDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 746);
            this.Controls.Add(this.formattingOptions1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.cmBxCurrentScheme);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormattedOptionsDemo";
            this.Text = "FormattedOptions";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private ActiveQueryBuilder.Core.SQLContext sqlContext1;
        private ActiveQueryBuilder.Core.MSSQLSyntaxProvider mssqlSyntaxProvider1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ComboBox cmBxCurrentScheme;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label label1;
        private OptionsControls.FormattingOptions formattingOptions1;
    }
}

