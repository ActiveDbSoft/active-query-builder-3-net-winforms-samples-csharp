using ActiveQueryBuilder.Core;

namespace LoadMetadataAsync
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.msaccessSyntaxProvider = new MSAccessSyntaxProvider(this.components);
            this.SuspendLayout();
            // 
            // queryBuilder
            // 
            this.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Image)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder.Location = new System.Drawing.Point(0, 0);
            this.queryBuilder.MetadataStructureOptions.ProceduresFolderText = null;
            this.queryBuilder.MetadataStructureOptions.SynonymsFolderText = null;
            this.queryBuilder.MetadataStructureOptions.TablesFolderText = null;
            this.queryBuilder.MetadataStructureOptions.ViewsFolderText = null;
            this.queryBuilder.Name = "queryBuilder";
            this.queryBuilder.Size = new System.Drawing.Size(726, 509);
            this.queryBuilder.SyntaxProvider = this.msaccessSyntaxProvider;
            this.queryBuilder.TabIndex = 1;
            // 
            // msaccessSyntaxProvider
            // 
            this.msaccessSyntaxProvider.IdentCaseSens = ActiveQueryBuilder.Core.IdentCaseSensitivity.Insensitive;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 509);
            this.Controls.Add(this.queryBuilder);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
        private MSAccessSyntaxProvider msaccessSyntaxProvider;

    }
}

