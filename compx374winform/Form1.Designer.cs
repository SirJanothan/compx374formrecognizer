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
            this.buttonRecognize = new System.Windows.Forms.Button();
            this.buttonTrainModel = new System.Windows.Forms.Button();
            this.buttonTrainLabels = new System.Windows.Forms.Button();
            this.buttonManage = new System.Windows.Forms.Button();
            this.buttonAnalyzeForm = new System.Windows.Forms.Button();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.buttonSelectForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonRecognize
            // 
            this.buttonRecognize.Location = new System.Drawing.Point(12, 12);
            this.buttonRecognize.Name = "buttonRecognize";
            this.buttonRecognize.Size = new System.Drawing.Size(214, 23);
            this.buttonRecognize.TabIndex = 0;
            this.buttonRecognize.Text = "Recognize Content";
            this.buttonRecognize.UseVisualStyleBackColor = true;
            this.buttonRecognize.Click += new System.EventHandler(this.ButtonRecognize_Click);
            // 
            // buttonTrainModel
            // 
            this.buttonTrainModel.Location = new System.Drawing.Point(12, 41);
            this.buttonTrainModel.Name = "buttonTrainModel";
            this.buttonTrainModel.Size = new System.Drawing.Size(214, 23);
            this.buttonTrainModel.TabIndex = 1;
            this.buttonTrainModel.Text = "Train Model";
            this.buttonTrainModel.UseVisualStyleBackColor = true;
            this.buttonTrainModel.Click += new System.EventHandler(this.ButtonTrainModel_Click);
            // 
            // buttonTrainLabels
            // 
            this.buttonTrainLabels.Location = new System.Drawing.Point(12, 70);
            this.buttonTrainLabels.Name = "buttonTrainLabels";
            this.buttonTrainLabels.Size = new System.Drawing.Size(214, 23);
            this.buttonTrainLabels.TabIndex = 2;
            this.buttonTrainLabels.Text = "Train Model With Labels";
            this.buttonTrainLabels.UseVisualStyleBackColor = true;
            this.buttonTrainLabels.Click += new System.EventHandler(this.ButtonTrainLabels_Click);
            // 
            // buttonManage
            // 
            this.buttonManage.Location = new System.Drawing.Point(12, 128);
            this.buttonManage.Name = "buttonManage";
            this.buttonManage.Size = new System.Drawing.Size(214, 23);
            this.buttonManage.TabIndex = 3;
            this.buttonManage.Text = "Manage Models";
            this.buttonManage.UseVisualStyleBackColor = true;
            this.buttonManage.Click += new System.EventHandler(this.ButtonManage_Click);
            // 
            // buttonAnalyzeForm
            // 
            this.buttonAnalyzeForm.Location = new System.Drawing.Point(12, 99);
            this.buttonAnalyzeForm.Name = "buttonAnalyzeForm";
            this.buttonAnalyzeForm.Size = new System.Drawing.Size(214, 23);
            this.buttonAnalyzeForm.TabIndex = 4;
            this.buttonAnalyzeForm.Text = "Analyze Form";
            this.buttonAnalyzeForm.UseVisualStyleBackColor = true;
            this.buttonAnalyzeForm.Click += new System.EventHandler(this.ButtonAnalyzeForm_Click);
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(12, 221);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(214, 23);
            this.buttonSelectFolder.TabIndex = 5;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.ButtonSelectFiles_Click);
            // 
            // buttonSelectForm
            // 
            this.buttonSelectForm.Location = new System.Drawing.Point(13, 251);
            this.buttonSelectForm.Name = "buttonSelectForm";
            this.buttonSelectForm.Size = new System.Drawing.Size(213, 23);
            this.buttonSelectForm.TabIndex = 6;
            this.buttonSelectForm.Text = "Select a Form";
            this.buttonSelectForm.UseVisualStyleBackColor = true;
            this.buttonSelectForm.Click += new System.EventHandler(this.ButtonSelectForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSelectForm);
            this.Controls.Add(this.buttonSelectFolder);
            this.Controls.Add(this.buttonAnalyzeForm);
            this.Controls.Add(this.buttonManage);
            this.Controls.Add(this.buttonTrainLabels);
            this.Controls.Add(this.buttonTrainModel);
            this.Controls.Add(this.buttonRecognize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecognize;
        private System.Windows.Forms.Button buttonTrainModel;
        private System.Windows.Forms.Button buttonTrainLabels;
        private System.Windows.Forms.Button buttonManage;
        private System.Windows.Forms.Button buttonAnalyzeForm;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Button buttonSelectForm;
    }
}

