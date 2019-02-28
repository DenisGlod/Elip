namespace ElipTeacher.View
{
    partial class AddDataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddDataForm));
            this.label2 = new System.Windows.Forms.Label();
            this.NUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LBQuestions = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RTBText = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.CB4 = new System.Windows.Forms.CheckBox();
            this.CB3 = new System.Windows.Forms.CheckBox();
            this.CB2 = new System.Windows.Forms.CheckBox();
            this.CB1 = new System.Windows.Forms.CheckBox();
            this.RTB4 = new System.Windows.Forms.RichTextBox();
            this.RTB3 = new System.Windows.Forms.RichTextBox();
            this.RTB2 = new System.Windows.Forms.RichTextBox();
            this.RTB1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(121, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество вопросов:";
            // 
            // NUpDown
            // 
            this.NUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NUpDown.Location = new System.Drawing.Point(124, 26);
            this.NUpDown.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.NUpDown.Name = "NUpDown";
            this.NUpDown.Size = new System.Drawing.Size(117, 20);
            this.NUpDown.TabIndex = 4;
            this.NUpDown.ValueChanged += new System.EventHandler(this.NUpDown_ValueChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.TBText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.NUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 56);
            this.panel1.TabIndex = 5;
            // 
            // TBText
            // 
            this.TBText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBText.Location = new System.Drawing.Point(253, 26);
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(194, 20);
            this.TBText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование работы:";
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSave.Image = global::ElipTeacher.Properties.Resources.tick;
            this.BSave.Location = new System.Drawing.Point(235, 6);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(102, 23);
            this.BSave.TabIndex = 5;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 369);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(560, 34);
            this.panel2.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LBQuestions);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 313);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список вопросов";
            // 
            // LBQuestions
            // 
            this.LBQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBQuestions.FormattingEnabled = true;
            this.LBQuestions.Location = new System.Drawing.Point(3, 16);
            this.LBQuestions.Name = "LBQuestions";
            this.LBQuestions.Size = new System.Drawing.Size(122, 294);
            this.LBQuestions.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RTBText);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(128, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 163);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Текст вопроса";
            // 
            // RTBText
            // 
            this.RTBText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTBText.Location = new System.Drawing.Point(3, 16);
            this.RTBText.Name = "RTBText";
            this.RTBText.Size = new System.Drawing.Size(426, 144);
            this.RTBText.TabIndex = 0;
            this.RTBText.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.CB4);
            this.groupBox3.Controls.Add(this.CB3);
            this.groupBox3.Controls.Add(this.CB2);
            this.groupBox3.Controls.Add(this.CB1);
            this.groupBox3.Controls.Add(this.RTB4);
            this.groupBox3.Controls.Add(this.RTB3);
            this.groupBox3.Controls.Add(this.RTB2);
            this.groupBox3.Controls.Add(this.RTB1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(128, 219);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(432, 150);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Варианты ответов";
            // 
            // CB4
            // 
            this.CB4.AutoSize = true;
            this.CB4.Location = new System.Drawing.Point(325, 25);
            this.CB4.Name = "CB4";
            this.CB4.Size = new System.Drawing.Size(32, 17);
            this.CB4.TabIndex = 7;
            this.CB4.Text = "4";
            this.CB4.UseVisualStyleBackColor = true;
            // 
            // CB3
            // 
            this.CB3.AutoSize = true;
            this.CB3.Location = new System.Drawing.Point(219, 25);
            this.CB3.Name = "CB3";
            this.CB3.Size = new System.Drawing.Size(32, 17);
            this.CB3.TabIndex = 6;
            this.CB3.Text = "3";
            this.CB3.UseVisualStyleBackColor = true;
            // 
            // CB2
            // 
            this.CB2.AutoSize = true;
            this.CB2.Location = new System.Drawing.Point(113, 25);
            this.CB2.Name = "CB2";
            this.CB2.Size = new System.Drawing.Size(32, 17);
            this.CB2.TabIndex = 5;
            this.CB2.Text = "2";
            this.CB2.UseVisualStyleBackColor = true;
            // 
            // CB1
            // 
            this.CB1.AutoSize = true;
            this.CB1.Location = new System.Drawing.Point(7, 25);
            this.CB1.Name = "CB1";
            this.CB1.Size = new System.Drawing.Size(32, 17);
            this.CB1.TabIndex = 4;
            this.CB1.Text = "1";
            this.CB1.UseVisualStyleBackColor = true;
            // 
            // RTB4
            // 
            this.RTB4.Location = new System.Drawing.Point(325, 48);
            this.RTB4.Name = "RTB4";
            this.RTB4.Size = new System.Drawing.Size(100, 96);
            this.RTB4.TabIndex = 3;
            this.RTB4.Text = "";
            // 
            // RTB3
            // 
            this.RTB3.Location = new System.Drawing.Point(219, 48);
            this.RTB3.Name = "RTB3";
            this.RTB3.Size = new System.Drawing.Size(100, 96);
            this.RTB3.TabIndex = 2;
            this.RTB3.Text = "";
            // 
            // RTB2
            // 
            this.RTB2.Location = new System.Drawing.Point(113, 48);
            this.RTB2.Name = "RTB2";
            this.RTB2.Size = new System.Drawing.Size(100, 96);
            this.RTB2.TabIndex = 1;
            this.RTB2.Text = "";
            // 
            // RTB1
            // 
            this.RTB1.Location = new System.Drawing.Point(7, 48);
            this.RTB1.Name = "RTB1";
            this.RTB1.Size = new System.Drawing.Size(100, 96);
            this.RTB1.TabIndex = 0;
            this.RTB1.Text = "";
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 403);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/Редактирование";
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LBQuestions;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox RTBText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox CB4;
        private System.Windows.Forms.CheckBox CB3;
        private System.Windows.Forms.CheckBox CB2;
        private System.Windows.Forms.CheckBox CB1;
        private System.Windows.Forms.RichTextBox RTB4;
        private System.Windows.Forms.RichTextBox RTB3;
        private System.Windows.Forms.RichTextBox RTB2;
        private System.Windows.Forms.RichTextBox RTB1;
    }
}