using Elip.Model;
using Elip.Model.Entity;
using System.Data.Entity;
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
    }
}
