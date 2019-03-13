namespace ElipAdmin.View
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RBTest = new System.Windows.Forms.RadioButton();
            this.RBLab = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBTest);
            this.groupBox1.Controls.Add(this.RBLab);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 78);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // RBTest
            // 
            this.RBTest.AutoSize = true;
            this.RBTest.Location = new System.Drawing.Point(30, 42);
            this.RBTest.Name = "RBTest";
            this.RBTest.Size = new System.Drawing.Size(49, 17);
            this.RBTest.TabIndex = 1;
            this.RBTest.TabStop = true;
            this.RBTest.Text = "Тест";
            this.RBTest.UseVisualStyleBackColor = true;
            // 
            // RBLab
            // 
            this.RBLab.AutoSize = true;
            this.RBLab.Location = new System.Drawing.Point(30, 19);
            this.RBLab.Name = "RBLab";
            this.RBLab.Size = new System.Drawing.Size(136, 17);
            this.RBLab.TabIndex = 0;
            this.RBLab.TabStop = true;
            this.RBLab.Text = "Лабораторная работа";
            this.RBLab.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::ElipAdmin.Properties.Resources.tick;
            this.button1.Location = new System.Drawing.Point(71, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "ОК";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BOpenAddEditDataForm_Click);
            // 
            // BeforeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BeforeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тип работы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RBTest;
        private System.Windows.Forms.RadioButton RBLab;
        private System.Windows.Forms.Button button1;
    }
}