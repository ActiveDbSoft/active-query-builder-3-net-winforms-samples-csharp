namespace FullFeaturedDemo
{
    partial class EditUserExpressionForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TextBoxExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCaption = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckComboBoxDbTypes = new GeneralAssembly.Common.CheckComboBox();
            this.CheckBoxIsNeedEdit = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ButtonClearForm = new System.Windows.Forms.Button();
            this.ButtonAddExpression = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBoxExpressions = new System.Windows.Forms.ListBox();
            this.ButtonRemoveExpression = new System.Windows.Forms.Button();
            this.ButtonEditExpression = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.TextBoxExpression, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxCaption, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CheckComboBoxDbTypes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxIsNeedEdit, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(503, 133);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TextBoxExpression
            // 
            this.TextBoxExpression.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxExpression.Location = new System.Drawing.Point(80, 29);
            this.TextBoxExpression.Name = "TextBoxExpression";
            this.TextBoxExpression.Size = new System.Drawing.Size(420, 20);
            this.TextBoxExpression.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxCaption
            // 
            this.TextBoxCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxCaption.Location = new System.Drawing.Point(80, 3);
            this.TextBoxCaption.Name = "TextBoxCaption";
            this.TextBoxCaption.Size = new System.Drawing.Size(420, 20);
            this.TextBoxCaption.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Expression";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Show only for";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckComboBoxDbTypes
            // 
            this.CheckComboBoxDbTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckComboBoxDbTypes.DropDownHeight = 1;
            this.CheckComboBoxDbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckComboBoxDbTypes.DropDownWidth = 1;
            this.CheckComboBoxDbTypes.FormattingEnabled = true;
            this.CheckComboBoxDbTypes.IntegralHeight = false;
            this.CheckComboBoxDbTypes.Location = new System.Drawing.Point(80, 78);
            this.CheckComboBoxDbTypes.Name = "CheckComboBoxDbTypes";
            this.CheckComboBoxDbTypes.Size = new System.Drawing.Size(420, 21);
            this.CheckComboBoxDbTypes.TabIndex = 5;
            this.CheckComboBoxDbTypes.Text = null;
            // 
            // CheckBoxIsNeedEdit
            // 
            this.CheckBoxIsNeedEdit.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.CheckBoxIsNeedEdit, 2);
            this.CheckBoxIsNeedEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxIsNeedEdit.Location = new System.Drawing.Point(3, 55);
            this.CheckBoxIsNeedEdit.Name = "CheckBoxIsNeedEdit";
            this.CheckBoxIsNeedEdit.Size = new System.Drawing.Size(497, 17);
            this.CheckBoxIsNeedEdit.TabIndex = 6;
            this.CheckBoxIsNeedEdit.Text = "Is need edit cell after inserting";
            this.CheckBoxIsNeedEdit.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.ButtonClearForm);
            this.panel1.Controls.Add(this.ButtonAddExpression);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(77, 102);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 31);
            this.panel1.TabIndex = 7;
            // 
            // ButtonClearForm
            // 
            this.ButtonClearForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClearForm.Location = new System.Drawing.Point(267, 3);
            this.ButtonClearForm.Name = "ButtonClearForm";
            this.ButtonClearForm.Size = new System.Drawing.Size(75, 23);
            this.ButtonClearForm.TabIndex = 0;
            this.ButtonClearForm.Text = "Clear";
            this.ButtonClearForm.UseVisualStyleBackColor = true;
            this.ButtonClearForm.Click += new System.EventHandler(this.ButtonClearForm_Click);
            // 
            // ButtonAddExpression
            // 
            this.ButtonAddExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddExpression.Location = new System.Drawing.Point(348, 3);
            this.ButtonAddExpression.Name = "ButtonAddExpression";
            this.ButtonAddExpression.Size = new System.Drawing.Size(75, 23);
            this.ButtonAddExpression.TabIndex = 0;
            this.ButtonAddExpression.Text = "Add";
            this.ButtonAddExpression.UseVisualStyleBackColor = true;
            this.ButtonAddExpression.Click += new System.EventHandler(this.ButtonAddExpression_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 152);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // ListBoxExpressions
            // 
            this.ListBoxExpressions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBoxExpressions.FormattingEnabled = true;
            this.ListBoxExpressions.Location = new System.Drawing.Point(5, 163);
            this.ListBoxExpressions.Name = "ListBoxExpressions";
            this.ListBoxExpressions.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBoxExpressions.Size = new System.Drawing.Size(506, 290);
            this.ListBoxExpressions.TabIndex = 2;
            // 
            // ButtonRemoveExpression
            // 
            this.ButtonRemoveExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonRemoveExpression.Location = new System.Drawing.Point(332, 458);
            this.ButtonRemoveExpression.Name = "ButtonRemoveExpression";
            this.ButtonRemoveExpression.Size = new System.Drawing.Size(180, 23);
            this.ButtonRemoveExpression.TabIndex = 3;
            this.ButtonRemoveExpression.Text = "Remove selected expressions";
            this.ButtonRemoveExpression.UseVisualStyleBackColor = true;
            this.ButtonRemoveExpression.Click += new System.EventHandler(this.ButtonRemoveExpression_Click);
            // 
            // ButtonEditExpression
            // 
            this.ButtonEditExpression.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonEditExpression.Location = new System.Drawing.Point(146, 457);
            this.ButtonEditExpression.Name = "ButtonEditExpression";
            this.ButtonEditExpression.Size = new System.Drawing.Size(180, 23);
            this.ButtonEditExpression.TabIndex = 3;
            this.ButtonEditExpression.Text = "Edit selected expression";
            this.ButtonEditExpression.UseVisualStyleBackColor = true;
            this.ButtonEditExpression.Click += new System.EventHandler(this.ButtonEditExpression_Click);
            // 
            // EditUserExpressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 488);
            this.Controls.Add(this.ButtonEditExpression);
            this.Controls.Add(this.ButtonRemoveExpression);
            this.Controls.Add(this.ListBoxExpressions);
            this.Controls.Add(this.groupBox1);
            this.Name = "EditUserExpressionForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Text = "Edit User Expression";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TextBoxExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private GeneralAssembly.Common.CheckComboBox CheckComboBoxDbTypes;
        private System.Windows.Forms.CheckBox CheckBoxIsNeedEdit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ButtonClearForm;
        private System.Windows.Forms.Button ButtonAddExpression;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListBoxExpressions;
        private System.Windows.Forms.Button ButtonRemoveExpression;
        private System.Windows.Forms.Button ButtonEditExpression;
    }
}
