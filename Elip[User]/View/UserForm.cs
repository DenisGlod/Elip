using ElipModel.Model;
using ElipModel.Model.Entity;
using ElipModel.Util;
using System.Text;
using System.Windows.Forms;

namespace ElipUser.View
{
    public partial class UserForm : Form
    {
        private User user;
        public UserForm(object user)
        {
            this.user = (User)user;
            InitializeComponent();
            InitHeaderLabel();
            InitDGVMyResultLabAndTest();
            InitUserInGroup();
            InitLabAndTestInGroup();
        }

        private void InitDGVMyResultLabAndTest()
        {
            
        }

        private void InitLabAndTestInGroup()
        {
            using (var dbContext = new ElipContext())
            {
                var group = dbContext.Groups.Find(user.GroupId);
                var dataInGroup = group.DataInGroups;
                DGVLabAndTest.DataSource = dataInGroup;
                DGVLabAndTest.Columns["Text"].HeaderText = "Название работы";
                DGVLabAndTest.Columns["DataType"].HeaderText = "Тип работы";
                DGVLabAndTest.Columns["UserId"].Visible = false;
                DGVLabAndTest.Columns["Group"].Visible = false;
                DGVLabAndTest.Columns["GroupId"].Visible = false;
                DGVLabAndTest.Columns["User"].Visible = false;
                DGVLabAndTest.Columns["Data"].Visible = false;
            }
        }

        private void InitUserInGroup()
        {
            using (var dbContext = new ElipContext())
            {
                dbContext.Users.Attach(user);
                var userList = user.Group.Users;
                DGVUsers.DataSource = userList;
                DGVUsers.Columns["LastName"].HeaderText = "Фамилия";
                DGVUsers.Columns["FirstName"].HeaderText = "Имя";
                DGVUsers.Columns["MiddleName"].HeaderText = "Отчество";
                DGVUsers.Columns["Id"].Visible = false;
                DGVUsers.Columns["GroupId"].Visible = false;
                DGVUsers.Columns["Group"].Visible = false;
                DGVUsers.Columns["DataInGroups"].Visible = false;
                DGVUsers.Columns["Role"].Visible = false;
                DGVUsers.Columns["Login"].Visible = false;
                DGVUsers.Columns["Password"].Visible = false;
            }
        }

        public void InitHeaderLabel()
        {
            using (var dbContext = new ElipContext())
            {
                user = dbContext.Users.Find(user.Id);
                LUserInfo.Text = new StringBuilder()
                .Append("Id: ")
                .Append(user.Id)
                .Append(" | ")
                .Append(user.LastName)
                .Append(" ")
                .Append(user.FirstName)
                .Append(" ")
                .Append(user.MiddleName)
                .Append(" | Роль: ")
                .Append(user.Role).ToString();
                LNumberGroup.Text = "Группа № " + user.Group.NumberGroup;
            }
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }

        private void BSettings_Click(object sender, System.EventArgs e)
        {
            new UserSettingsFrom(this, user).Show();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void BStart_Click(object sender, System.EventArgs e)
        {
            DataInGroup dataInGroup;
            using (var dbContext = new ElipContext())
            {
                dataInGroup = dbContext.DataInGroups.Find((int)DGVLabAndTest.SelectedCells[0].Value);
            }
            if (dataInGroup.DataType.Equals(DataType.Lab.ToString()))
            {
                new CompletingOfTheWorkForm(this, DataType.Lab, dataInGroup, user).Show();
            }
            else
            {
                new CompletingOfTheWorkForm(this, DataType.Test, dataInGroup, user).Show();
            }

        }
    }
}
