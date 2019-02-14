using Elip.Model.Entity;
using System.Windows.Forms;

namespace Elip.View
{
    public partial class AddEditUserForm : Form
    {
        private User user;
        private bool flag;
        public AddEditUserForm(object user, bool flag)
        {
            this.user = (User)user;
            this.flag = flag;
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
    }
}
