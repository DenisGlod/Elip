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
            this.CBDataType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TBText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NUpDown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // CBDataType
            // 
            this.CBDataType.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CBDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataType.FormattingEnabled = true;
            this.CBDataType.Items.AddRange(new object[] {
            "Лабораторная",
            "Тест"});
            this.CBDataType.Location = new System.Drawing.Point(19, 26);
            this.CBDataType.Name = "CBDataType";
            this.CBDataType.Size = new System.Drawing.Size(121, 21);
            this.CBDataType.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Тип работы:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Количество вопросов:";
            // 
            // NUpDown
            // 
            this.NUpDown.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NUpDown.Location = new System.Drawing.Point(150, 26);
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
            this.panel1.Controls.Add(this.CBDataType);
            this.panel1.Controls.Add(this.NUpDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(492, 62);
            this.panel1.TabIndex = 5;
            // 
            // TBText
            // 
            this.TBText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TBText.Location = new System.Drawing.Point(279, 26);
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(194, 20);
            this.TBText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Наименование работы:";
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BSave.Image = global::ElipTeacher.Properties.Resources.tick;
            this.BSave.Location = new System.Drawing.Point(201, 6);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(102, 23);
            this.BSave.TabIndex = 5;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = true;
            // 
            // TabControl
            // 
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 62);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(492, 222);
            this.TabControl.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 34);
            this.panel2.TabIndex = 7;
            // 
            // AddDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 318);
            this.Controls.Add(this.TabControl);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBDataType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NUpDown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
    }
}