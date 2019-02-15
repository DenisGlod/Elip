using Elip.Model;
using Elip.Model.Entity;
using System.Data.Entity;
using System.Windows.Forms;

namespace Elip.View
{
    public partial class AddEditUserForm : Form
    {
        private User user;
        private bool flag;
        private AdminForm adminForm;

        public AddEditUserForm(AdminForm adminForm, object user, bool flag)
        {
            this.user = (User)user;
            this.flag = flag;
            this.adminForm = adminForm;
            InitializeComponent();
            if (flag) { Text = "Добавление"; }
            else { Text = "Редактирование"; InitTextBox(); }
        }

        private void InitTextBox()
        {
            TBId.Text = user.Id.ToString();
            TBLogin.Text = user.Login;
            TBPassword.Text = user.Password;
            TBLastName.Text = user.LastName;
            TBFirstName.Text = user.FirstName;
            TBMiddleName.Text = user.MiddleName;
            TBIdGroup.Text = user.GroupId.ToString();
            switch (user.Role)
            {
                case "Администратор":
                    CBRole.SelectedIndex = 0;
                    break;
                case "Преподаватель":
                    CBRole.SelectedIndex = 1;
                    break;
                case "Пользователь":
                    CBRole.SelectedIndex = 2;
                    break;
            }
        }

        private void BSave_Click(object sender, System.EventArgs e)
        {
            if (flag)
            {
                User user = new User
                {
                    Login = TBLogin.Text,
                    Password = TBPassword.Text,
                    LastName = TBLastName.Text,
                    FirstName = TBFirstName.Text,
                    MiddleName = TBMiddleName.Text,
                    Role = CBRole.SelectedItem.ToString()
                };
                if (!TBId.Text.Trim().Equals("")) { user.Id = int.Parse(TBId.Text); }
                if (!TBIdGroup.Text.Trim().Equals("")) { user.GroupId = int.Parse(TBIdGroup.Text); }
                using (var dbContext = new ElipContext())
                {
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                user.Id = int.Parse(TBId.Text);
                if (!TBIdGroup.Text.Trim().Equals(""))
                {
                    user.GroupId = int.Parse(TBIdGroup.Text);
                }
                else
                {
                    user.GroupId = null;
                    user.Group = null;
                }

                user.Login = TBLogin.Text;
                user.Password = TBPassword.Text;
                user.LastName = TBLastName.Text;
                user.FirstName = TBFirstName.Text;
                user.MiddleName = TBMiddleName.Text;
                user.Role = CBRole.SelectedItem.ToString();
                using (var dbContext = new ElipContext())
                {
                    dbContext.Entry(user).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
            Hide();
            MessageBox.Show("Сохранено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminForm.InitUserTable();
        }

        private void TBIdGroup_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKey(e);
        }

        private void TBId_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidateKey(e);
        }

        private void ValidateKey(KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }


    }
}
