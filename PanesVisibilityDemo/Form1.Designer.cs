using ActiveQueryBuilder.View.QueryView;

namespace PanesVisibilityDemo
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
            this.imageList16 = new System.Windows.Forms.ImageList(this.components);
            this.imageList32 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRightPane = new System.Windows.Forms.CheckBox();
            this.cbQueryColumnsPane = new System.Windows.Forms.CheckBox();
            this.cbDesignPane = new System.Windows.Forms.CheckBox();
            this.queryBuilder = new ActiveQueryBuilder.View.WinForms.QueryBuilder();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList16
            // 
            this.imageList16.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList16.ImageStream")));
            this.imageList16.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList16.Images.SetKeyName(0, "0.bmp");
            this.imageList16.Images.SetKeyName(1, "1.bmp");
            this.imageList16.Images.SetKeyName(2, "2.bmp");
            this.imageList16.Images.SetKeyName(3, "3.bmp");
            this.imageList16.Images.SetKeyName(4, "4.bmp");
            this.imageList16.Images.SetKeyName(5, "5.bmp");
            this.imageList16.Images.SetKeyName(6, "6.bmp");
            this.imageList16.Images.SetKeyName(7, "7.bmp");
            this.imageList16.Images.SetKeyName(8, "8.bmp");
            // 
            // imageList32
            // 
            this.imageList32.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList32.ImageStream")));
            this.imageList32.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList32.Images.SetKeyName(0, "0.bmp");
            this.imageList32.Images.SetKeyName(1, "1.bmp");
            this.imageList32.Images.SetKeyName(2, "2.bmp");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.cbRightPane);
            this.panel1.Controls.Add(this.cbQueryColumnsPane);
            this.panel1.Controls.Add(this.cbDesignPane);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(793, 108);
            this.panel1.TabIndex = 1;
            // 
            // cbRightPane
            // 
            this.cbRightPane.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbRightPane.Checked = true;
            this.cbRightPane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRightPane.Location = new System.Drawing.Point(492, 12);
            this.cbRightPane.Name = "cbRightPane";
            this.cbRightPane.Size = new System.Drawing.Size(112, 86);
            this.cbRightPane.TabIndex = 2;
            this.cbRightPane.Text = "Right Pane";
            this.cbRightPane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbRightPane.UseVisualStyleBackColor = true;
            this.cbRightPane.CheckedChanged += new System.EventHandler(this.cbRightPane_CheckedChanged);
            // 
            // cbQueryColumnsPane
            // 
            this.cbQueryColumnsPane.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbQueryColumnsPane.Checked = true;
            this.cbQueryColumnsPane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbQueryColumnsPane.Location = new System.Drawing.Point(320, 58);
            this.cbQueryColumnsPane.Name = "cbQueryColumnsPane";
            this.cbQueryColumnsPane.Size = new System.Drawing.Size(166, 40);
            this.cbQueryColumnsPane.TabIndex = 3;
            this.cbQueryColumnsPane.Text = "Query Columns Pane";
            this.cbQueryColumnsPane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbQueryColumnsPane.UseVisualStyleBackColor = true;
            this.cbQueryColumnsPane.CheckedChanged += new System.EventHandler(this.cbQueryColumnsPane_CheckedChanged);
            // 
            // cbDesignPane
            // 
            this.cbDesignPane.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbDesignPane.Checked = true;
            this.cbDesignPane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDesignPane.Location = new System.Drawing.Point(320, 12);
            this.cbDesignPane.Name = "cbDesignPane";
            this.cbDesignPane.Size = new System.Drawing.Size(166, 40);
            this.cbDesignPane.TabIndex = 1;
            this.cbDesignPane.Text = "Design Pane";
            this.cbDesignPane.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbDesignPane.UseVisualStyleBackColor = true;
            this.cbDesignPane.CheckedChanged += new System.EventHandler(this.cbDesignPane_CheckedChanged);
            // 
            // queryBuilder
            // 
            this.queryBuilder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.queryBuilder.DataSourceOptions.ColumnsOptions.MarkColumnOptions.PrimaryKeyIcon = ((System.Drawing.Bitmap)(resources.GetObject("resource.PrimaryKeyIcon")));
            this.queryBuilder.DesignPaneOptions.LinkStyle = ActiveQueryBuilder.View.QueryView.LinkStyle.MSAccess;
            this.queryBuilder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryBuilder.Location = new System.Drawing.Point(0, 108);
            this.queryBuilder.MetadataStructureOptions.ProceduresFolderText = null;
            this.queryBuilder.MetadataStructureOptions.SynonymsFolderText = null;
            this.queryBuilder.MetadataStructureOptions.TablesFolderText = null;
            this.queryBuilder.MetadataStructureOptions.ViewsFolderText = null;
            this.queryBuilder.Name = "queryBuilder";
            this.queryBuilder.QueryColumnListOptions.UseCustomExpressionBuilder = ((ActiveQueryBuilder.View.QueryView.AffectedColumns)((ActiveQueryBuilder.View.QueryView.AffectedColumns.ExpressionColumn | ActiveQueryBuilder.View.QueryView.AffectedColumns.ConditionColumns)));
            this.queryBuilder.Size = new System.Drawing.Size(793, 422);
            // 
            // 
            // 
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualFields = false;
            this.queryBuilder.SQLFormattingOptions.ExpandVirtualObjects = false;
            // 
            // 
            // 
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualFields = true;
            this.queryBuilder.SQLGenerationOptions.ExpandVirtualObjects = true;
            this.queryBuilder.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 530);
            this.Controls.Add(this.queryBuilder);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList16;
        private System.Windows.Forms.ImageList imageList32;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbDesignPane;
        private ActiveQueryBuilder.View.WinForms.QueryBuilder queryBuilder;
        private System.Windows.Forms.CheckBox cbQueryColumnsPane;
        private System.Windows.Forms.CheckBox cbRightPane;
    }
}

