namespace ElipTeacher.View
{
    partial class AttachFilesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttachFilesForm));
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.TVAttachFiles = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BDeleteFile = new System.Windows.Forms.Button();
            this.BAddFile = new System.Windows.Forms.Button();
            this.BSaveAttachFiles = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.Multiselect = true;
            this.OpenFileDialog.Title = "Выберите файлы";
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.TVAttachFiles);
            this.groupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox.Location = new System.Drawing.Point(0, 0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(495, 261);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Выбранные файлы:";
            // 
            // TVAttachFiles
            // 
            this.TVAttachFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVAttachFiles.FullRowSelect = true;
            this.TVAttachFiles.Location = new System.Drawing.Point(3, 16);
            this.TVAttachFiles.Name = "TVAttachFiles";
            this.TVAttachFiles.Size = new System.Drawing.Size(489, 242);
            this.TVAttachFiles.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BDeleteFile);
            this.panel1.Controls.Add(this.BAddFile);
            this.panel1.Controls.Add(this.BSaveAttachFiles);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(495, 46);
            this.panel1.TabIndex = 1;
            // 
            // BDeleteFile
            // 
            this.BDeleteFile.Location = new System.Drawing.Point(93, 11);
            this.BDeleteFile.Name = "BDeleteFile";
            this.BDeleteFile.Size = new System.Drawing.Size(75, 23);
            this.BDeleteFile.TabIndex = 2;
            this.BDeleteFile.Text = "Удалить";
            this.BDeleteFile.UseVisualStyleBackColor = true;
            this.BDeleteFile.Click += new System.EventHandler(this.BDeleteFile_Click);
            // 
            // BAddFile
            // 
            this.BAddFile.Location = new System.Drawing.Point(12, 11);
            this.BAddFile.Name = "BAddFile";
            this.BAddFile.Size = new System.Drawing.Size(75, 23);
            this.BAddFile.TabIndex = 1;
            this.BAddFile.Text = "Добавить";
            this.BAddFile.UseVisualStyleBackColor = true;
            this.BAddFile.Click += new System.EventHandler(this.BAddFile_Click);
            // 
            // BSaveAttachFiles
            // 
            this.BSaveAttachFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSaveAttachFiles.Image = global::ElipTeacher.Properties.Resources.floppy;
            this.BSaveAttachFiles.Location = new System.Drawing.Point(390, 11);
            this.BSaveAttachFiles.Name = "BSaveAttachFiles";
            this.BSaveAttachFiles.Size = new System.Drawing.Size(93, 23);
            this.BSaveAttachFiles.TabIndex = 0;
            this.BSaveAttachFiles.Text = "Сохранить";
            this.BSaveAttachFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSaveAttachFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSaveAttachFiles.UseVisualStyleBackColor = true;
            this.BSaveAttachFiles.Click += new System.EventHandler(this.BSaveAttachFiles_Click);
            // 
            // AttachFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 261);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AttachFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить файлы";
            this.groupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSaveAttachFiles;
        private System.Windows.Forms.TreeView TVAttachFiles;
        private System.Windows.Forms.Button BDeleteFile;
        private System.Windows.Forms.Button BAddFile;
    }
}