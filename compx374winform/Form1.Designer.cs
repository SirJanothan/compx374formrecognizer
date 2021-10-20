using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.apiKeysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxContainers = new System.Windows.Forms.ListBox();
            this.listBoxBlobs = new System.Windows.Forms.ListBox();
            this.buttonNewContainer = new System.Windows.Forms.Button();
            this.buttonUploadFile = new System.Windows.Forms.Button();
            this.textBoxContainerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxModels = new System.Windows.Forms.ListBox();
            this.buttonNewModel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAnalyze = new System.Windows.Forms.Button();
            this.labelModelCount = new System.Windows.Forms.Label();
            this.buttonDeleteModel = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.apiKeysToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(728, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // apiKeysToolStripMenuItem
            // 
            this.apiKeysToolStripMenuItem.Name = "apiKeysToolStripMenuItem";
            this.apiKeysToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.apiKeysToolStripMenuItem.Text = "Api Keys";
            this.apiKeysToolStripMenuItem.Click += new System.EventHandler(this.ApiKeysToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // listBoxContainers
            // 
            this.listBoxContainers.FormattingEnabled = true;
            this.listBoxContainers.Location = new System.Drawing.Point(205, 58);
            this.listBoxContainers.Name = "listBoxContainers";
            this.listBoxContainers.Size = new System.Drawing.Size(243, 108);
            this.listBoxContainers.TabIndex = 8;
            this.listBoxContainers.SelectedIndexChanged += new System.EventHandler(this.ListBoxContainers_SelectedIndexChanged);
            // 
            // listBoxBlobs
            // 
            this.listBoxBlobs.FormattingEnabled = true;
            this.listBoxBlobs.Location = new System.Drawing.Point(466, 59);
            this.listBoxBlobs.Name = "listBoxBlobs";
            this.listBoxBlobs.Size = new System.Drawing.Size(248, 108);
            this.listBoxBlobs.TabIndex = 9;
            // 
            // buttonNewContainer
            // 
            this.buttonNewContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNewContainer.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonNewContainer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNewContainer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNewContainer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewContainer.Location = new System.Drawing.Point(9, 84);
            this.buttonNewContainer.Name = "buttonNewContainer";
            this.buttonNewContainer.Size = new System.Drawing.Size(152, 23);
            this.buttonNewContainer.TabIndex = 10;
            this.buttonNewContainer.Text = "Create New Container";
            this.buttonNewContainer.UseVisualStyleBackColor = false;
            this.buttonNewContainer.Click += new System.EventHandler(this.ButtonNewContainer_Click);
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonUploadFile.Enabled = false;
            this.buttonUploadFile.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonUploadFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonUploadFile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonUploadFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUploadFile.Location = new System.Drawing.Point(205, 174);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(509, 23);
            this.buttonUploadFile.TabIndex = 11;
            this.buttonUploadFile.Text = "Upload File to Container";
            this.buttonUploadFile.UseVisualStyleBackColor = false;
            this.buttonUploadFile.Click += new System.EventHandler(this.ButtonUploadFile_Click);
            // 
            // textBoxContainerName
            // 
            this.textBoxContainerName.Location = new System.Drawing.Point(9, 58);
            this.textBoxContainerName.Name = "textBoxContainerName";
            this.textBoxContainerName.Size = new System.Drawing.Size(152, 20);
            this.textBoxContainerName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Container Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Blob Storage Containers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(463, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selected Container:";
            // 
            // listBoxModels
            // 
            this.listBoxModels.BackColor = System.Drawing.SystemColors.Control;
            this.listBoxModels.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxModels.FormattingEnabled = true;
            this.listBoxModels.ItemHeight = 15;
            this.listBoxModels.Location = new System.Drawing.Point(0, 35);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(710, 139);
            this.listBoxModels.TabIndex = 16;
            this.listBoxModels.SelectedIndexChanged += new System.EventHandler(this.ListBoxModels_SelectedIndexChanged);
            // 
            // buttonNewModel
            // 
            this.buttonNewModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNewModel.Enabled = false;
            this.buttonNewModel.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.buttonNewModel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonNewModel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonNewModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewModel.Location = new System.Drawing.Point(604, 6);
            this.buttonNewModel.Name = "buttonNewModel";
            this.buttonNewModel.Size = new System.Drawing.Size(106, 26);
            this.buttonNewModel.TabIndex = 17;
            this.buttonNewModel.Text = "Train New Model";
            this.buttonNewModel.UseVisualStyleBackColor = false;
            this.buttonNewModel.Click += new System.EventHandler(this.ButtonNewModel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(467, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Form Recogniser Models:";
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.buttonAnalyze.Enabled = false;
            this.buttonAnalyze.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonAnalyze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.buttonAnalyze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonAnalyze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnalyze.Location = new System.Drawing.Point(492, 180);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(218, 23);
            this.buttonAnalyze.TabIndex = 19;
            this.buttonAnalyze.Text = "Analyze Forms Using Selected Model";
            this.buttonAnalyze.UseVisualStyleBackColor = false;
            this.buttonAnalyze.Click += new System.EventHandler(this.ButtonAnalyze_Click);
            // 
            // labelModelCount
            // 
            this.labelModelCount.AutoSize = true;
            this.labelModelCount.Location = new System.Drawing.Point(614, 55);
            this.labelModelCount.Name = "labelModelCount";
            this.labelModelCount.Size = new System.Drawing.Size(0, 13);
            this.labelModelCount.TabIndex = 20;
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeleteModel.Enabled = false;
            this.buttonDeleteModel.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonDeleteModel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buttonDeleteModel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonDeleteModel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteModel.Location = new System.Drawing.Point(0, 180);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(218, 23);
            this.buttonDeleteModel.TabIndex = 21;
            this.buttonDeleteModel.Text = "Delete Selected Model";
            this.buttonDeleteModel.UseVisualStyleBackColor = false;
            this.buttonDeleteModel.Click += new System.EventHandler(this.ButtonDeleteModel_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 444);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.buttonAnalyze);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.buttonNewModel);
            this.tabPage1.Controls.Add(this.buttonDeleteModel);
            this.tabPage1.Controls.Add(this.listBoxModels);
            this.tabPage1.ForeColor = System.Drawing.Color.Black;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Form Recogniser Models";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Form Recogniser Models";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.listBoxContainers);
            this.tabPage2.Controls.Add(this.listBoxBlobs);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.buttonNewContainer);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.buttonUploadFile);
            this.tabPage2.Controls.Add(this.textBoxContainerName);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Containers";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 24);
            this.label6.TabIndex = 23;
            this.label6.Text = "Containers";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(710, 24);
            this.label7.TabIndex = 24;
            this.label7.Text = "______________________________________________________________________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(728, 255);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelModelCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Recogniser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListBox listBoxContainers;
        private System.Windows.Forms.ListBox listBoxBlobs;
        private System.Windows.Forms.Button buttonNewContainer;
        private System.Windows.Forms.Button buttonUploadFile;
        private System.Windows.Forms.TextBox textBoxContainerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxModels;
        private System.Windows.Forms.Button buttonNewModel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAnalyze;
        private System.Windows.Forms.Label labelModelCount;
        private System.Windows.Forms.Button buttonDeleteModel;
        private System.Windows.Forms.ToolStripMenuItem apiKeysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}

