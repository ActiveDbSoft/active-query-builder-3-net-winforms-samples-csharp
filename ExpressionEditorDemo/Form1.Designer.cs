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
            this.ExpressionEditor = new ExpressionEditorDemo.View();
            this.SuspendLayout();
            // 
            // ExpressionEditor
            // 
            this.ExpressionEditor.AccessibleName = "ExpressionEditorForm";
            this.ExpressionEditor.ActiveUnionSubQuery = null;
            this.ExpressionEditor.Background = System.Drawing.SystemColors.Window;
            this.ExpressionEditor.CommentColor = System.Drawing.Color.Green;
            this.ExpressionEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExpressionEditor.Expression = "";
            this.ExpressionEditor.FunctionColor = System.Drawing.Color.Purple;
            this.ExpressionEditor.InactiveSelectionBackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ExpressionEditor.KeywordColor = System.Drawing.Color.Blue;
            this.ExpressionEditor.Location = new System.Drawing.Point(0, 0);
            this.ExpressionEditor.MinimumSize = new System.Drawing.Size(600, 400);
            this.ExpressionEditor.Name = "ExpressionEditor";
            this.ExpressionEditor.NumberColor = System.Drawing.Color.DarkCyan;
            this.ExpressionEditor.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.ExpressionEditor.SelectionTextColor = System.Drawing.SystemColors.HighlightText;
            this.ExpressionEditor.Size = new System.Drawing.Size(973, 492);
            this.ExpressionEditor.SQLFormattingOptions = null;
            this.ExpressionEditor.StringColor = System.Drawing.Color.DarkRed;
            this.ExpressionEditor.TabIndex = 0;
            this.ExpressionEditor.TextColor = System.Drawing.SystemColors.WindowText;
            this.ExpressionEditor.TextEditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 492);
            this.Controls.Add(this.ExpressionEditor);
            this.Name = "Form1";
            this.Text = "Expression Editor Demo";
            this.ResumeLayout(false);

        }

        #endregion

        private View ExpressionEditor;
    }
}

