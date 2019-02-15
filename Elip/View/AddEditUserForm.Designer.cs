namespace Elip.View
{
    partial class AddEditUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditUserForm));
            this.TBId = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBLastName = new System.Windows.Forms.TextBox();
            this.TBFirstName = new System.Windows.Forms.TextBox();
            this.TBMiddleName = new System.Windows.Forms.TextBox();
            this.TBIdGroup = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BSave = new System.Windows.Forms.Button();
            this.CBRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // TBId
            // 
            this.TBId.Location = new System.Drawing.Point(89, 23);
            this.TBId.Name = "TBId";
            this.TBId.Size = new System.Drawing.Size(121, 20);
            this.TBId.TabIndex = 0;
            this.TBId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBId_KeyPress);
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(89, 49);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(121, 20);
            this.TBLogin.TabIndex = 1;
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(89, 75);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(121, 20);
            this.TBPassword.TabIndex = 2;
            // 
            // TBLastName
            // 
            this.TBLastName.Location = new System.Drawing.Point(89, 101);
            this.TBLastName.Name = "TBLastName";
            this.TBLastName.Size = new System.Drawing.Size(121, 20);
            this.TBLastName.TabIndex = 3;
            // 
            // TBFirstName
            // 
            this.TBFirstName.Location = new System.Drawing.Point(89, 127);
            this.TBFirstName.Name = "TBFirstName";
            this.TBFirstName.Size = new System.Drawing.Size(121, 20);
            this.TBFirstName.TabIndex = 4;
            // 
            // TBMiddleName
            // 
            this.TBMiddleName.Location = new System.Drawing.Point(89, 153);
            this.TBMiddleName.Name = "TBMiddleName";
            this.TBMiddleName.Size = new System.Drawing.Size(121, 20);
            this.TBMiddleName.TabIndex = 5;
            // 
            // TBIdGroup
            // 
            this.TBIdGroup.Location = new System.Drawing.Point(89, 206);
            this.TBIdGroup.Name = "TBIdGroup";
            this.TBIdGroup.Size = new System.Drawing.Size(121, 20);
            this.TBIdGroup.TabIndex = 7;
            this.TBIdGroup.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBIdGroup_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Фамилия";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Имя";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Отчество";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(47, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Роль";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 209);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Id Группы";
            // 
            // BSave
            // 
            this.BSave.Image = global::Elip.Properties.Resources.tick;
            this.BSave.Location = new System.Drawing.Point(66, 242);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(101, 23);
            this.BSave.TabIndex = 16;
            this.BSave.Text = "Сохранить";
            this.BSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BSave.UseVisualStyleBackColor = true;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // CBRole
            // 
            this.CBRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRole.FormattingEnabled = true;
            this.CBRole.Items.AddRange(new object[] {
            "Администратор",
            "Преподаватель",
            "Пользователь"});
            this.CBRole.Location = new System.Drawing.Point(89, 179);
            this.CBRole.Name = "CBRole";
            this.CBRole.Size = new System.Drawing.Size(121, 21);
            this.CBRole.TabIndex = 17;
            // 
            // AddEditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 278);
            this.Controls.Add(this.CBRole);
            this.Controls.Add(this.BSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBIdGroup);
            this.Controls.Add(this.TBMiddleName);
            this.Controls.Add(this.TBFirstName);
            this.Controls.Add(this.TBLastName);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.TBId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddEditUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление/Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBId;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBLastName;
        private System.Windows.Forms.TextBox TBFirstName;
        private System.Windows.Forms.TextBox TBMiddleName;
        private System.Windows.Forms.TextBox TBIdGroup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.ComboBox CBRole;
    }
}