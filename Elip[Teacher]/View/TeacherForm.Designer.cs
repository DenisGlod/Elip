namespace ElipTeacher.View
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BSettings = new System.Windows.Forms.Button();
            this.LUserInfo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TVGroup = new System.Windows.Forms.TreeView();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVUsers = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVDataInGroup = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataInGroup)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.BSettings);
            this.panel1.Controls.Add(this.LUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 43);
            this.panel1.TabIndex = 0;
            // 
            // BSettings
            // 
            this.BSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSettings.Image = global::ElipTeacher.Properties.Resources.settings20px;
            this.BSettings.Location = new System.Drawing.Point(569, 6);
            this.BSettings.Name = "BSettings";
            this.BSettings.Size = new System.Drawing.Size(30, 30);
            this.BSettings.TabIndex = 2;
            this.BSettings.UseVisualStyleBackColor = true;
            this.BSettings.Click += new System.EventHandler(this.BSettings_Click);
            // 
            // LUserInfo
            // 
            this.LUserInfo.AutoSize = true;
            this.LUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUserInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.LUserInfo.Location = new System.Drawing.Point(16, 13);
            this.LUserInfo.Name = "LUserInfo";
            this.LUserInfo.Size = new System.Drawing.Size(353, 16);
            this.LUserInfo.TabIndex = 1;
            this.LUserInfo.Text = "ID: 0 | Фамилия Имя Отчество | Роль: название";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TVGroup);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Группы";
            // 
            // TVGroup
            // 
            this.TVGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVGroup.Location = new System.Drawing.Point(3, 16);
            this.TVGroup.Name = "TVGroup";
            this.TVGroup.Size = new System.Drawing.Size(174, 264);
            this.TVGroup.TabIndex = 0;
            this.TVGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TVGroup_AfterSelect);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(180, 43);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 283);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(183, 43);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(428, 283);
            this.TabControl.TabIndex = 3;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(420, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Пользователи";
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
            this.DGVUsers.Size = new System.Drawing.Size(414, 251);
            this.DGVUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVDataInGroup);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(420, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Данные";
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
            this.DGVDataInGroup.Size = new System.Drawing.Size(414, 217);
            this.DGVDataInGroup.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 220);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 34);
            this.panel2.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(324, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 1;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(14, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 326);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TeacherForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[Преподаватель] Электронные лабораторные по физике";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TeacherForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.TabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataInGroup)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LUserInfo;
        private System.Windows.Forms.Button BSettings;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView TVGroup;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVUsers;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVDataInGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
    }
}