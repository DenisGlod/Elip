namespace ElipAdmin.View
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
            this.RTBData = new System.Windows.Forms.RichTextBox();
            this.CBDataType = new System.Windows.Forms.ComboBox();
            this.TBText = new System.Windows.Forms.TextBox();
            this.BSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBUserId = new System.Windows.Forms.TextBox();
            this.TBGroupId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RTBData
            // 
            this.RTBData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTBData.Location = new System.Drawing.Point(12, 80);
            this.RTBData.Name = "RTBData";
            this.RTBData.Size = new System.Drawing.Size(275, 99);
            this.RTBData.TabIndex = 0;
            this.RTBData.Text = "";
            // 
            // CBDataType
            // 
            this.CBDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBDataType.FormattingEnabled = true;
            this.CBDataType.Items.AddRange(new object[] {
            "Lab",
            "Test"});
            this.CBDataType.Location = new System.Drawing.Point(12, 29);
            this.CBDataType.Name = "CBDataType";
            this.CBDataType.Size = new System.Drawing.Size(121, 21);
            this.CBDataType.TabIndex = 1;
            // 
            // TBText
            // 
            this.TBText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBText.Location = new System.Drawing.Point(139, 30);
            this.TBText.Name = "TBText";
            this.TBText.Size = new System.Drawing.Size(148, 20);
            this.TBText.TabIndex = 2;
            // 
            // BSave
            // 
            this.BSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BSave.Image = global::ElipAdmin.Properties.Resources.tick;
            this.BSave.Location = new System.Drawing.Point(104, 235);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(96, 23);
            this.BSave.TabIndex = 3;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Тип данных:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Заголовок:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Данные:";
            // 
            // TBUserId
            // 
            this.TBUserId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TBUserId.Location = new System.Drawing.Point(12, 204);
            this.TBUserId.Name = "TBUserId";
            this.TBUserId.Size = new System.Drawing.Size(133, 20);
            this.TBUserId.TabIndex = 7;
            this.TBUserId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKey);
            // 
            // TBGroupId
            // 
            this.TBGroupId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TBGroupId.Location = new System.Drawing.Point(151, 204);
            this.TBGroupId.Name = "TBGroupId";
            this.TBGroupId.Size = new System.Drawing.Size(136, 20);
            this.TBGroupId.TabIndex = 8;
            this.TBGroupId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateKey);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Пользователя:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID Группы:";
            // 
            // AddEditDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 267);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBGroupId);
            this.Controls.Add(this.TBUserId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.TBText);
            this.Controls.Add(this.CBDataType);
            this.Controls.Add(this.RTBData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddEditDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEditDataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox RTBData;
        private System.Windows.Forms.ComboBox CBDataType;
        private System.Windows.Forms.TextBox TBText;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TBUserId;
        private System.Windows.Forms.TextBox TBGroupId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}