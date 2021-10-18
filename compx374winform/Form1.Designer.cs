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
            this.apiKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelModelCount = new System.Windows.Forms.Label();
            this.tabPageContainer = new System.Windows.Forms.TabPage();
            this.buttonUploadFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNewContainer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxBlobs = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxContainers = new System.Windows.Forms.ListBox();
            this.textBoxContainerName = new System.Windows.Forms.TextBox();
            this.tabPageFormRecogniser = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxModels = new System.Windows.Forms.ListBox();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.buttonDeleteModel = new System.Windows.Forms.Button();
            this.buttonNewModel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.tabPageContainer.SuspendLayout();
            this.tabPageFormRecogniser.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apiKeysToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(783, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apiKeysToolStripMenuItem
            // 
            this.apiKeysToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.apiKeysToolStripMenuItem.Name = "apiKeysToolStripMenuItem";
            this.apiKeysToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.apiKeysToolStripMenuItem.Text = "Api Keys";
            this.apiKeysToolStripMenuItem.Click += new System.EventHandler(this.ApiKeysToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // labelModelCount
            // 
            this.labelModelCount.AutoSize = true;
            this.labelModelCount.Location = new System.Drawing.Point(614, 55);
            this.labelModelCount.Name = "labelModelCount";
            this.labelModelCount.Size = new System.Drawing.Size(0, 13);
            this.labelModelCount.TabIndex = 20;
            // 
            // tabPageContainer
            // 
            this.tabPageContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageContainer.Controls.Add(this.textBoxContainerName);
            this.tabPageContainer.Controls.Add(this.listBoxContainers);
            this.tabPageContainer.Controls.Add(this.label3);
            this.tabPageContainer.Controls.Add(this.listBoxBlobs);
            this.tabPageContainer.Controls.Add(this.label2);
            this.tabPageContainer.Controls.Add(this.buttonNewContainer);
            this.tabPageContainer.Controls.Add(this.label1);
            this.tabPageContainer.Controls.Add(this.buttonUploadFile);
            this.tabPageContainer.Location = new System.Drawing.Point(4, 22);
            this.tabPageContainer.Name = "tabPageContainer";
            this.tabPageContainer.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageContainer.Size = new System.Drawing.Size(808, 474);
            this.tabPageContainer.TabIndex = 1;
            this.tabPageContainer.Text = "Containers";
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.BackColor = System.Drawing.Color.White;
            this.buttonUploadFile.Enabled = false;
            this.buttonUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonUploadFile.ForeColor = System.Drawing.Color.Black;
            this.buttonUploadFile.Location = new System.Drawing.Point(464, 184);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(151, 32);
            this.buttonUploadFile.TabIndex = 11;
            this.buttonUploadFile.Text = "Upload File to Container";
            this.buttonUploadFile.UseVisualStyleBackColor = false;
            this.buttonUploadFile.Click += new System.EventHandler(this.ButtonUploadFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Container Name";
            // 
            // buttonNewContainer
            // 
            this.buttonNewContainer.BackColor = System.Drawing.Color.White;
            this.buttonNewContainer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewContainer.ForeColor = System.Drawing.Color.Black;
            this.buttonNewContainer.Location = new System.Drawing.Point(625, 184);
            this.buttonNewContainer.Name = "buttonNewContainer";
            this.buttonNewContainer.Size = new System.Drawing.Size(152, 32);
            this.buttonNewContainer.TabIndex = 10;
            this.buttonNewContainer.Text = "Create New Container";
            this.buttonNewContainer.UseVisualStyleBackColor = false;
            this.buttonNewContainer.Click += new System.EventHandler(this.ButtonNewContainer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Blob Storage Containers:";
            // 
            // listBoxBlobs
            // 
            this.listBoxBlobs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxBlobs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxBlobs.ForeColor = System.Drawing.Color.White;
            this.listBoxBlobs.FormattingEnabled = true;
            this.listBoxBlobs.Location = new System.Drawing.Point(403, 67);
            this.listBoxBlobs.Name = "listBoxBlobs";
            this.listBoxBlobs.Size = new System.Drawing.Size(374, 106);
            this.listBoxBlobs.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(402, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selected Container:";
            // 
            // listBoxContainers
            // 
            this.listBoxContainers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxContainers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxContainers.ForeColor = System.Drawing.Color.White;
            this.listBoxContainers.FormattingEnabled = true;
            this.listBoxContainers.Location = new System.Drawing.Point(8, 67);
            this.listBoxContainers.Name = "listBoxContainers";
            this.listBoxContainers.Size = new System.Drawing.Size(374, 106);
            this.listBoxContainers.TabIndex = 8;
            this.listBoxContainers.SelectedIndexChanged += new System.EventHandler(this.ListBoxContainers_SelectedIndexChanged);
            // 
            // textBoxContainerName
            // 
            this.textBoxContainerName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxContainerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxContainerName.ForeColor = System.Drawing.Color.White;
            this.textBoxContainerName.Location = new System.Drawing.Point(11, 22);
            this.textBoxContainerName.Name = "textBoxContainerName";
            this.textBoxContainerName.Size = new System.Drawing.Size(766, 20);
            this.textBoxContainerName.TabIndex = 12;
            // 
            // tabPageFormRecogniser
            // 
            this.tabPageFormRecogniser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tabPageFormRecogniser.Controls.Add(this.buttonNewModel);
            this.tabPageFormRecogniser.Controls.Add(this.buttonDeleteModel);
            this.tabPageFormRecogniser.Controls.Add(this.buttonAnalyze);
            this.tabPageFormRecogniser.Controls.Add(this.listBoxModels);
            this.tabPageFormRecogniser.Controls.Add(this.label4);
            this.tabPageFormRecogniser.Location = new System.Drawing.Point(4, 22);
            this.tabPageFormRecogniser.Name = "tabPageFormRecogniser";
            this.tabPageFormRecogniser.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFormRecogniser.Size = new System.Drawing.Size(808, 474);
            this.tabPageFormRecogniser.TabIndex = 0;
            this.tabPageFormRecogniser.Text = "Form Recogniser Models";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(6, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 24);
            this.label4.TabIndex = 18;
            this.label4.Text = "Form Recogniser Models:";
            // 
            // listBoxModels
            // 
            this.listBoxModels.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBoxModels.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxModels.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxModels.ForeColor = System.Drawing.Color.White;
            this.listBoxModels.FormattingEnabled = true;
            this.listBoxModels.Location = new System.Drawing.Point(6, 40);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(771, 145);
            this.listBoxModels.TabIndex = 16;
            this.listBoxModels.SelectedIndexChanged += new System.EventHandler(this.ListBoxModels_SelectedIndexChanged);
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.BackColor = System.Drawing.Color.White;
            this.buttonAnalyze.Enabled = false;
            this.buttonAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnalyze.Location = new System.Drawing.Point(574, 191);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(203, 28);
            this.buttonAnalyze.TabIndex = 19;
            this.buttonAnalyze.Text = "Analyze Forms Using Selected Model";
            this.buttonAnalyze.UseVisualStyleBackColor = false;
            this.buttonAnalyze.Click += new System.EventHandler(this.ButtonAnalyze_Click);
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.BackColor = System.Drawing.Color.LightCoral;
            this.buttonDeleteModel.Enabled = false;
            this.buttonDeleteModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDeleteModel.Location = new System.Drawing.Point(6, 191);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(206, 28);
            this.buttonDeleteModel.TabIndex = 21;
            this.buttonDeleteModel.Text = "Delete Selected Model";
            this.buttonDeleteModel.UseVisualStyleBackColor = false;
            this.buttonDeleteModel.Click += new System.EventHandler(this.ButtonDeleteModel_Click);
            // 
            // buttonNewModel
            // 
            this.buttonNewModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNewModel.Enabled = false;
            this.buttonNewModel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonNewModel.Location = new System.Drawing.Point(628, 6);
            this.buttonNewModel.Name = "buttonNewModel";
            this.buttonNewModel.Size = new System.Drawing.Size(149, 28);
            this.buttonNewModel.TabIndex = 17;
            this.buttonNewModel.Text = "Train New Model";
            this.buttonNewModel.UseVisualStyleBackColor = false;
            this.buttonNewModel.Click += new System.EventHandler(this.ButtonNewModel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFormRecogniser);
            this.tabControl1.Controls.Add(this.tabPageContainer);
            this.tabControl1.Location = new System.Drawing.Point(-5, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(816, 500);
            this.tabControl1.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(783, 271);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelModelCount);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form Analyser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPageContainer.ResumeLayout(false);
            this.tabPageContainer.PerformLayout();
            this.tabPageFormRecogniser.ResumeLayout(false);
            this.tabPageFormRecogniser.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label labelModelCount;
        private System.Windows.Forms.ToolStripMenuItem apiKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPageContainer;
        private System.Windows.Forms.TextBox textBoxContainerName;
        private System.Windows.Forms.ListBox listBoxContainers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxBlobs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonNewContainer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUploadFile;
        private System.Windows.Forms.TabPage tabPageFormRecogniser;
        private System.Windows.Forms.Button buttonNewModel;
        private System.Windows.Forms.Button buttonDeleteModel;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.ListBox listBoxModels;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

