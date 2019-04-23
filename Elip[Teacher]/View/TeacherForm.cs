using ElipModel.Model;
using ElipModel.Model.Entity;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class TeacherForm : Form
    {
        public User User { get; set; }
        public TeacherForm(object user)
        {
            User = (User)user;
            InitializeComponent();
            InitHeaderLabel();
            InitTVGroup();
            InitDGVMyLabAndTest();
        }

        public void InitDGVMyLabAndTest()
        {
            using (var dbContext = new ElipContext())
            {
                var list = dbContext.DataInGroups.Where(dig => dig.UserId == User.Id).Select(s => new
                {
                    s.Id,
                    s.Text,
                    s.DataType,
                    s.Group.NumberGroup
                }).ToList();
                if (list.Count >= 0)
                {
                    DGVMyLabAndTest.DataSource = list;
                    DGVMyLabAndTest.Columns["Text"].HeaderText = "Название работы";
                    DGVMyLabAndTest.Columns["DataType"].HeaderText = "Тип работы";
                    DGVMyLabAndTest.Columns["NumberGroup"].HeaderText = "№ класса";
                }
            }
        }

        private void InitTVGroup()
        {
            using (var dbContext = new ElipContext())
            {
                var groups = dbContext.Groups.ToList();
                foreach (var item in groups)
                {
                    TVGroup.Nodes.Add(item.Id.ToString(), "Id:" + item.Id + "| № " + item.NumberGroup);
                }
            }
        }

        public void InitHeaderLabel()
        {
            using (var dbContext = new ElipContext())
            {
                User = dbContext.Users.Find(User.Id);
                LUserInfo.Text = new StringBuilder()
                .Append("Id: ")
                .Append(User.Id)
                .Append(" | ")
                .Append(User.LastName)
                .Append(" ")
                .Append(User.FirstName)
                .Append(" ")
                .Append(User.MiddleName)
                .Append(" | Роль: ")
                .Append(User.Role).ToString();
            }
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }

        private void TVGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (!BAddDataInGroup.Enabled && !BDeleteDataInGroup.Enabled)
            {
                BAddDataInGroup.Enabled = true;
                BDeleteDataInGroup.Enabled = true;
            }
            TVGroup.SelectedNode.BackColor = SystemColors.Highlight;
            TVGroup.SelectedNode.ForeColor = Color.White;
            using (var dbContext = new ElipContext())
            {
                var group = dbContext.Groups.Find(int.Parse(TVGroup.SelectedNode.Name));
                switch (TabControl.SelectedIndex)
                {
                    case 0:
                        var ulist = group.Users.Select(u => new
                        {
                            u.Id,
                            u.LastName,
                            u.FirstName,
                            u.MiddleName
                        }).ToList();
                        if (ulist.Count >= 0)
                        {
                            DGVUsers.DataSource = ulist;
                            DGVUsers.Columns["LastName"].HeaderText = "Фамилия";
                            DGVUsers.Columns["FirstName"].HeaderText = "Имя";
                            DGVUsers.Columns["MiddleName"].HeaderText = "Отчество";
                        }
                        break;
                    case 1:
                        var diglist = group.DataInGroups.Select(dig => new
                        {
                            dig.Id,
                            dig.Text,
                            dig.DataType,
                            author = dig.User.LastName + " " + dig.User.FirstName + " " + dig.User.MiddleName
                        }).ToList();
                        if (diglist.Count >= 0)
                        {
                            DGVDataInGroup.DataSource = diglist;
                            DGVDataInGroup.Columns["Text"].HeaderText = "Название работы";
                            DGVDataInGroup.Columns["DataType"].HeaderText = "Тип работы";
                            DGVDataInGroup.Columns["author"].HeaderText = "Автор работы";
                        }
                        break;
                    case 3:
                        var resList = group.Results.Select(r => new
                        {
                            r.Id,
                            dataType = r.DataInGroup.DataType,
                            text = r.DataInGroup.Text,
                            r.DateTimeResult,
                            user = r.User.LastName + " " + r.User.FirstName + " " + r.User.MiddleName,
                            r.Mark,
                            r.Status
                        }).ToList();
                        if (resList.Count >= 0)
                        {
                            DGVResultData.DataSource = resList;
                            DGVResultData.Columns["dataType"].HeaderText = "Тип работы";
                            DGVResultData.Columns["text"].HeaderText = "Название работы";
                            DGVResultData.Columns["DateTimeResult"].HeaderText = "Дата/время";
                            DGVResultData.Columns["user"].HeaderText = "Пользователь";
                            DGVResultData.Columns["Mark"].HeaderText = "Оценка";
                            DGVResultData.Columns["Status"].HeaderText = "Статус проверки";
                        }
                        break;
                }
            }
        }

        private void BSettings_Click(object sender, System.EventArgs e)
        {
            new TeacherSettingsFrom(this, User).Show();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                InitDGVMyLabAndTest();
                return;
            }
            if (TVGroup.SelectedNode != null)
            {
                TVGroup_AfterSelect(TVGroup, null);
            }
        }
        public void RefreshDGVDataInGroup()
        {
            TabControl_Selected(null, null);
        }

        private void BAddDataInGroup_Click(object sender, System.EventArgs e)
        {
            new AddDataInGroupForm(this, User, int.Parse(TVGroup.SelectedNode.Name)).Show();
        }

        private void TVGroup_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (TVGroup.SelectedNode != null)
            {
                TVGroup.SelectedNode.BackColor = Color.Transparent;
                TVGroup.SelectedNode.ForeColor = SystemColors.ControlText;
            }
        }

        private void BDeleteDataInGroup_Click(object sender, System.EventArgs e)
        {
            if (DGVDataInGroup.SelectedRows.Count == 0) { return; }
            var result = MessageBox.Show("Подтверждаете удаление данных из класса?", "Вопрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using (var dbContext = new ElipContext())
                {
                    foreach (DataGridViewRow item in DGVDataInGroup.SelectedRows)
                    {
                        var data = dbContext.DataInGroups.Find((int)item.Cells[0].Value);
                        data.GroupId = null;
                        dbContext.SaveChanges();
                    }
                }
                RefreshDGVDataInGroup();
            }
        }

        private void BDelete_Click(object sender, System.EventArgs e)
        {
            if (DGVMyLabAndTest.SelectedRows.Count == 0) { return; }
            var result = MessageBox.Show("Подтверждаете удаление?", "Удаление", MessageBoxButtons.OKCancel, MessageBoxIcon.Hand);
            if (result == DialogResult.OK)
            {
                using (var dbContext = new ElipContext())
                {
                    var removeList = new List<DataInGroup>();
                    foreach (DataGridViewRow item in DGVMyLabAndTest.SelectedRows)
                    {
                        removeList.Add(dbContext.DataInGroups.Find((int)item.Cells[0].Value));
                    }
                    dbContext.DataInGroups.RemoveRange(removeList);
                    dbContext.SaveChanges();
                }
                InitDGVMyLabAndTest();
            }
        }

        private void BAdd_Click(object sender, System.EventArgs e)
        {
            new BeforeForm(this).Show();
        }

        private void BEdit_Click(object sender, System.EventArgs e)
        {
            if (DGVMyLabAndTest.SelectedRows.Count == 0) { return; }
            DataInGroup dataInGroup;
            using (var dbContext = new ElipContext())
            {
                dataInGroup = dbContext.DataInGroups.Find((int)DGVMyLabAndTest.SelectedCells[0].Value);
            }
            if (dataInGroup.DataType.Equals(DataType.Lab.ToString()))
            {
                new AddEditDataForm(this, DataType.Lab, "Edit", dataInGroup).Show();
            }
            else
            {
                new AddEditDataForm(this, DataType.Test, "Edit", dataInGroup).Show();
            }
        }

        private void DGVResultData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DGVResultData.SelectedCells[1].Value.Equals("Lab"))
            {
                using (var dbContext = new ElipContext())
                {
                    var resultData = dbContext.Results.Find(DGVResultData.SelectedCells[0].Value);
                    var labName = DGVResultData.SelectedCells[2].Value.ToString();
                    new AddEditDataForm(this, "Check", resultData, labName).Show();
                }
            }
        }
    }
}
