﻿namespace ElipTeacher.View
{
    partial class AddEditDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditDataForm));
            this.LCount = new System.Windows.Forms.Label();
            this.NUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LNameProject = new System.Windows.Forms.Label();
            this.TBNameProject = new System.Windows.Forms.TextBox();
            this.BSaveOneObj = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BAttachFiles = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.GBList = new System.Windows.Forms.GroupBox();
            this.TVQuestions = new System.Windows.Forms.TreeView();
            this.GBData = new System.Windows.Forms.GroupBox();
            this.RTBText = new System.Windows.Forms.RichTextBox();
            this.GBAnswer = new System.Windows.Forms.GroupBox();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.RTB4 = new System.Windows.Forms.RichTextBox();
            this.RTB3 = new System.Windows.Forms.RichTextBox();
            this.RTB2 = new System.Windows.Forms.RichTextBox();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUDMark = new System.Windows.Forms.NumericUpDown();
            this.CBStatus = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBNameLab = new System.Windows.Forms.TextBox();
            this.GBAnswerLab = new System.Windows.Forms.GroupBox();
            this.RTBAnswerText = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.GBList.SuspendLayout();
            this.GBData.SuspendLayout();
            this.GBAnswer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMark)).BeginInit();
            this.GBAnswerLab.SuspendLayout();
            this.SuspendLayout();
            // 
            // LCount
            // 
            this.LCount.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LCount.AutoSize = true;
            this.LCount.Location = new System.Drawing.Point(23, 9);
            this.LCount.Name = "LCount";
            this.LCount.Size = new System.Drawing.Size(120, 13);
            this.LCount.TabIndex = 3;
            this.LCount.Text = "Количество вопросов:";
            // 
            // NUpDown
            // 
            this.NUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NUpDown.Location = new System.Drawing.Point(26, 26);
            this.NUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUpDown.Name = "NUpDown";
            this.NUpDown.Size = new System.Drawing.Size(117, 20);
            this.NUpDown.TabIndex = 1;
            this.NUpDown.ValueChanged += new System.EventHandler(this.NUpDown_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LNameProject);
            this.panel1.Controls.Add(this.TBNameProject);
            this.panel1.Controls.Add(this.BSaveOneObj);
            this.panel1.Controls.Add(this.NUpDown);
            this.panel1.Controls.Add(this.LCount);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 56);
            this.panel1.TabIndex = 5;
            // 
            // LNameProject
            // 
            this.LNameProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LNameProject.AutoSize = true;
            this.LNameProject.Location = new System.Drawing.Point(214, 9);
            this.LNameProject.Name = "LNameProject";
            this.LNameProject.Size = new System.Drawing.Size(100, 13);
            this.LNameProject.TabIndex = 6;
            this.LNameProject.Text = "Название работы:";
            // 
            // TBNameProject
            // 
            this.TBNameProject.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBNameProject.Location = new System.Drawing.Point(217, 25);
            this.TBNameProject.Name = "TBNameProject";
            this.TBNameProject.Size = new System.Drawing.Size(158, 20);
            this.TBNameProject.TabIndex = 5;
            // 
            // BSaveOneObj
            // 
            this.BSaveOneObj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSaveOneObj.AutoSize = true;
            this.BSaveOneObj.Image = global::ElipTeacher.Properties.Resources.floppy;
            this.BSaveOneObj.Location = new System.Drawing.Point(456, 16);
            this.BSaveOneObj.Name = "BSaveOneObj";
            this.BSaveOneObj.Size = new System.Drawing.Size(95, 29);
            this.BSaveOneObj.TabIndex = 0;
            this.BSaveOneObj.Text = "Сохранить";
            this.BSaveOneObj.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSaveOneObj.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSaveOneObj.UseVisualStyleBackColor = true;
            this.BSaveOneObj.Click += new System.EventHandler(this.BSaveOneObj_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BAttachFiles);
            this.panel2.Controls.Add(this.BSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 549);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 34);
            this.panel2.TabIndex = 7;
            // 
            // BAttachFiles
            // 
            this.BAttachFiles.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BAttachFiles.Image = global::ElipTeacher.Properties.Resources.iconfinder_folder_416376;
            this.BAttachFiles.Location = new System.Drawing.Point(12, 5);
            this.BAttachFiles.Name = "BAttachFiles";
            this.BAttachFiles.Size = new System.Drawing.Size(81, 23);
            this.BAttachFiles.TabIndex = 14;
            this.BAttachFiles.Text = "Файлы";
            this.BAttachFiles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAttachFiles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAttachFiles.UseVisualStyleBackColor = false;
            this.BAttachFiles.Click += new System.EventHandler(this.BAttachFiles_Click);
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSave.AutoSize = true;
            this.BSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BSave.Image = global::ElipTeacher.Properties.Resources.tick;
            this.BSave.Location = new System.Drawing.Point(236, 5);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(86, 23);
            this.BSave.TabIndex = 13;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // GBList
            // 
            this.GBList.Controls.Add(this.TVQuestions);
            this.GBList.Dock = System.Windows.Forms.DockStyle.Left;
            this.GBList.Location = new System.Drawing.Point(0, 106);
            this.GBList.Name = "GBList";
            this.GBList.Size = new System.Drawing.Size(128, 443);
            this.GBList.TabIndex = 8;
            this.GBList.TabStop = false;
            this.GBList.Text = "Список вопросов";
            // 
            // TVQuestions
            // 
            this.TVQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVQuestions.Location = new System.Drawing.Point(3, 16);
            this.TVQuestions.Name = "TVQuestions";
            this.TVQuestions.Size = new System.Drawing.Size(122, 424);
            this.TVQuestions.TabIndex = 4;
            this.TVQuestions.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TVQuestions_BeforeSelect);
            this.TVQuestions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVQuestions_AfterSelect);
            // 
            // GBData
            // 
            this.GBData.Controls.Add(this.RTBText);
            this.GBData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBData.Location = new System.Drawing.Point(128, 106);
            this.GBData.Name = "GBData";
            this.GBData.Size = new System.Drawing.Size(435, 106);
            this.GBData.TabIndex = 9;
            this.GBData.TabStop = false;
            this.GBData.Text = "Текст вопроса";
            // 
            // RTBText
            // 
            this.RTBText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBText.Location = new System.Drawing.Point(3, 16);
            this.RTBText.Name = "RTBText";
            this.RTBText.Size = new System.Drawing.Size(429, 87);
            this.RTBText.TabIndex = 4;
            this.RTBText.Text = "";
            // 
            // GBAnswer
            // 
            this.GBAnswer.Controls.Add(this.CB4);
            this.GBAnswer.Controls.Add(this.CB3);
            this.GBAnswer.Controls.Add(this.CB2);
            this.GBAnswer.Controls.Add(this.CB1);
            this.GBAnswer.Controls.Add(this.RTB4);
            this.GBAnswer.Controls.Add(this.RTB3);
            this.GBAnswer.Controls.Add(this.RTB2);
            this.GBAnswer.Controls.Add(this.RTB1);
            this.GBAnswer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBAnswer.Location = new System.Drawing.Point(128, 212);
            this.GBAnswer.Name = "GBAnswer";
            this.GBAnswer.Size = new System.Drawing.Size(435, 150);
            this.GBAnswer.TabIndex = 10;
            this.GBAnswer.TabStop = false;
            this.GBAnswer.Text = "Варианты ответов";
            // 
            // CB4
            // 
            this.CB4.AutoSize = true;
            this.CB4.Location = new System.Drawing.Point(325, 25);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(32, 17);
            this.CB4.TabIndex = 11;
            this.CB4.Text = "4";
            this.CB4.UseVisualStyleBackColor = true;
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.Location = new System.Drawing.Point(219, 25);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(32, 17);
            this.CB3.TabIndex = 9;
            this.CB3.Text = "3";
            this.CB3.UseVisualStyleBackColor = true;
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Location = new System.Drawing.Point(113, 25);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(32, 17);
            this.CB2.TabIndex = 7;
            this.CB2.Text = "2";
            this.CB2.UseVisualStyleBackColor = true;
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Location = new System.Drawing.Point(7, 25);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(32, 17);
            this.CB1.TabIndex = 5;
            this.CB1.Text = "1";
            this.CB1.UseVisualStyleBackColor = true;
            // 
            // RTB4
            // 
            this.RTB4.Location = new System.Drawing.Point(325, 48);
            this.RTB4.Name = "RTB4";
            this.RTB4.Size = new System.Drawing.Size(100, 96);
            this.RTB4.TabIndex = 12;
            this.RTB4.Text = "";
            // 
            // RTB3
            // 
            this.RTB3.Location = new System.Drawing.Point(219, 48);
            this.RTB3.Name = "RTB3";
            this.RTB3.Size = new System.Drawing.Size(100, 96);
            this.RTB3.TabIndex = 10;
            this.RTB3.Text = "";
            // 
            // RTB2
            // 
            this.RTB2.Location = new System.Drawing.Point(113, 48);
            this.RTB2.Name = "RTB2";
            this.RTB2.Size = new System.Drawing.Size(100, 96);
            this.RTB2.TabIndex = 8;
            this.RTB2.Text = "";
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(7, 48);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(100, 96);
            this.RTB1.TabIndex = 6;
            this.RTB1.Text = "";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.NUDMark);
            this.panel3.Controls.Add(this.CBStatus);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.TBNameLab);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 56);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(563, 50);
            this.panel3.TabIndex = 14;
            this.panel3.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Статус проверки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Оценка:";
            // 
            // NUDMark
            // 
            this.NUDMark.Location = new System.Drawing.Point(235, 24);
            this.NUDMark.Name = "NUDMark";
            this.NUDMark.Size = new System.Drawing.Size(120, 20);
            this.NUDMark.TabIndex = 10;
            // 
            // CBStatus
            // 
            this.CBStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBStatus.FormattingEnabled = true;
            this.CBStatus.Items.AddRange(new object[] {
            "Не проверено",
            "Проверено"});
            this.CBStatus.Location = new System.Drawing.Point(427, 23);
            this.CBStatus.Name = "CBStatus";
            this.CBStatus.Size = new System.Drawing.Size(121, 21);
            this.CBStatus.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название работы:";
            // 
            // TBNameLab
            // 
            this.TBNameLab.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBNameLab.Location = new System.Drawing.Point(26, 24);
            this.TBNameLab.Name = "TBNameLab";
            this.TBNameLab.ReadOnly = true;
            this.TBNameLab.Size = new System.Drawing.Size(158, 20);
            this.TBNameLab.TabIndex = 7;
            // 
            // GBAnswerLab
            // 
            this.GBAnswerLab.Controls.Add(this.RTBAnswerText);
            this.GBAnswerLab.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GBAnswerLab.Location = new System.Drawing.Point(128, 362);
            this.GBAnswerLab.Name = "GBAnswerLab";
            this.GBAnswerLab.Size = new System.Drawing.Size(435, 187);
            this.GBAnswerLab.TabIndex = 15;
            this.GBAnswerLab.TabStop = false;
            this.GBAnswerLab.Text = "Ответ";
            this.GBAnswerLab.Visible = false;
            // 
            // RTBAnswerText
            // 
            this.RTBAnswerText.BackColor = System.Drawing.SystemColors.Window;
            this.RTBAnswerText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBAnswerText.Location = new System.Drawing.Point(3, 16);
            this.RTBAnswerText.Name = "RTBAnswerText";
            this.RTBAnswerText.ReadOnly = true;
            this.RTBAnswerText.Size = new System.Drawing.Size(429, 168);
            this.RTBAnswerText.TabIndex = 2;
            this.RTBAnswerText.Text = "";
            // 
            // AddEditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 583);
            this.Controls.Add(this.GBData);
            this.Controls.Add(this.GBAnswer);
            this.Controls.Add(this.GBAnswerLab);
            this.Controls.Add(this.GBList);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GBList.ResumeLayout(false);
            this.GBData.ResumeLayout(false);
            this.GBAnswer.ResumeLayout(false);
            this.GBAnswer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDMark)).EndInit();
            this.GBAnswerLab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LCount;
        private System.Windows.Forms.NumericUpDown NUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GBList;
        private System.Windows.Forms.GroupBox GBData;
        private System.Windows.Forms.RichTextBox RTBText;
        private System.Windows.Forms.GroupBox GBAnswer;
        private System.Windows.Forms.CheckBox CB4;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.CheckBox CB2;
        private System.Windows.Forms.CheckBox CB1;
        private System.Windows.Forms.RichTextBox RTB4;
        private System.Windows.Forms.RichTextBox RTB3;
        private System.Windows.Forms.RichTextBox RTB2;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.TreeView TVQuestions;
        private System.Windows.Forms.Button BSaveOneObj;
        private System.Windows.Forms.Label LNameProject;
        private System.Windows.Forms.TextBox TBNameProject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox CBStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBNameLab;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUDMark;
        private System.Windows.Forms.GroupBox GBAnswerLab;
        private System.Windows.Forms.RichTextBox RTBAnswerText;
        private System.Windows.Forms.Button BAttachFiles;
    }
}