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

        }
    }
}
