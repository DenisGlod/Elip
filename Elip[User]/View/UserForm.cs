using ElipAdmin.Model.Entity;
using System.Windows.Forms;

namespace ElipUser
{
    public partial class UserForm : Form
    {
        private User user;
        public UserForm(object user)
        {
            this.user = (User)user;
            InitializeComponent();
        }
    }
}
