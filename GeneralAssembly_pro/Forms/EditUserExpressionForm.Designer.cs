namespace GeneralAssembly.Forms
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
            this.ListBoxConditions = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRevert = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.TextBoxCondition = new ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxCaption = new System.Windows.Forms.TextBox();
            this.CheckBoxIsNeedEdit = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInformSave = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckComboBoxDbTypes = new GeneralAssembly.Common.CheckComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListBoxConditions
            // 
            this.ListBoxConditions.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListBoxConditions.FormattingEnabled = true;
            this.ListBoxConditions.Location = new System.Drawing.Point(5, 5);
            this.ListBoxConditions.Name = "ListBoxConditions";
            this.ListBoxConditions.Size = new System.Drawing.Size(276, 423);
            this.ListBoxConditions.TabIndex = 2;
            this.ListBoxConditions.SelectedIndexChanged += new System.EventHandler(this.ListBoxExpressions_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxCondition, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TextBoxCaption, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.CheckBoxIsNeedEdit, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.CheckComboBoxDbTypes, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelInformSave, 1, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(312, 8);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(579, 218);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRevert);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(82, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(494, 23);
            this.panel1.TabIndex = 7;
            // 
            // buttonRevert
            // 
            this.buttonRevert.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRevert.Enabled = false;
            this.buttonRevert.Location = new System.Drawing.Point(98, 0);
            this.buttonRevert.Name = "buttonRevert";
            this.buttonRevert.Size = new System.Drawing.Size(101, 23);
            this.buttonRevert.TabIndex = 6;
            this.buttonRevert.Text = "Revert";
            this.buttonRevert.UseVisualStyleBackColor = true;
            this.buttonRevert.Click += new System.EventHandler(this.buttonRevert_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(0, 0);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(98, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.EnabledChanged += new System.EventHandler(this.buttonSave_EnabledChanged);
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TextBoxCondition
            // 
            this.TextBoxCondition.AllowShowSuggestionByMouse = false;
            this.TextBoxCondition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxCondition.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxCondition.Location = new System.Drawing.Point(82, 29);
            this.TextBoxCondition.Name = "TextBoxCondition";
            this.TextBoxCondition.Options.Padding = new System.Windows.Forms.Padding(5);
            this.TextBoxCondition.QueryProvider = null;
            this.TextBoxCondition.Size = new System.Drawing.Size(494, 80);
            this.TextBoxCondition.SQLContext = null;
            this.TextBoxCondition.TabIndex = 4;
            this.TextBoxCondition.TextChanged += new System.EventHandler(this.TextBoxExpression_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Caption";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBoxCaption
            // 
            this.TextBoxCaption.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxCaption.Location = new System.Drawing.Point(82, 3);
            this.TextBoxCaption.Name = "TextBoxCaption";
            this.TextBoxCaption.Size = new System.Drawing.Size(494, 20);
            this.TextBoxCaption.TabIndex = 1;
            this.TextBoxCaption.TextChanged += new System.EventHandler(this.TextBoxCaption_TextChanged);
            // 
            // CheckBoxIsNeedEdit
            // 
            this.CheckBoxIsNeedEdit.AutoSize = true;
            this.CheckBoxIsNeedEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxIsNeedEdit.Location = new System.Drawing.Point(82, 115);
            this.CheckBoxIsNeedEdit.Name = "CheckBoxIsNeedEdit";
            this.CheckBoxIsNeedEdit.Size = new System.Drawing.Size(494, 17);
            this.CheckBoxIsNeedEdit.TabIndex = 6;
            this.CheckBoxIsNeedEdit.Text = "Move focus to the newly added expression in the Query Columns grid for editing";
            this.CheckBoxIsNeedEdit.UseVisualStyleBackColor = true;
            this.CheckBoxIsNeedEdit.CheckedChanged += new System.EventHandler(this.CheckBoxIsNeedEdit_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apply to types";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Condition";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelInformSave
            // 
            this.labelInformSave.AutoSize = true;
            this.labelInformSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInformSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInformSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelInformSave.Location = new System.Drawing.Point(82, 194);
            this.labelInformSave.Margin = new System.Windows.Forms.Padding(3, 3, 3, 5);
            this.labelInformSave.Name = "labelInformSave";
            this.labelInformSave.Size = new System.Drawing.Size(494, 13);
            this.labelInformSave.TabIndex = 7;
            this.labelInformSave.Text = "Changes will not be saved unless you click the Save button.";
            this.labelInformSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInformSave.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Controls.Add(this.buttonAdd);
            this.flowLayoutPanel1.Controls.Add(this.buttonCopy);
            this.flowLayoutPanel1.Controls.Add(this.buttonDelete);
            this.flowLayoutPanel1.Controls.Add(this.buttonMoveUp);
            this.flowLayoutPanel1.Controls.Add(this.buttonMoveDown);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(281, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(28, 423);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonAdd.AutoSize = true;
            this.buttonAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonAdd.Image = global::GeneralAssembly.Properties.Resources.add;
            this.buttonAdd.Location = new System.Drawing.Point(3, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(22, 22);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCopy.AutoSize = true;
            this.buttonCopy.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCopy.Enabled = false;
            this.buttonCopy.Image = global::GeneralAssembly.Properties.Resources.copy;
            this.buttonCopy.Location = new System.Drawing.Point(3, 31);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(22, 22);
            this.buttonCopy.TabIndex = 1;
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Image = global::GeneralAssembly.Properties.Resources.delete;
            this.buttonDelete.Location = new System.Drawing.Point(3, 59);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(22, 22);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMoveUp.AutoSize = true;
            this.buttonMoveUp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMoveUp.Enabled = false;
            this.buttonMoveUp.Image = global::GeneralAssembly.Properties.Resources.arrowUp;
            this.buttonMoveUp.Location = new System.Drawing.Point(4, 87);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(20, 22);
            this.buttonMoveUp.TabIndex = 3;
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonMoveDown.AutoSize = true;
            this.buttonMoveDown.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonMoveDown.Enabled = false;
            this.buttonMoveDown.Image = global::GeneralAssembly.Properties.Resources.arrowDown;
            this.buttonMoveDown.Location = new System.Drawing.Point(4, 115);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(20, 22);
            this.buttonMoveDown.TabIndex = 4;
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(787, 402);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckComboBoxDbTypes
            // 
            this.CheckComboBoxDbTypes.Dock = System.Windows.Forms.DockStyle.Top;
            this.CheckComboBoxDbTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CheckComboBoxDbTypes.DropDownHeight = 1;
            this.CheckComboBoxDbTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CheckComboBoxDbTypes.DropDownWidth = 1;
            this.CheckComboBoxDbTypes.FormattingEnabled = true;
            this.CheckComboBoxDbTypes.IntegralHeight = false;
            this.CheckComboBoxDbTypes.Location = new System.Drawing.Point(82, 138);
            this.CheckComboBoxDbTypes.Name = "CheckComboBoxDbTypes";
            this.CheckComboBoxDbTypes.Size = new System.Drawing.Size(494, 21);
            this.CheckComboBoxDbTypes.TabIndex = 5;
            this.CheckComboBoxDbTypes.ItemChecked += new System.EventHandler(this.CheckComboBoxDbTypes_ItemChecked);
            // 
            // EditUserExpressionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 433);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ListBoxConditions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EditUserExpressionForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.Text = "Edit Predefined Conditions";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox ListBoxConditions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ActiveQueryBuilder.View.WinForms.ExpressionEditor.SqlTextEditor TextBoxCondition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxCaption;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBoxIsNeedEdit;
        private System.Windows.Forms.Label label4;
        private GeneralAssembly.Common.CheckComboBox CheckComboBoxDbTypes;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelInformSave;
        private System.Windows.Forms.Button buttonRevert;
        private System.Windows.Forms.Panel panel1;
    }
}