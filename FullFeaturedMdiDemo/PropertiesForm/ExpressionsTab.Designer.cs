namespace FullFeaturedMdiDemo.PropertiesForm
{
    partial class ExpressionsTab
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.UpDownIndentForNestedConditions = new System.Windows.Forms.NumericUpDown();
            this.radButEndLines = new System.Windows.Forms.RadioButton();
            this.radButStartLines = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.chBxStartAllLogicExprFromNewLines = new System.Windows.Forms.CheckBox();
            this.chBxUpperLvlLogicExprFromNewLines = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UpDownExprsIndent = new System.Windows.Forms.NumericUpDown();
            this.UpDownBranchKeyWrdsIndent = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chBxBranchResultExprsFromNewLines = new System.Windows.Forms.CheckBox();
            this.chBxResultKwrdsFromNewLinesThen = new System.Windows.Forms.CheckBox();
            this.chBxBranchConditionExprFromNewLines = new System.Windows.Forms.CheckBox();
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownIndentForNestedConditions)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownExprsIndent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBranchKeyWrdsIndent)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.UpDownIndentForNestedConditions);
            this.groupBox1.Controls.Add(this.radButEndLines);
            this.groupBox1.Controls.Add(this.radButStartLines);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chBxStartAllLogicExprFromNewLines);
            this.groupBox1.Controls.Add(this.chBxUpperLvlLogicExprFromNewLines);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(586, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Logical expressions";
            // 
            // UpDownIndentForNestedConditions
            // 
            this.UpDownIndentForNestedConditions.Location = new System.Drawing.Point(194, 97);
            this.UpDownIndentForNestedConditions.Name = "UpDownIndentForNestedConditions";
            this.UpDownIndentForNestedConditions.Size = new System.Drawing.Size(85, 20);
            this.UpDownIndentForNestedConditions.TabIndex = 7;
            this.UpDownIndentForNestedConditions.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpDownIndentForNestedConditions.ValueChanged += new System.EventHandler(this.UpDownIndentForNestedConditions_ValueChanged);
            // 
            // radButEndLines
            // 
            this.radButEndLines.AutoSize = true;
            this.radButEndLines.Checked = true;
            this.radButEndLines.Location = new System.Drawing.Point(241, 69);
            this.radButEndLines.Name = "radButEndLines";
            this.radButEndLines.Size = new System.Drawing.Size(67, 17);
            this.radButEndLines.TabIndex = 6;
            this.radButEndLines.TabStop = true;
            this.radButEndLines.Text = "end lines";
            this.radButEndLines.UseVisualStyleBackColor = true;
            this.radButEndLines.CheckedChanged += new System.EventHandler(this.radButEndLines_CheckedChanged);
            // 
            // radButStartLines
            // 
            this.radButStartLines.AutoSize = true;
            this.radButStartLines.Location = new System.Drawing.Point(131, 69);
            this.radButStartLines.Name = "radButStartLines";
            this.radButStartLines.Size = new System.Drawing.Size(69, 17);
            this.radButStartLines.TabIndex = 5;
            this.radButStartLines.TabStop = true;
            this.radButStartLines.Text = "start lines";
            this.radButStartLines.UseVisualStyleBackColor = true;
            this.radButStartLines.CheckedChanged += new System.EventHandler(this.radButStartLines_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Right;
            this.label3.Location = new System.Drawing.Point(388, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(195, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Layout of logical expressions in \r\nWHERE and HAVING clauses and join \r\nconditions" +
    " in the FROM part.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Indent for nested conditions:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Logical operators:";
            // 
            // chBxStartAllLogicExprFromNewLines
            // 
            this.chBxStartAllLogicExprFromNewLines.AutoSize = true;
            this.chBxStartAllLogicExprFromNewLines.Location = new System.Drawing.Point(6, 42);
            this.chBxStartAllLogicExprFromNewLines.Name = "chBxStartAllLogicExprFromNewLines";
            this.chBxStartAllLogicExprFromNewLines.Size = new System.Drawing.Size(222, 17);
            this.chBxStartAllLogicExprFromNewLines.TabIndex = 1;
            this.chBxStartAllLogicExprFromNewLines.Text = "Start all logical expressions from new lines";
            this.chBxStartAllLogicExprFromNewLines.UseVisualStyleBackColor = true;
            this.chBxStartAllLogicExprFromNewLines.CheckedChanged += new System.EventHandler(this.chBxStartAllLogicExprFromNewLines_CheckedChanged);
            // 
            // chBxUpperLvlLogicExprFromNewLines
            // 
            this.chBxUpperLvlLogicExprFromNewLines.AutoSize = true;
            this.chBxUpperLvlLogicExprFromNewLines.Checked = true;
            this.chBxUpperLvlLogicExprFromNewLines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chBxUpperLvlLogicExprFromNewLines.Location = new System.Drawing.Point(6, 19);
            this.chBxUpperLvlLogicExprFromNewLines.Name = "chBxUpperLvlLogicExprFromNewLines";
            this.chBxUpperLvlLogicExprFromNewLines.Size = new System.Drawing.Size(282, 17);
            this.chBxUpperLvlLogicExprFromNewLines.TabIndex = 0;
            this.chBxUpperLvlLogicExprFromNewLines.Text = "Start the upper-level logical expressions from new lines";
            this.chBxUpperLvlLogicExprFromNewLines.UseVisualStyleBackColor = true;
            this.chBxUpperLvlLogicExprFromNewLines.CheckedChanged += new System.EventHandler(this.chBxUpperLvlLogicExprFromNewLines_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.UpDownExprsIndent);
            this.groupBox2.Controls.Add(this.UpDownBranchKeyWrdsIndent);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chBxBranchResultExprsFromNewLines);
            this.groupBox2.Controls.Add(this.chBxResultKwrdsFromNewLinesThen);
            this.groupBox2.Controls.Add(this.chBxBranchConditionExprFromNewLines);
            this.groupBox2.Controls.Add(this.chBxBranchConditionKeyWrdsFromNewLinesWhen);
            this.groupBox2.Location = new System.Drawing.Point(3, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(583, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Conditional operators (IF, CASE)";
            // 
            // UpDownExprsIndent
            // 
            this.UpDownExprsIndent.Location = new System.Drawing.Point(156, 142);
            this.UpDownExprsIndent.Name = "UpDownExprsIndent";
            this.UpDownExprsIndent.Size = new System.Drawing.Size(87, 20);
            this.UpDownExprsIndent.TabIndex = 7;
            this.UpDownExprsIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpDownExprsIndent.ValueChanged += new System.EventHandler(this.UpDownExprsIndent_ValueChanged);
            // 
            // UpDownBranchKeyWrdsIndent
            // 
            this.UpDownBranchKeyWrdsIndent.Location = new System.Drawing.Point(156, 116);
            this.UpDownBranchKeyWrdsIndent.Name = "UpDownBranchKeyWrdsIndent";
            this.UpDownBranchKeyWrdsIndent.Size = new System.Drawing.Size(87, 20);
            this.UpDownBranchKeyWrdsIndent.TabIndex = 6;
            this.UpDownBranchKeyWrdsIndent.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpDownBranchKeyWrdsIndent.ValueChanged += new System.EventHandler(this.UpDownBranchKeyWrdsIndent_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Expressions indent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Branch Keywords Indent:";
            // 
            // chBxBranchResultExprsFromNewLines
            // 
            this.chBxBranchResultExprsFromNewLines.AutoSize = true;
            this.chBxBranchResultExprsFromNewLines.Location = new System.Drawing.Point(9, 88);
            this.chBxBranchResultExprsFromNewLines.Name = "chBxBranchResultExprsFromNewLines";
            this.chBxBranchResultExprsFromNewLines.Size = new System.Drawing.Size(216, 17);
            this.chBxBranchResultExprsFromNewLines.TabIndex = 3;
            this.chBxBranchResultExprsFromNewLines.Text = "Branch reslut expressions from new lines";
            this.chBxBranchResultExprsFromNewLines.UseVisualStyleBackColor = true;
            this.chBxBranchResultExprsFromNewLines.CheckedChanged += new System.EventHandler(this.chBxBranchResultExprsFromNewLines_CheckedChanged);
            // 
            // chBxResultKwrdsFromNewLinesThen
            // 
            this.chBxResultKwrdsFromNewLinesThen.AutoSize = true;
            this.chBxResultKwrdsFromNewLinesThen.Location = new System.Drawing.Point(9, 65);
            this.chBxResultKwrdsFromNewLinesThen.Name = "chBxResultKwrdsFromNewLinesThen";
            this.chBxResultKwrdsFromNewLinesThen.Size = new System.Drawing.Size(278, 17);
            this.chBxResultKwrdsFromNewLinesThen.TabIndex = 2;
            this.chBxResultKwrdsFromNewLinesThen.Text = "Branch result keywords from new lines (THEN, ELSE)";
            this.chBxResultKwrdsFromNewLinesThen.UseVisualStyleBackColor = true;
            this.chBxResultKwrdsFromNewLinesThen.CheckedChanged += new System.EventHandler(this.chBxResultKwrdsFromNewLinesThen_CheckedChanged);
            // 
            // chBxBranchConditionExprFromNewLines
            // 
            this.chBxBranchConditionExprFromNewLines.AutoSize = true;
            this.chBxBranchConditionExprFromNewLines.ForeColor = System.Drawing.Color.DarkOrchid;
            this.chBxBranchConditionExprFromNewLines.Location = new System.Drawing.Point(9, 42);
            this.chBxBranchConditionExprFromNewLines.Name = "chBxBranchConditionExprFromNewLines";
            this.chBxBranchConditionExprFromNewLines.Size = new System.Drawing.Size(234, 17);
            this.chBxBranchConditionExprFromNewLines.TabIndex = 1;
            this.chBxBranchConditionExprFromNewLines.Text = "Branch condition expressions from new lines";
            this.chBxBranchConditionExprFromNewLines.UseVisualStyleBackColor = true;
            this.chBxBranchConditionExprFromNewLines.CheckedChanged += new System.EventHandler(this.chBxBranchConditionExprFromNewLines_CheckedChanged);
            // 
            // chBxBranchConditionKeyWrdsFromNewLinesWhen
            // 
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.AutoSize = true;
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.Location = new System.Drawing.Point(9, 19);
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.Name = "chBxBranchConditionKeyWrdsFromNewLinesWhen";
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.Size = new System.Drawing.Size(267, 17);
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.TabIndex = 0;
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.Text = "Branch condition keywords from new lines (WHEN)";
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.UseVisualStyleBackColor = true;
            this.chBxBranchConditionKeyWrdsFromNewLinesWhen.CheckedChanged += new System.EventHandler(this.chBxBranchConditionKeyWrdsFromNewLinesWhen_CheckedChanged);
            // 
            // ExpressionsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ExpressionsTab";
            this.Size = new System.Drawing.Size(595, 324);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownIndentForNestedConditions)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownExprsIndent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBranchKeyWrdsIndent)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown UpDownIndentForNestedConditions;
        private System.Windows.Forms.RadioButton radButEndLines;
        private System.Windows.Forms.RadioButton radButStartLines;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chBxStartAllLogicExprFromNewLines;
        private System.Windows.Forms.CheckBox chBxUpperLvlLogicExprFromNewLines;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown UpDownExprsIndent;
        private System.Windows.Forms.NumericUpDown UpDownBranchKeyWrdsIndent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chBxBranchResultExprsFromNewLines;
        private System.Windows.Forms.CheckBox chBxResultKwrdsFromNewLinesThen;
        private System.Windows.Forms.CheckBox chBxBranchConditionExprFromNewLines;
        private System.Windows.Forms.CheckBox chBxBranchConditionKeyWrdsFromNewLinesWhen;
    }
}
