namespace ElipUser.View
{
    partial class UserForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LNumberGroup = new System.Windows.Forms.Label();
            this.BSettings = new System.Windows.Forms.Button();
            this.LUserInfo = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVDataInGroup = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BStart = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVMyLabAndTest = new System.Windows.Forms.DataGridView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataInGroup)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMyLabAndTest)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.Controls.Add(this.LNumberGroup);
            this.panel1.Controls.Add(this.BSettings);
            this.panel1.Controls.Add(this.LUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(590, 43);
            this.panel1.TabIndex = 0;
            // 
            // LNumberGroup
            // 
            this.LNumberGroup.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LNumberGroup.AutoSize = true;
            this.LNumberGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LNumberGroup.Location = new System.Drawing.Point(408, 13);
            this.LNumberGroup.Name = "LNumberGroup";
            this.LNumberGroup.Size = new System.Drawing.Size(108, 16);
            this.LNumberGroup.TabIndex = 3;
            this.LNumberGroup.Text = "Группа № 000";
            this.LNumberGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BSettings
            // 
            this.BSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSettings.BackColor = System.Drawing.Color.Ivory;
            this.BSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSettings.Image = global::ElipUser.Properties.Resources.settings20px;
            this.BSettings.Location = new System.Drawing.Point(548, 6);
            this.BSettings.Name = "BSettings";
            this.BSettings.Size = new System.Drawing.Size(30, 30);
            this.BSettings.TabIndex = 2;
            this.BSettings.UseVisualStyleBackColor = false;
            this.BSettings.Click += new System.EventHandler(this.BSettings_Click);
            // 
            // LUserInfo
            // 
            this.LUserInfo.AutoSize = true;
            this.LUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUserInfo.ForeColor = System.Drawing.Color.Black;
            this.LUserInfo.Location = new System.Drawing.Point(16, 13);
            this.LUserInfo.Name = "LUserInfo";
            this.LUserInfo.Size = new System.Drawing.Size(353, 16);
            this.LUserInfo.TabIndex = 1;
            this.LUserInfo.Text = "ID: 0 | Фамилия Имя Отчество | Роль: название";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.ImageList;
            this.TabControl.Location = new System.Drawing.Point(0, 43);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(590, 283);
            this.TabControl.TabIndex = 3;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(582, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи в группе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVUsers
            // 
            this.DGVUsers.AllowUserToAddRows = false;
            this.DGVUsers.AllowUserToDeleteRows = false;
            this.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUsers.Location = new System.Drawing.Point(3, 3);
            this.DGVUsers.Name = "DGVUsers";
            this.DGVUsers.ReadOnly = true;
            this.DGVUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUsers.Size = new System.Drawing.Size(576, 250);
            this.DGVUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVDataInGroup);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(582, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Лабораторные и тесты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVDataInGroup
            // 
            this.DGVDataInGroup.AllowUserToAddRows = false;
            this.DGVDataInGroup.AllowUserToDeleteRows = false;
            this.DGVDataInGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDataInGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDataInGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDataInGroup.Location = new System.Drawing.Point(3, 3);
            this.DGVDataInGroup.Name = "DGVDataInGroup";
            this.DGVDataInGroup.ReadOnly = true;
            this.DGVDataInGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDataInGroup.Size = new System.Drawing.Size(576, 216);
            this.DGVDataInGroup.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(576, 34);
            this.panel2.TabIndex = 1;
            // 
            // BStart
            // 
            this.BStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BStart.Image = global::ElipUser.Properties.Resources.pencil;
            this.BStart.Location = new System.Drawing.Point(247, 5);
            this.BStart.Name = "BStart";
            this.BStart.Size = new System.Drawing.Size(95, 29);
            this.BStart.TabIndex = 0;
            this.BStart.Text = "Выполнить";
            this.BStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BStart.UseVisualStyleBackColor = true;
            this.BStart.Click += new System.EventHandler(this.BStart_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVMyLabAndTest);
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(582, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мои результаты лабораторных и тестов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVMyLabAndTest
            // 
            this.DGVMyLabAndTest.AllowUserToAddRows = false;
            this.DGVMyLabAndTest.AllowUserToDeleteRows = false;
            this.DGVMyLabAndTest.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMyLabAndTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMyLabAndTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMyLabAndTest.Location = new System.Drawing.Point(3, 3);
            this.DGVMyLabAndTest.Name = "DGVMyLabAndTest";
            this.DGVMyLabAndTest.ReadOnly = true;
            this.DGVMyLabAndTest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMyLabAndTest.Size = new System.Drawing.Size(576, 250);
            this.DGVMyLabAndTest.TabIndex = 0;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "user.png");
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 326);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Пользователь] Электронные лабораторные по физике";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataInGroup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMyLabAndTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LUserInfo;
        private System.Windows.Forms.Button BSettings;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVDataInGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BStart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVMyLabAndTest;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Label LNumberGroup;
    }
}