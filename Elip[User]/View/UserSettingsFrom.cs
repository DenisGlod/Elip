using ElipModel.Model;
using ElipModel.Model.Entity;
using System;
using System.Windows.Forms;

namespace ElipUser.View
{
    public partial class UserSettingsFrom : Form
    {
        private User user;
        private UserForm userForm;
        public UserSettingsFrom(UserForm userForm, object user)
        {
            this.user = (User)user;
            this.userForm = userForm;
            InitializeComponent();
            InitTextBox();
        }

        private void InitTextBox()
        {
            TBFirstName.Text = user.FirstName;
            TBLastName.Text = user.LastName;
            TBMiddleName.Text = user.MiddleName;
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                user = dbContext.Users.Find(user.Id);
                user.FirstName = TBFirstName.Text;
                user.LastName = TBLastName.Text;
                user.MiddleName = TBMiddleName.Text;
                if (!TBNewPass.Text.Trim().Equals(""))
                {
                    user.Password = TBNewPass.Text;

                }
                dbContext.SaveChanges();
            }
            Hide();
            MessageBox.Show("Сохранено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userForm.InitHeaderLabel();
        }
    }
}
