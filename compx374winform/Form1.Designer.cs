﻿namespace compx374winform
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
            this.azureStorageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBlobContainersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewContainerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectToolStripMenuItem,
            this.trainToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.azureStorageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1329, 24);
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
            this.modelToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.modelToolStripMenuItem.Text = "Model";
            this.modelToolStripMenuItem.Click += new System.EventHandler(this.ModelToolStripMenuItem_Click);
            // 
            // modelWithLabelsToolStripMenuItem
            // 
            this.modelWithLabelsToolStripMenuItem.Name = "modelWithLabelsToolStripMenuItem";
            this.modelWithLabelsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.modelWithLabelsToolStripMenuItem.Text = "Model With Labels";
            this.modelWithLabelsToolStripMenuItem.Click += new System.EventHandler(this.ModelWithLabelsToolStripMenuItem_Click);
            // 
            // recogniseContentToolStripMenuItem
            // 
            this.recogniseContentToolStripMenuItem.Name = "recogniseContentToolStripMenuItem";
            this.recogniseContentToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
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
            this.analyzeFormToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.analyzeFormToolStripMenuItem.Text = "Analyze Form";
            this.analyzeFormToolStripMenuItem.Click += new System.EventHandler(this.AnalyzeFormToolStripMenuItem_Click);
            // 
            // manageModelsToolStripMenuItem
            // 
            this.manageModelsToolStripMenuItem.Name = "manageModelsToolStripMenuItem";
            this.manageModelsToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.manageModelsToolStripMenuItem.Text = "Manage Models";
            this.manageModelsToolStripMenuItem.Click += new System.EventHandler(this.ManageModelsToolStripMenuItem_Click);
            // 
            // azureStorageToolStripMenuItem
            // 
            this.azureStorageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewBlobContainersToolStripMenuItem,
            this.createNewContainerToolStripMenuItem});
            this.azureStorageToolStripMenuItem.Name = "azureStorageToolStripMenuItem";
            this.azureStorageToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.azureStorageToolStripMenuItem.Text = "Azure Storage";
            // 
            // viewBlobContainersToolStripMenuItem
            // 
            this.viewBlobContainersToolStripMenuItem.Name = "viewBlobContainersToolStripMenuItem";
            this.viewBlobContainersToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.viewBlobContainersToolStripMenuItem.Text = "View Blob Containers";
            // 
            // createNewContainerToolStripMenuItem
            // 
            this.createNewContainerToolStripMenuItem.Name = "createNewContainerToolStripMenuItem";
            this.createNewContainerToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.createNewContainerToolStripMenuItem.Text = "Create New Container";
            this.createNewContainerToolStripMenuItem.Click += new System.EventHandler(this.CreateNewContainerToolStripMenuItem_Click);
            // 
            // listBoxContainers
            // 
            this.listBoxContainers.FormattingEnabled = true;
            this.listBoxContainers.Location = new System.Drawing.Point(169, 66);
            this.listBoxContainers.Name = "listBoxContainers";
            this.listBoxContainers.Size = new System.Drawing.Size(152, 95);
            this.listBoxContainers.TabIndex = 8;
            this.listBoxContainers.SelectedIndexChanged += new System.EventHandler(this.ListBoxContainers_SelectedIndexChanged);
            // 
            // listBoxBlobs
            // 
            this.listBoxBlobs.FormattingEnabled = true;
            this.listBoxBlobs.Location = new System.Drawing.Point(12, 69);
            this.listBoxBlobs.Name = "listBoxBlobs";
            this.listBoxBlobs.Size = new System.Drawing.Size(151, 95);
            this.listBoxBlobs.TabIndex = 9;
            // 
            // buttonNewContainer
            // 
            this.buttonNewContainer.Location = new System.Drawing.Point(143, 257);
            this.buttonNewContainer.Name = "buttonNewContainer";
            this.buttonNewContainer.Size = new System.Drawing.Size(151, 23);
            this.buttonNewContainer.TabIndex = 10;
            this.buttonNewContainer.Text = "Create New Container";
            this.buttonNewContainer.UseVisualStyleBackColor = true;
            this.buttonNewContainer.Click += new System.EventHandler(this.ButtonNewContainer_Click);
            // 
            // buttonUploadFile
            // 
            this.buttonUploadFile.Enabled = false;
            this.buttonUploadFile.Location = new System.Drawing.Point(12, 170);
            this.buttonUploadFile.Name = "buttonUploadFile";
            this.buttonUploadFile.Size = new System.Drawing.Size(151, 23);
            this.buttonUploadFile.TabIndex = 11;
            this.buttonUploadFile.Text = "Upload File to Container";
            this.buttonUploadFile.UseVisualStyleBackColor = true;
            this.buttonUploadFile.Click += new System.EventHandler(this.ButtonUploadFile_Click);
            // 
            // textBoxContainerName
            // 
            this.textBoxContainerName.Location = new System.Drawing.Point(143, 231);
            this.textBoxContainerName.Name = "textBoxContainerName";
            this.textBoxContainerName.Size = new System.Drawing.Size(151, 20);
            this.textBoxContainerName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Container Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Blob Storage Containers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Selected Container:";
            // 
            // listBoxModels
            // 
            this.listBoxModels.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxModels.FormattingEnabled = true;
            this.listBoxModels.Location = new System.Drawing.Point(499, 69);
            this.listBoxModels.Name = "listBoxModels";
            this.listBoxModels.Size = new System.Drawing.Size(502, 147);
            this.listBoxModels.TabIndex = 16;
            this.listBoxModels.SelectedIndexChanged += new System.EventHandler(this.ListBoxModels_SelectedIndexChanged);
            // 
            // buttonNewModel
            // 
            this.buttonNewModel.Enabled = false;
            this.buttonNewModel.Location = new System.Drawing.Point(327, 66);
            this.buttonNewModel.Name = "buttonNewModel";
            this.buttonNewModel.Size = new System.Drawing.Size(150, 62);
            this.buttonNewModel.TabIndex = 17;
            this.buttonNewModel.Text = "Train New Model";
            this.buttonNewModel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Form Recogniser Models:";
            // 
            // buttonAnalyze
            // 
            this.buttonAnalyze.Enabled = false;
            this.buttonAnalyze.Location = new System.Drawing.Point(1007, 69);
            this.buttonAnalyze.Name = "buttonAnalyze";
            this.buttonAnalyze.Size = new System.Drawing.Size(169, 47);
            this.buttonAnalyze.TabIndex = 19;
            this.buttonAnalyze.Text = "Analyze Forms Using Selected Model";
            this.buttonAnalyze.UseVisualStyleBackColor = true;
            this.buttonAnalyze.Click += new System.EventHandler(this.ButtonAnalyze_Click);
            // 
            // labelModelCount
            // 
            this.labelModelCount.AutoSize = true;
            this.labelModelCount.Location = new System.Drawing.Point(657, 50);
            this.labelModelCount.Name = "labelModelCount";
            this.labelModelCount.Size = new System.Drawing.Size(0, 13);
            this.labelModelCount.TabIndex = 20;
            // 
            // buttonDeleteModel
            // 
            this.buttonDeleteModel.Enabled = false;
            this.buttonDeleteModel.Location = new System.Drawing.Point(499, 222);
            this.buttonDeleteModel.Name = "buttonDeleteModel";
            this.buttonDeleteModel.Size = new System.Drawing.Size(232, 23);
            this.buttonDeleteModel.TabIndex = 21;
            this.buttonDeleteModel.Text = "Delete Selected Model";
            this.buttonDeleteModel.UseVisualStyleBackColor = true;
            this.buttonDeleteModel.Click += new System.EventHandler(this.ButtonDeleteModel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 611);
            this.Controls.Add(this.buttonDeleteModel);
            this.Controls.Add(this.labelModelCount);
            this.Controls.Add(this.buttonAnalyze);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonNewModel);
            this.Controls.Add(this.listBoxModels);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxContainerName);
            this.Controls.Add(this.buttonUploadFile);
            this.Controls.Add(this.buttonNewContainer);
            this.Controls.Add(this.listBoxBlobs);
            this.Controls.Add(this.listBoxContainers);
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
        private System.Windows.Forms.ToolStripMenuItem azureStorageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBlobContainersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewContainerToolStripMenuItem;
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
    }
}

