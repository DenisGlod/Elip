namespace ElipUser.View
{
    partial class CompletingOfTheWorkForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletingOfTheWorkForm));
            this.BSaveAnswerTest = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GBList = new System.Windows.Forms.GroupBox();
            this.TVQuestions = new System.Windows.Forms.TreeView();
            this.GBData = new System.Windows.Forms.GroupBox();
            this.RTBQuestion = new System.Windows.Forms.RichTextBox();
            this.GBAnswerTest = new System.Windows.Forms.GroupBox();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.RTB4 = new System.Windows.Forms.RichTextBox();
            this.RTB3 = new System.Windows.Forms.RichTextBox();
            this.RTB2 = new System.Windows.Forms.RichTextBox();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            this.PAnswerLab = new System.Windows.Forms.Panel();
            this.RTBAnswerText = new System.Windows.Forms.RichTextBox();
            this.BSaveAnswerLab = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.GBList.SuspendLayout();
            this.GBData.SuspendLayout();
            this.GBAnswerTest.SuspendLayout();
            this.PAnswerLab.SuspendLayout();
            this.SuspendLayout();
            // 
            // BSaveAnswerTest
            // 
            this.BSaveAnswerTest.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BSaveAnswerTest.AutoSize = true;
            this.BSaveAnswerTest.Image = global::ElipUser.Properties.Resources.floppy;
            this.BSaveAnswerTest.Location = new System.Drawing.Point(144, 152);
            this.BSaveAnswerTest.Name = "BSaveAnswerTest";
            this.BSaveAnswerTest.Size = new System.Drawing.Size(130, 29);
            this.BSaveAnswerTest.TabIndex = 0;
            this.BSaveAnswerTest.Text = "Подтвердить ответ";
            this.BSaveAnswerTest.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSaveAnswerTest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSaveAnswerTest.UseVisualStyleBackColor = true;
            this.BSaveAnswerTest.Click += new System.EventHandler(this.BSaveAnswerTest_Click);
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSave.AutoSize = true;
            this.BSave.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BSave.Image = global::ElipUser.Properties.Resources.tick;
            this.BSave.Location = new System.Drawing.Point(237, 6);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(86, 23);
            this.BSave.TabIndex = 13;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(564, 34);
            this.panel2.TabIndex = 7;
            // 
            // GBList
            // 
            this.GBList.Controls.Add(this.TVQuestions);
            this.GBList.Dock = System.Windows.Forms.DockStyle.Left;
            this.GBList.Location = new System.Drawing.Point(0, 0);
            this.GBList.Name = "GBList";
            this.GBList.Size = new System.Drawing.Size(128, 369);
            this.GBList.TabIndex = 8;
            this.GBList.TabStop = false;
            this.GBList.Text = "Список вопросов";
            // 
            // TVQuestions
            // 
            this.TVQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVQuestions.Location = new System.Drawing.Point(3, 16);
            this.TVQuestions.Name = "TVQuestions";
            this.TVQuestions.Size = new System.Drawing.Size(122, 350);
            this.TVQuestions.TabIndex = 4;
            this.TVQuestions.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TVQuestions_BeforeSelect);
            this.TVQuestions.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVQuestions_AfterSelect);
            // 
            // GBData
            // 
            this.GBData.Controls.Add(this.RTBQuestion);
            this.GBData.Dock = System.Windows.Forms.DockStyle.Top;
            this.GBData.Location = new System.Drawing.Point(128, 0);
            this.GBData.Name = "GBData";
            this.GBData.Size = new System.Drawing.Size(436, 182);
            this.GBData.TabIndex = 9;
            this.GBData.TabStop = false;
            this.GBData.Text = "Текст вопроса";
            // 
            // RTBQuestion
            // 
            this.RTBQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBQuestion.Location = new System.Drawing.Point(3, 16);
            this.RTBQuestion.Name = "RTBQuestion";
            this.RTBQuestion.ReadOnly = true;
            this.RTBQuestion.Size = new System.Drawing.Size(430, 163);
            this.RTBQuestion.TabIndex = 4;
            this.RTBQuestion.Text = "";
            // 
            // GBAnswerTest
            // 
            this.GBAnswerTest.Controls.Add(this.BSaveAnswerTest);
            this.GBAnswerTest.Controls.Add(this.CB4);
            this.GBAnswerTest.Controls.Add(this.CB3);
            this.GBAnswerTest.Controls.Add(this.CB2);
            this.GBAnswerTest.Controls.Add(this.CB1);
            this.GBAnswerTest.Controls.Add(this.RTB4);
            this.GBAnswerTest.Controls.Add(this.RTB3);
            this.GBAnswerTest.Controls.Add(this.RTB2);
            this.GBAnswerTest.Controls.Add(this.RTB1);
            this.GBAnswerTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBAnswerTest.Location = new System.Drawing.Point(128, 182);
            this.GBAnswerTest.Name = "GBAnswerTest";
            this.GBAnswerTest.Size = new System.Drawing.Size(436, 187);
            this.GBAnswerTest.TabIndex = 10;
            this.GBAnswerTest.TabStop = false;
            this.GBAnswerTest.Text = "Варианты ответов";
            this.GBAnswerTest.Visible = false;
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
            this.RTB4.ReadOnly = true;
            this.RTB4.Size = new System.Drawing.Size(100, 96);
            this.RTB4.TabIndex = 12;
            this.RTB4.Text = "";
            // 
            // RTB3
            // 
            this.RTB3.Location = new System.Drawing.Point(219, 48);
            this.RTB3.Name = "RTB3";
            this.RTB3.ReadOnly = true;
            this.RTB3.Size = new System.Drawing.Size(100, 96);
            this.RTB3.TabIndex = 10;
            this.RTB3.Text = "";
            // 
            // RTB2
            // 
            this.RTB2.Location = new System.Drawing.Point(113, 48);
            this.RTB2.Name = "RTB2";
            this.RTB2.ReadOnly = true;
            this.RTB2.Size = new System.Drawing.Size(100, 96);
            this.RTB2.TabIndex = 8;
            this.RTB2.Text = "";
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(7, 48);
            this.RTB1.Name = "RTB1";
            this.RTB1.ReadOnly = true;
            this.RTB1.Size = new System.Drawing.Size(100, 96);
            this.RTB1.TabIndex = 6;
            this.RTB1.Text = "";
            // 
            // PAnswerLab
            // 
            this.PAnswerLab.Controls.Add(this.RTBAnswerText);
            this.PAnswerLab.Controls.Add(this.BSaveAnswerLab);
            this.PAnswerLab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PAnswerLab.Location = new System.Drawing.Point(128, 182);
            this.PAnswerLab.Name = "PAnswerLab";
            this.PAnswerLab.Size = new System.Drawing.Size(436, 187);
            this.PAnswerLab.TabIndex = 11;
            this.PAnswerLab.Visible = false;
            // 
            // RTBAnswerText
            // 
            this.RTBAnswerText.Dock = System.Windows.Forms.DockStyle.Top;
            this.RTBAnswerText.Location = new System.Drawing.Point(0, 0);
            this.RTBAnswerText.Name = "RTBAnswerText";
            this.RTBAnswerText.Size = new System.Drawing.Size(436, 146);
            this.RTBAnswerText.TabIndex = 2;
            this.RTBAnswerText.Text = "";
            // 
            // BSaveAnswerLab
            // 
            this.BSaveAnswerLab.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BSaveAnswerLab.AutoSize = true;
            this.BSaveAnswerLab.Image = global::ElipUser.Properties.Resources.floppy;
            this.BSaveAnswerLab.Location = new System.Drawing.Point(144, 152);
            this.BSaveAnswerLab.Name = "BSaveAnswerLab";
            this.BSaveAnswerLab.Size = new System.Drawing.Size(130, 29);
            this.BSaveAnswerLab.TabIndex = 1;
            this.BSaveAnswerLab.Text = "Подтвердить ответ";
            this.BSaveAnswerLab.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSaveAnswerLab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSaveAnswerLab.UseVisualStyleBackColor = true;
            this.BSaveAnswerLab.Click += new System.EventHandler(this.BSaveAnswerLab_Click);
            // 
            // CompletingOfTheWorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 403);
            this.Controls.Add(this.GBAnswerTest);
            this.Controls.Add(this.PAnswerLab);
            this.Controls.Add(this.GBData);
            this.Controls.Add(this.GBList);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CompletingOfTheWorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выполнение работы";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.GBList.ResumeLayout(false);
            this.GBData.ResumeLayout(false);
            this.GBAnswerTest.ResumeLayout(false);
            this.GBAnswerTest.PerformLayout();
            this.PAnswerLab.ResumeLayout(false);
            this.PAnswerLab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox GBList;
        private System.Windows.Forms.GroupBox GBData;
        private System.Windows.Forms.RichTextBox RTBQuestion;
        private System.Windows.Forms.GroupBox GBAnswerTest;
        private System.Windows.Forms.CheckBox CB4;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.CheckBox CB2;
        private System.Windows.Forms.CheckBox CB1;
        private System.Windows.Forms.RichTextBox RTB4;
        private System.Windows.Forms.RichTextBox RTB3;
        private System.Windows.Forms.RichTextBox RTB2;
        private System.Windows.Forms.RichTextBox RTB1;
        private System.Windows.Forms.TreeView TVQuestions;
        private System.Windows.Forms.Button BSaveAnswerTest;
        private System.Windows.Forms.Panel PAnswerLab;
        private System.Windows.Forms.RichTextBox RTBAnswerText;
        private System.Windows.Forms.Button BSaveAnswerLab;
    }
}