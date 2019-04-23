using ElipModel.Model;
using ElipModel.Model.Entity;
using System.Linq;
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
            InitDGVUserInGroup();
        }

        public void InitDGVResultLabAndTest()
        {
            using (var dbContext = new ElipContext())
            {
                var resList = dbContext.Users.Find(user.Id).Results.Select(r => new
                {
                    r.Id,
                    text = r.DataInGroup.Text,
                    dataType = r.DataInGroup.DataType,
                    r.DateTimeResult,
                    r.Mark,
                    r.Status
                }).ToList();
                if (resList.Count >= 0)
                {
                    DGVResultLabAndTest.DataSource = resList;
                    DGVResultLabAndTest.Columns["text"].HeaderText = "Название работы";
                    DGVResultLabAndTest.Columns["dataType"].HeaderText = "Тип работы";
                    DGVResultLabAndTest.Columns["DateTimeResult"].HeaderText = "Дата/время";
                    DGVResultLabAndTest.Columns["Mark"].HeaderText = "Оценка";
                    DGVResultLabAndTest.Columns["Status"].HeaderText = "Статус проверки";
                }
            }
        }

        private void InitDGVLabAndTest()
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

        private void InitDGVUserInGroup()
        {
            using (var dbContext = new ElipContext())
            {
                dbContext.Users.Attach(user);
                var ulist = user.Group.Users.Select(u => new
                {
                    u.Id,
                    u.LastName,
                    u.FirstName,
                    u.MiddleName
                }).ToList();
                if (ulist.Count > 0)
                {
                    DGVUsers.DataSource = ulist;
                    DGVUsers.Columns["LastName"].HeaderText = "Фамилия";
                    DGVUsers.Columns["FirstName"].HeaderText = "Имя";
                    DGVUsers.Columns["MiddleName"].HeaderText = "Отчество";
                }
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
                LNumberGroup.Text = "Класс № " + user.Group.NumberGroup;
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
            switch (TabControl.SelectedIndex)
            {
                case 0:
                    InitDGVUserInGroup();
                    break;
                case 1:
                    InitDGVLabAndTest();
                    break;
                case 2:
                    InitDGVResultLabAndTest();
                    break;
            }
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
