namespace Elip.View
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LUserInfo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BDelete = new System.Windows.Forms.Button();
            this.BEdit = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVDataTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DGVGroupTable = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGVUserTable = new System.Windows.Forms.DataGridView();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroupTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).BeginInit();
            this.TabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MistyRose;
            this.panel1.Controls.Add(this.LUserInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(821, 48);
            this.panel1.TabIndex = 0;
            // 
            // LUserInfo
            // 
            this.LUserInfo.AutoSize = true;
            this.LUserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LUserInfo.ForeColor = System.Drawing.Color.DarkRed;
            this.LUserInfo.Location = new System.Drawing.Point(24, 14);
            this.LUserInfo.Name = "LUserInfo";
            this.LUserInfo.Size = new System.Drawing.Size(336, 18);
            this.LUserInfo.TabIndex = 0;
            this.LUserInfo.Text = "Фамилия Имя Отчество | Роль: название";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.BDelete);
            this.panel2.Controls.Add(this.BEdit);
            this.panel2.Controls.Add(this.BAdd);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(821, 40);
            this.panel2.TabIndex = 4;
            // 
            // BDelete
            // 
            this.BDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BDelete.Image = global::Elip.Properties.Resources.trash;
            this.BDelete.Location = new System.Drawing.Point(664, 5);
            this.BDelete.Name = "BDelete";
            this.BDelete.Size = new System.Drawing.Size(125, 32);
            this.BDelete.TabIndex = 2;
            this.BDelete.Text = "Удалить";
            this.BDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDelete.UseVisualStyleBackColor = true;
            this.BDelete.Click += new System.EventHandler(this.BDelete_Click);
            // 
            // BEdit
            // 
            this.BEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BEdit.Image = global::Elip.Properties.Resources.pencil;
            this.BEdit.Location = new System.Drawing.Point(337, 5);
            this.BEdit.Name = "BEdit";
            this.BEdit.Size = new System.Drawing.Size(141, 32);
            this.BEdit.TabIndex = 1;
            this.BEdit.Text = "Редактировать";
            this.BEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BEdit.UseVisualStyleBackColor = true;
            this.BEdit.Click += new System.EventHandler(this.BEdit_Click);
            // 
            // BAdd
            // 
            this.BAdd.Image = global::Elip.Properties.Resources.plus;
            this.BAdd.Location = new System.Drawing.Point(27, 5);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(118, 32);
            this.BAdd.TabIndex = 0;
            this.BAdd.Text = "Добавить";
            this.BAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVDataTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(813, 365);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Данные";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVDataTable
            // 
            this.DGVDataTable.AllowUserToAddRows = false;
            this.DGVDataTable.AllowUserToDeleteRows = false;
            this.DGVDataTable.AllowUserToResizeRows = false;
            this.DGVDataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVDataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVDataTable.Location = new System.Drawing.Point(0, 0);
            this.DGVDataTable.Name = "DGVDataTable";
            this.DGVDataTable.ReadOnly = true;
            this.DGVDataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVDataTable.Size = new System.Drawing.Size(813, 365);
            this.DGVDataTable.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVGroupTable);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(813, 365);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Группы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DGVGroupTable
            // 
            this.DGVGroupTable.AllowUserToAddRows = false;
            this.DGVGroupTable.AllowUserToDeleteRows = false;
            this.DGVGroupTable.AllowUserToResizeRows = false;
            this.DGVGroupTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVGroupTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVGroupTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVGroupTable.Location = new System.Drawing.Point(0, 0);
            this.DGVGroupTable.Name = "DGVGroupTable";
            this.DGVGroupTable.ReadOnly = true;
            this.DGVGroupTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVGroupTable.Size = new System.Drawing.Size(813, 365);
            this.DGVGroupTable.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVUserTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(813, 365);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Пользователи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGVUserTable
            // 
            this.DGVUserTable.AllowUserToAddRows = false;
            this.DGVUserTable.AllowUserToDeleteRows = false;
            this.DGVUserTable.AllowUserToResizeRows = false;
            this.DGVUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVUserTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVUserTable.Location = new System.Drawing.Point(0, 0);
            this.DGVUserTable.Name = "DGVUserTable";
            this.DGVUserTable.ReadOnly = true;
            this.DGVUserTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVUserTable.Size = new System.Drawing.Size(813, 365);
            this.DGVUserTable.TabIndex = 1;
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.tabPage1);
            this.TabControl.Controls.Add(this.tabPage2);
            this.TabControl.Controls.Add(this.tabPage3);
            this.TabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl.Location = new System.Drawing.Point(0, 48);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(821, 391);
            this.TabControl.TabIndex = 1;
            this.TabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 479);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Электронные лабораторные по физике";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVDataTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVGroupTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVUserTable)).EndInit();
            this.TabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LUserInfo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BDelete;
        private System.Windows.Forms.Button BEdit;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVDataTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DGVGroupTable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVUserTable;
        private System.Windows.Forms.TabControl TabControl;
    }
}