using Elip.Model;
using Elip.Model.Entity;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Elip.View
{
    public partial class AdminForm : Form
    {
        private User user;
        public AdminForm(object user)
        {
            this.user = (User)user;
            InitializeComponent();
            InitHeaderLabel();
            InitUserTable();
        }

        public void InitUserTable()
        {
            using (var dbContext = new ElipContext())
            {
                dbContext.Users.Load();
                DGVUserTable.DataSource = null;
                DGVUserTable.DataSource = dbContext.Users.Local.ToBindingList();
                DGVUserTable.Columns["Group"].Visible = false;
                DGVUserTable.Columns["DataInGroups"].Visible = false;
            }
        }

        public void InitGroupTable()
        {
            using (var dbContext = new ElipContext())
            {
                dbContext.Groups.Load();
                DGVGroupTable.DataSource = null;
                DGVGroupTable.DataSource = dbContext.Groups.Local.ToBindingList();
                DGVGroupTable.Columns["Users"].Visible = false;
                DGVGroupTable.Columns["DataInGroups"].Visible = false;
            }
        }

        private void InitDataInGroupTable()
        {
            using (var dbContext = new ElipContext())
            {
                dbContext.DataInGroups.Load();
                DGVDataTable.DataSource = null;
                DGVDataTable.DataSource = dbContext.DataInGroups.Local.ToBindingList();
                DGVDataTable.Columns["Group"].Visible = false;
                DGVDataTable.Columns["User"].Visible = false;
            }
        }

        private void InitHeaderLabel()
        {
            LUserInfo.Text = new StringBuilder().Append(user.LastName).Append(" ").Append(user.FirstName).Append(" ").Append(user.MiddleName).Append(" | Роль: ").Append(user.Role).ToString();
        }

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    InitUserTable();
                    break;
                case 1:
                    InitGroupTable();
                    break;
                case 2:
                    InitDataInGroupTable();
                    break;
            }

        }

        private void BAdd_Click(object sender, System.EventArgs e)
        {
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    new AddEditUserForm(this, null, true).Show();
                    break;
                case 1:
                    new AddEditGroupForm(this, null, true).Show();
                    break;
                case 2:
                    new AddEditDataForm(this, null, true).Show();
                    break;
            }
        }

        private void BEdit_Click(object sender, System.EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                switch (TabControl.SelectedIndex)
                {
                    case 0:
                        var user = dbContext.Users.Find((int)DGVUserTable.SelectedCells[0].Value);
                        new AddEditUserForm(this, user, false).Show();
                        break;
                    case 1:
                        var group = dbContext.Groups.Find((int)DGVGroupTable.SelectedCells[0].Value);
                        new AddEditGroupForm(this, group, false).Show();
                        break;
                    case 2:
                        var data = dbContext.DataInGroups.Find((int)DGVDataTable.SelectedCells[0].Value);
                        new AddEditDataForm(this, data, false).Show();
                        break;
                }
            }
        }

        private void BDelete_Click(object sender, System.EventArgs e)
        {
            var result = MessageBox.Show("Подтвердить удаление?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (result == DialogResult.OK)
            {
                using (var dbContext = new ElipContext())
                {
                    switch (TabControl.SelectedIndex)
                    {
                        case 0:
                            foreach (DataGridViewRow row in DGVUserTable.SelectedRows)
                            {
                                var delUser = dbContext.Users.Find((int)row.Cells[0].Value);
                                dbContext.Users.Remove(delUser);
                                dbContext.SaveChanges();
                            }
                            InitUserTable();
                            break;
                        case 1:
                            foreach (DataGridViewRow row in DGVGroupTable.SelectedRows)
                            {
                                var delGroup = dbContext.Groups.Find((int)row.Cells[0].Value);
                                dbContext.Entry(delGroup).Collection("Users").Load();
                                delGroup.Users.ToList().ForEach(u => { u.Group = null; u.GroupId = null; });
                                dbContext.SaveChanges();
                                dbContext.Entry(delGroup).Collection("DataInGroups").Load();
                                delGroup.DataInGroups.ToList().ForEach(dg => { dg.Group = null; dg.GroupId = null; });
                                dbContext.SaveChanges();
                                dbContext.Groups.Remove(delGroup);
                                dbContext.SaveChanges();
                            }
                            InitGroupTable();
                            break;
                        case 2:
                            foreach (DataGridViewRow row in DGVDataTable.SelectedRows)
                            {
                                var delData = dbContext.DataInGroups.Find((int)row.Cells[0].Value);
                                dbContext.DataInGroups.Remove(delData);
                                dbContext.SaveChanges();
                            }
                            InitDataInGroupTable();
                            break;
                    }
                }
            }
        }
    }
}
