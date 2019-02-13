namespace Elip.View
{
    partial class DbSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbSettingsForm));
            this.BCreateDb = new System.Windows.Forms.Button();
            this.BDeleteDb = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BCreateDb
            // 
            this.BCreateDb.Image = global::Elip.Properties.Resources.createdb;
            this.BCreateDb.Location = new System.Drawing.Point(41, 12);
            this.BCreateDb.Name = "BCreateDb";
            this.BCreateDb.Size = new System.Drawing.Size(139, 46);
            this.BCreateDb.TabIndex = 0;
            this.BCreateDb.Text = "Создать БД";
            this.BCreateDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BCreateDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BCreateDb.UseVisualStyleBackColor = true;
            this.BCreateDb.Click += new System.EventHandler(this.BCreateDb_Click);
            // 
            // BDeleteDb
            // 
            this.BDeleteDb.Image = global::Elip.Properties.Resources.deletedb;
            this.BDeleteDb.Location = new System.Drawing.Point(41, 79);
            this.BDeleteDb.Name = "BDeleteDb";
            this.BDeleteDb.Size = new System.Drawing.Size(139, 46);
            this.BDeleteDb.TabIndex = 1;
            this.BDeleteDb.Text = "Удалить БД";
            this.BDeleteDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BDeleteDb.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BDeleteDb.UseVisualStyleBackColor = true;
            this.BDeleteDb.Click += new System.EventHandler(this.BDeleteDb_Click);
            // 
            // DbSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 137);
            this.Controls.Add(this.BDeleteDb);
            this.Controls.Add(this.BCreateDb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DbSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BCreateDb;
        private System.Windows.Forms.Button BDeleteDb;
    }
}