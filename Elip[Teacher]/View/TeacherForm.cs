using ElipAdmin.Model;
using ElipAdmin.Model.Entity;
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

        private void InitHeaderLabel()
        {
            LUserInfo.Text = new StringBuilder()
                .Append("ID: ")
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

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }

        private void TVGroup_AfterSelect(object sender, TreeViewEventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                if (TabControl.SelectedIndex == 0)
                {
                    var group = dbContext.Groups.Find(int.Parse(TVGroup.SelectedNode.Name));
                    DGVUsers.DataSource = group.Users;
                    DGVUsers.Columns["GroupId"].Visible = false;
                    DGVUsers.Columns["Group"].Visible = false;
                    DGVUsers.Columns["DataInGroups"].Visible = false;
                    DGVUsers.Columns["Role"].Visible = false;
                    DGVUsers.Columns["Login"].Visible = false;
                    DGVUsers.Columns["Password"].Visible = false;
                }
                else
                if (TabControl.SelectedIndex == 1)
                {
                    var group = dbContext.Groups.Find(int.Parse(TVGroup.SelectedNode.Name));
                    DGVDataInGroup.DataSource = group.DataInGroups;
                    DGVDataInGroup.Columns["Group"].Visible = false;
                    DGVDataInGroup.Columns["User"].Visible = false;
                }
            }
        }

        private void BSettings_Click(object sender, System.EventArgs e)
        {
            new TeacherSettingsFrom().Show();
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            TVGroup_AfterSelect(TVGroup, null);
        }
    }
}
