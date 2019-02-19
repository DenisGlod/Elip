using ElipAdmin.Model.Entity;
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
        }

        private void TeacherForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new LoginForm().Show();
        }
    }
}
