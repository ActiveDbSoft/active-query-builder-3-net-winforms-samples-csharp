using ExpressionEditorDemo.Common;

namespace ExpressionEditorDemo
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
            this.expressionEditorControl1 = new ExpressionEditorDemo.ExpressionEditorControl();
            this.SuspendLayout();
            // 
            // expressionEditorControl1
            // 
            this.expressionEditorControl1.ActiveUnionSubQuery = null;
            this.expressionEditorControl1.BackColor = System.Drawing.SystemColors.Control;
            this.expressionEditorControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expressionEditorControl1.Expression = "";
            this.expressionEditorControl1.Location = new System.Drawing.Point(0, 0);
            this.expressionEditorControl1.Name = "expressionEditorControl1";
            this.expressionEditorControl1.Options.DatabaseSchemaViewPanelPinned = true;
            this.expressionEditorControl1.Options.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.expressionEditorControl1.Size = new System.Drawing.Size(738, 492);
            this.expressionEditorControl1.SQLFormattingOptions = null;
            this.expressionEditorControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AccessibleName = "ExpressionEditorForm";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 492);
            this.Controls.Add(this.expressionEditorControl1);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expression Editor Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private ExpressionEditorControl expressionEditorControl1;
    }
}

