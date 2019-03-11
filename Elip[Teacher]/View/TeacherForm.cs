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
        private User user;
        public TeacherForm(object user)
        {
            this.user = (User)user;
            InitializeComponent();
            InitHeaderLabel();
            InitTVGroup();
            InitDGVMyLabAndTest();
        }

        private void InitDGVMyLabAndTest()
        {
            using (var dbContext = new ElipContext())
            {
                var myDataList = dbContext.Users.Find(user.Id).DataInGroups;
                DGVMyLabAndTest.DataSource = myDataList;
                DGVMyLabAndTest.Columns["Group"].Visible = false;
                DGVMyLabAndTest.Columns["User"].Visible = false;
                DGVMyLabAndTest.Columns["UserId"].Visible = false;
                DGVMyLabAndTest.Columns["Data"].Visible = false;
            }
        }

        private void InitTVGroup()
        {
            using (var dbContext = new ElipContext())
            {
                var groups = dbContext.Groups.ToList();
                foreach (var item in groups)
                {
                    TVGroup.Nodes.Add(item.Id.ToString(), item.NumberGroup);
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
                        DGVUsers.DataSource = group.Users;
                        DGVUsers.Columns["GroupId"].Visible = false;
                        DGVUsers.Columns["Group"].Visible = false;
                        DGVUsers.Columns["DataInGroups"].Visible = false;
                        DGVUsers.Columns["Role"].Visible = false;
                        DGVUsers.Columns["Login"].Visible = false;
                        DGVUsers.Columns["Password"].Visible = false;
                        break;
                    case 1:
                        DGVDataInGroup.DataSource = group.DataInGroups;
                        DGVDataInGroup.Columns["Group"].Visible = false;
                        DGVDataInGroup.Columns["GroupId"].Visible = false;
                        DGVDataInGroup.Columns["User"].Visible = false;
                        DGVDataInGroup.Columns["Data"].Visible = false;
                        break;
                }
            }
        }

        private void BSettings_Click(object sender, System.EventArgs e)
        {
            new TeacherSettingsFrom(this, user).Show();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (TabControl.SelectedIndex == 2)
            {
                InitDGVMyLabAndTest();
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
            new AddDataInGroupForm(this, user, int.Parse(TVGroup.SelectedNode.Name)).Show();
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
            var result = MessageBox.Show("Подтверждаете удаление из группы?", "Вопрос", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
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
            Hide();
            new AddDataForm("Редактирование", this, dataInGroup, true).Show();
        }
    }
}
