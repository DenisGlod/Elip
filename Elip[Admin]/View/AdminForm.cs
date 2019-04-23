using ElipModel.Model;
using ElipModel.Model.Entity;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElipAdmin.View
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
                DGVUserTable.DataSource = null;
                var list = dbContext.Users.Select(u => new
                {
                    u.Id,
                    u.Login,
                    u.Password,
                    u.LastName,
                    u.FirstName,
                    u.MiddleName,
                    u.Role,
                    u.Group.NumberGroup
                }).ToList();
                if (list.Count >= 0)
                {
                    DGVUserTable.DataSource = list;
                    DGVUserTable.Columns["Login"].HeaderText = "Логин";
                    DGVUserTable.Columns["Password"].HeaderText = "Пароль";
                    DGVUserTable.Columns["LastName"].HeaderText = "Фамилия";
                    DGVUserTable.Columns["FirstName"].HeaderText = "Имя";
                    DGVUserTable.Columns["MiddleName"].HeaderText = "Отчество";
                    DGVUserTable.Columns["Role"].HeaderText = "Роль";
                    DGVUserTable.Columns["NumberGroup"].HeaderText = "№ класса";
                }
            }
        }

        public void InitGroupTable()
        {
            using (var dbContext = new ElipContext())
            {
                DGVGroupTable.DataSource = null;
                var list = dbContext.Groups.Select(g => new
                {
                    g.Id,
                    g.NumberGroup
                }).ToList();
                if (list.Count >= 0)
                {
                    DGVGroupTable.DataSource = list;
                    DGVGroupTable.Columns["NumberGroup"].HeaderText = "№ класса";
                }
            }
        }

        public void InitDataInGroupTable()
        {
            using (var dbContext = new ElipContext())
            {
                DGVDataTable.DataSource = null;
                var list = dbContext.DataInGroups.Select(dig => new
                {
                    dig.Id,
                    dig.Text,
                    dig.DataType,
                    dig.Group.NumberGroup,
                    author = dig.User.LastName + " " + dig.User.FirstName + " " + dig.User.MiddleName,
                }).ToList();
                if (list.Count >= 0)
                {
                    DGVDataTable.DataSource = list;
                    DGVDataTable.Columns["Text"].HeaderText = "Название работы";
                    DGVDataTable.Columns["DataType"].HeaderText = "Тип работы";
                    DGVDataTable.Columns["NumberGroup"].HeaderText = "№ класса";
                    DGVDataTable.Columns["author"].HeaderText = "Автор работы";
                }

            }
        }

        public void InitResultTable()
        {
            using (var dbContext = new ElipContext())
            {
                DGVResults.DataSource = null;
                var list = dbContext.Results.Select(r => new
                {
                    r.Id,
                    r.DataInGroup.Text,
                    r.DataInGroup.DataType,
                    r.DateTimeResult,
                    r.Mark,
                    r.DataInGroup.Group.NumberGroup,
                    r.Status,
                    user = r.User.LastName + " " + r.User.FirstName + " " + r.User.MiddleName,
                    author = r.DataInGroup.User.LastName + " " + r.DataInGroup.User.FirstName + " " + r.DataInGroup.User.MiddleName,
                }).ToList();
                if (list.Count >= 0)
                {
                    DGVResults.DataSource = list;
                    DGVResults.Columns["Text"].HeaderText = "Название работы";
                    DGVResults.Columns["DataType"].HeaderText = "Тип работы";
                    DGVResults.Columns["DateTimeResult"].HeaderText = "Дата и время решения";
                    DGVResults.Columns["NumberGroup"].HeaderText = "№ класса";
                    DGVResults.Columns["Mark"].HeaderText = "Оценка";
                    DGVResults.Columns["Status"].HeaderText = "Статус проверки";
                    DGVResults.Columns["user"].HeaderText = "Исполнитель работы";
                    DGVResults.Columns["author"].HeaderText = "Автор работы";
                }
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
                    panel2.Visible = true;
                    break;
                case 1:
                    InitGroupTable();
                    panel2.Visible = true;
                    break;
                case 2:
                    InitDataInGroupTable();
                    panel2.Visible = true;
                    break;
                case 3:
                    InitResultTable();
                    panel2.Visible = false;
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
                    new BeforeForm(this, user).Show();
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
                        if (data.DataType.Equals(DataType.Lab.ToString()))
                        {
                            new AddEditDataForm(this, DataType.Lab, "Edit", data, this.user).Show();
                        }
                        else
                        {
                            new AddEditDataForm(this, DataType.Test, "Edit", data, this.user).Show();
                        }
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
                                delUser.Results.Clear();
                                delUser.DataInGroups.Clear();
                                dbContext.Users.Remove(delUser);
                                dbContext.SaveChanges();
                            }
                            InitUserTable();
                            break;
                        case 1:
                            foreach (DataGridViewRow row in DGVGroupTable.SelectedRows)
                            {
                                var delGroup = dbContext.Groups.Find((int)row.Cells[0].Value);
                                delGroup.Users.Clear();
                                delGroup.DataInGroups.Clear();
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
                        case 3:
                            foreach (DataGridViewRow row in DGVResults.SelectedRows)
                            {
                                var delData = dbContext.Results.Find((int)row.Cells[0].Value);
                                dbContext.Results.Remove(delData);
                                dbContext.SaveChanges();
                            }
                            break;
                    }
                }
            }
        }
    }
}
