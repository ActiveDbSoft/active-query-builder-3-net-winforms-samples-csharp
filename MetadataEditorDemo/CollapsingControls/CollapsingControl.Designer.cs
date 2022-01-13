namespace MetadataEditorDemo.CollapsingControls {
    partial class CollapsingControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;        

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.secondaryPanel = new System.Windows.Forms.Panel();
            this.primaryPanel = new System.Windows.Forms.Panel();
            this.dividerPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // animationTimer
            // 
            this.animationTimer.Interval = 50;
            this.animationTimer.Tick += new System.EventHandler(this.animationTimer_Tick);
            // 
            // secondaryPanel
            // 
            this.secondaryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.secondaryPanel.Location = new System.Drawing.Point(0, 94);
            this.secondaryPanel.Name = "secondaryPanel";
            this.secondaryPanel.Size = new System.Drawing.Size(409, 0);
            this.secondaryPanel.TabIndex = 2;
            // 
            // primaryPanel
            // 
            this.primaryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.primaryPanel.Location = new System.Drawing.Point(0, 0);
            this.primaryPanel.Name = "primaryPanel";
            this.primaryPanel.Size = new System.Drawing.Size(409, 47);
            this.primaryPanel.TabIndex = 0;
            // 
            // dividerPanel
            // 
            this.dividerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.dividerPanel.Location = new System.Drawing.Point(0, 47);
            this.dividerPanel.Name = "dividerPanel";
            this.dividerPanel.Size = new System.Drawing.Size(409, 47);
            this.dividerPanel.TabIndex = 1;
            // 
            // CollapsingControl
            // 
            this.Controls.Add(this.secondaryPanel);
            this.Controls.Add(this.dividerPanel);
            this.Controls.Add(this.primaryPanel);
            this.Name = "CollapsingControl";
            this.Size = new System.Drawing.Size(409, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer animationTimer;
        protected System.Windows.Forms.Panel secondaryPanel;
        protected System.Windows.Forms.Panel primaryPanel;
        private System.Windows.Forms.Panel dividerPanel;
    }
}
