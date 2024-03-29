﻿namespace ElipTeacher.View
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
            this.components = new System.ComponentModel.Container();
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
            this.BDeleteDataInGroup = new System.Windows.Forms.Button();
            this.BAddDataInGroup = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVMyLabAndTest = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BDelete = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.DGVResultData = new System.Windows.Forms.DataGridView();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUsers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataInGroup)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMyLabAndTest)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVResultData)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(775, 43);
            this.panel1.TabIndex = 0;
            // 
            // BSettings
            // 
            this.BSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSettings.Image = global::ElipTeacher.Properties.Resources.settings20px;
            this.BSettings.Location = new System.Drawing.Point(733, 6);
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
            this.groupBox1.Text = "Классы";
            // 
            // TVGroup
            // 
            this.TVGroup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TVGroup.Location = new System.Drawing.Point(3, 16);
            this.TVGroup.Name = "TVGroup";
            this.TVGroup.Size = new System.Drawing.Size(174, 264);
            this.TVGroup.TabIndex = 0;
            this.TVGroup.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TVGroup_BeforeSelect);
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
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Controls.Add(this.tabPage4);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.ImageList = this.ImageList;
            this.TabControl.Location = new System.Drawing.Point(183, 43);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(592, 283);
            this.TabControl.TabIndex = 3;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVUsers);
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 256);
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
            this.DGVUsers.Size = new System.Drawing.Size(578, 250);
            this.DGVUsers.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVDataInGroup);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 256);
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
            this.DGVDataInGroup.Size = new System.Drawing.Size(578, 216);
            this.DGVDataInGroup.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BDeleteDataInGroup);
            this.panel2.Controls.Add(this.BAddDataInGroup);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 219);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(578, 34);
            this.panel2.TabIndex = 1;
            // 
            // BDeleteDataInGroup
            // 
            this.BDeleteDataInGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BDeleteDataInGroup.Enabled = false;
            this.BDeleteDataInGroup.Image = global::ElipTeacher.Properties.Resources.output;
            this.BDeleteDataInGroup.Location = new System.Drawing.Point(459, 5);
            this.BDeleteDataInGroup.Name = "BDeleteDataInGroup";
            this.BDeleteDataInGroup.Size = new System.Drawing.Size(105, 29);
            this.BDeleteDataInGroup.TabIndex = 1;
            this.BDeleteDataInGroup.Text = "Удалить";
            this.BDeleteDataInGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDeleteDataInGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDeleteDataInGroup.UseVisualStyleBackColor = true;
            this.BDeleteDataInGroup.Click += new System.EventHandler(this.BDeleteDataInGroup_Click);
            // 
            // BAddDataInGroup
            // 
            this.BAddDataInGroup.Enabled = false;
            this.BAddDataInGroup.Image = global::ElipTeacher.Properties.Resources.input;
            this.BAddDataInGroup.Location = new System.Drawing.Point(13, 5);
            this.BAddDataInGroup.Name = "BAddDataInGroup";
            this.BAddDataInGroup.Size = new System.Drawing.Size(104, 29);
            this.BAddDataInGroup.TabIndex = 0;
            this.BAddDataInGroup.Text = "Добавить";
            this.BAddDataInGroup.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAddDataInGroup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAddDataInGroup.UseVisualStyleBackColor = true;
            this.BAddDataInGroup.Click += new System.EventHandler(this.BAddDataInGroup_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVMyLabAndTest);
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.ImageIndex = 0;
            this.tabPage3.Location = new System.Drawing.Point(4, 23);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(584, 256);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Мои лабораторные и тесты";
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
            this.DGVMyLabAndTest.Size = new System.Drawing.Size(578, 216);
            this.DGVMyLabAndTest.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BDelete);
            this.panel3.Controls.Add(this.BEdit);
            this.panel3.Controls.Add(this.BAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 219);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(578, 34);
            this.panel3.TabIndex = 1;
            // 
            // BDelete
            // 
            this.BDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BDelete.Image = global::ElipTeacher.Properties.Resources.trash;
            this.BDelete.Location = new System.Drawing.Point(479, 8);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(87, 23);
            this.BDelete.TabIndex = 2;
            this.BDelete.Text = "Удалить";
            this.BDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BEdit
            // 
            this.BEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BEdit.Image = global::ElipTeacher.Properties.Resources.pencil;
            this.BEdit.Location = new System.Drawing.Point(237, 8);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(115, 23);
            this.BEdit.TabIndex = 1;
            this.BEdit.Text = "Редактировать";
            this.BEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BAdd
            // 
            this.BAdd.Image = global::ElipTeacher.Properties.Resources.plus;
            this.BAdd.Location = new System.Drawing.Point(11, 8);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(87, 23);
            this.BAdd.TabIndex = 0;
            this.BAdd.Text = "Добавить";
            this.BAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.DGVResultData);
            this.tabPage4.Location = new System.Drawing.Point(4, 23);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(584, 256);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Проверка лабораторных/тестов";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // DGVResultData
            // 
            this.DGVResultData.AllowUserToAddRows = false;
            this.DGVResultData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVResultData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVResultData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVResultData.Location = new System.Drawing.Point(3, 3);
            this.DGVResultData.MultiSelect = false;
            this.DGVResultData.Name = "DGVResultData";
            this.DGVResultData.ReadOnly = true;
            this.DGVResultData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVResultData.Size = new System.Drawing.Size(578, 250);
            this.DGVResultData.TabIndex = 0;
            this.DGVResultData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVResultData_CellClick);
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "user.png");
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 326);
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
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMyLabAndTest)).EndInit();
            this.panel3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVResultData)).EndInit();
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
        private System.Windows.Forms.Button BAddDataInGroup;
        private System.Windows.Forms.Button BDeleteDataInGroup;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVMyLabAndTest;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView DGVResultData;
    }
}