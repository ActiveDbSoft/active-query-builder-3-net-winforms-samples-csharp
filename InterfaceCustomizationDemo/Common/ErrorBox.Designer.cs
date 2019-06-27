namespace InterfaceCustomizationDemo.Common
{
    partial class ErrorBox
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelMessage = new GrowLabel();
            this.panelCheckSyntax = new System.Windows.Forms.Panel();
            this.comboBoxSyntaxProvider = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelGoTo = new System.Windows.Forms.LinkLabel();
            this.linkLabelRevert = new System.Windows.Forms.LinkLabel();
            this.panelCheckSyntax.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMessage
            // 
            this.labelMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelMessage.Location = new System.Drawing.Point(5, 5);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(344, 13);
            this.labelMessage.TabIndex = 0;
            this.labelMessage.Tag = "";
            this.labelMessage.Text = "Some Text";
            // 
            // panelCheckSyntax
            // 
            this.panelCheckSyntax.AutoSize = true;
            this.panelCheckSyntax.Controls.Add(this.comboBoxSyntaxProvider);
            this.panelCheckSyntax.Controls.Add(this.label2);
            this.panelCheckSyntax.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCheckSyntax.Location = new System.Drawing.Point(5, 18);
            this.panelCheckSyntax.Margin = new System.Windows.Forms.Padding(0);
            this.panelCheckSyntax.Name = "panelCheckSyntax";
            this.panelCheckSyntax.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panelCheckSyntax.Size = new System.Drawing.Size(344, 26);
            this.panelCheckSyntax.TabIndex = 1;
            this.panelCheckSyntax.Visible = false;
            // 
            // comboBoxSyntaxProvider
            // 
            this.comboBoxSyntaxProvider.DisplayMember = "DisplayString";
            this.comboBoxSyntaxProvider.Dock = System.Windows.Forms.DockStyle.Top;
            this.comboBoxSyntaxProvider.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSyntaxProvider.FormattingEnabled = true;
            this.comboBoxSyntaxProvider.Location = new System.Drawing.Point(74, 5);
            this.comboBoxSyntaxProvider.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxSyntaxProvider.Name = "comboBoxSyntaxProvider";
            this.comboBoxSyntaxProvider.Size = new System.Drawing.Size(270, 21);
            this.comboBoxSyntaxProvider.TabIndex = 1;
            this.comboBoxSyntaxProvider.SelectedValueChanged += new System.EventHandler(this.comboBoxSyntaxProvider_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(0, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Check syntax:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // linkLabelGoTo
            // 
            this.linkLabelGoTo.AutoSize = true;
            this.linkLabelGoTo.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelGoTo.Location = new System.Drawing.Point(5, 44);
            this.linkLabelGoTo.Name = "linkLabelGoTo";
            this.linkLabelGoTo.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.linkLabelGoTo.Size = new System.Drawing.Size(114, 23);
            this.linkLabelGoTo.TabIndex = 2;
            this.linkLabelGoTo.TabStop = true;
            this.linkLabelGoTo.Text = "Go to the error position";
            this.linkLabelGoTo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelGoTo_LinkClicked);
            // 
            // linkLabelRevert
            // 
            this.linkLabelRevert.AutoSize = true;
            this.linkLabelRevert.Dock = System.Windows.Forms.DockStyle.Top;
            this.linkLabelRevert.Location = new System.Drawing.Point(5, 67);
            this.linkLabelRevert.Name = "linkLabelRevert";
            this.linkLabelRevert.Size = new System.Drawing.Size(198, 13);
            this.linkLabelRevert.TabIndex = 2;
            this.linkLabelRevert.TabStop = true;
            this.linkLabelRevert.Text = "Get back to the previous valid query text";
            this.linkLabelRevert.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelRevert_LinkClicked);
            // 
            // ErrorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.LightPink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.linkLabelRevert);
            this.Controls.Add(this.linkLabelGoTo);
            this.Controls.Add(this.panelCheckSyntax);
            this.Controls.Add(this.labelMessage);
            this.Name = "ErrorBox";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(354, 87);
            this.panelCheckSyntax.ResumeLayout(false);
            this.panelCheckSyntax.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GrowLabel labelMessage;
        private System.Windows.Forms.Panel panelCheckSyntax;
        private System.Windows.Forms.ComboBox comboBoxSyntaxProvider;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelGoTo;
        private System.Windows.Forms.LinkLabel linkLabelRevert;
    }
}
