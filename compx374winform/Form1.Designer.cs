namespace compx374winform
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.folderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trainToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelWithLabelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recogniseContentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analyzeFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageModelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(673, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.folderToolStripMenuItem,
            this.formToolStripMenuItem});
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.selectToolStripMenuItem.Text = "Select";
            // 
            // folderToolStripMenuItem
            // 
            this.folderToolStripMenuItem.Name = "folderToolStripMenuItem";
            this.folderToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.folderToolStripMenuItem.Text = "Folder";
            this.folderToolStripMenuItem.Click += new System.EventHandler(this.FolderToolStripMenuItem_Click);
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.formToolStripMenuItem.Text = "Form";
            this.formToolStripMenuItem.Click += new System.EventHandler(this.FormToolStripMenuItem_Click);
            // 
            // trainToolStripMenuItem
            // 
            this.trainToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modelToolStripMenuItem,
            this.modelWithLabelsToolStripMenuItem,
            this.recogniseContentToolStripMenuItem});
            this.trainToolStripMenuItem.Name = "trainToolStripMenuItem";
            this.trainToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.trainToolStripMenuItem.Text = "Train";
            // 
            // modelToolStripMenuItem
            // 
            this.modelToolStripMenuItem.Name = "modelToolStripMenuItem";
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // modelWithLabelsToolStripMenuItem
            // 
            this.modelWithLabelsToolStripMenuItem.Name = "modelWithLabelsToolStripMenuItem";
            this.modelWithLabelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.modelWithLabelsToolStripMenuItem.Text = "Model With Labels";
            this.modelWithLabelsToolStripMenuItem.Click += new System.EventHandler(this.ModelWithLabelsToolStripMenuItem_Click);
            // 
            // recogniseContentToolStripMenuItem
            // 
            this.recogniseContentToolStripMenuItem.Name = "recogniseContentToolStripMenuItem";
            this.recogniseContentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.recogniseContentToolStripMenuItem.Text = "Recognise Content";
            this.recogniseContentToolStripMenuItem.Click += new System.EventHandler(this.RecogniseContentToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.analyzeFormToolStripMenuItem,
            this.manageModelsToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.manageToolStripMenuItem.Text = "Manage";
            // 
            // analyzeFormToolStripMenuItem
            // 
            this.analyzeFormToolStripMenuItem.Name = "analyzeFormToolStripMenuItem";
            this.analyzeFormToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.analyzeFormToolStripMenuItem.Text = "Analyze Form";
            this.analyzeFormToolStripMenuItem.Click += new System.EventHandler(this.AnalyzeFormToolStripMenuItem_Click);
            // 
            // manageModelsToolStripMenuItem
            // 
            this.manageModelsToolStripMenuItem.Name = "manageModelsToolStripMenuItem";
            this.manageModelsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageModelsToolStripMenuItem.Text = "Manage Models";
            this.manageModelsToolStripMenuItem.Click += new System.EventHandler(this.ManageModelsToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 535);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem selectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem folderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trainToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelWithLabelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recogniseContentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analyzeFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageModelsToolStripMenuItem;
    }
}

