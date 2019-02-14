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

        private void InitUserTable()
        {
            using (var dbContext = new ElipContext())
            {
                dbContext.Users.Load();
                DGVUserTable.DataSource = null;
                DGVUserTable.DataSource = dbContext.Users.Local.ToBindingList();
                DGVUserTable.Columns["Group"].Visible = false;
            }
        }

        private void InitGroupTable()
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
            using (var dbContext = new ElipContext())
            {
                switch (TabControl.SelectedIndex)
                {
                    case 0:
                        new AddEditUserForm(null, true).ShowDialog();
                        break;
                    case 1:
                        break;
                    case 2:
                        break;
                }
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
                        new AddEditUserForm(user, false).ShowDialog();
                        break;
                    case 1:
                        break;
                    case 2:
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
                                delGroup.Users.ToList().ForEach(u => u.GroupId = null);
                                delGroup.DataInGroups.ToList().ForEach(g => g.GroupId = null);
                                dbContext.SaveChanges();
                                dbContext.Groups.Remove(delGroup);
                                dbContext.SaveChanges();
                            }
                            InitGroupTable();
                            break;
                        case 2:
                            break;
                    }
                }
            }
        }
    }
}
