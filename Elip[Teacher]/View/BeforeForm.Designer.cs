namespace ElipTeacher.View
{
    partial class BeforeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BeforeForm));
            this.BOk = new System.Windows.Forms.Button();
            this.RBLab = new System.Windows.Forms.RadioButton();
            this.RBTest = new System.Windows.Forms.RadioButton();
            this.TBText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BOk
            // 
            this.BOk.Image = global::ElipTeacher.Properties.Resources.tick;
            this.BOk.Location = new System.Drawing.Point(71, 158);
            this.BOk.Name = "BOk";
            this.BOk.Size = new System.Drawing.Size(75, 23);
            this.BOk.TabIndex = 0;
            this.BOk.Text = "ОК";
            this.BOk.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BOk.UseVisualStyleBackColor = true;
            this.BOk.Click += new System.EventHandler(this.BOk_Click);
            // 
            // RBLab
            // 
            this.RBLab.AutoSize = true;
            this.RBLab.Location = new System.Drawing.Point(32, 29);
            this.RBLab.Name = "RBLab";
            this.RBLab.Size = new System.Drawing.Size(136, 17);
            this.RBLab.TabIndex = 1;
            this.RBLab.TabStop = true;
            this.RBLab.Text = "Лабораторная работа";
            this.RBLab.UseVisualStyleBackColor = true;
            // 
            // RBTest
            // 
            this.RBTest.AutoSize = true;
            this.RBTest.Location = new System.Drawing.Point(32, 52);
            this.RBTest.Name = "RBTest";
            this.RBTest.Size = new System.Drawing.Size(49, 17);
            this.RBTest.TabIndex = 2;
            this.RBTest.TabStop = true;
            this.RBTest.Text = "Тест";
            this.RBTest.UseVisualStyleBackColor = true;
            // 
            // TBText
            // 
            this.TBText.Location = new System.Drawing.Point(12, 123);
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(191, 20);
            this.TBText.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBLab);
            this.groupBox1.Controls.Add(this.RBTest);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип работы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название работы:";
            // 
            // BeforeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(215, 193);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.BOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BeforeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Выбор работы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOk;
        private System.Windows.Forms.RadioButton RBLab;
        private System.Windows.Forms.RadioButton RBTest;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
    }
}