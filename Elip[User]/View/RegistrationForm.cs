using ElipModel.Model;
using ElipModel.Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElipUser.View
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void BRegistration_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                List<User> checkLogin;
                using (var dbContext = new ElipContext())
                {
                    checkLogin = dbContext.Users.Where(u => u.Login.Equals(TBLogin.Text)).ToList();
                }
                if (checkLogin.Count != 0)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (var dbContext = new ElipContext())
                    {
                        var saveTeacher = new User
                        {
                            Login = TBLogin.Text,
                            Password = TBPassword.Text,
                            LastName = TBLastName.Text,
                            FirstName = TBFirstName.Text,
                            MiddleName = TBMiddleName.Text,
                            Role = "Преподаватель"
                        };
                        dbContext.Users.Add(saveTeacher);
                        dbContext.SaveChanges();
                    }
                    Hide();
                    MessageBox.Show("Сохранено", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Некоторые поля пусты!\r\nЗаполните все поля.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateData()
        {
            if (TBLogin.Text.Trim().Equals("") ||
            TBPassword.Text.Trim().Equals("") ||
            TBLastName.Text.Trim().Equals("") ||
            TBFirstName.Text.Trim().Equals(""))
            {
                return false;
            }
            return true;
        }

        private void BSeePass_Click(object sender, EventArgs e)
        {
            if (TBPassword.PasswordChar == '\0')
            {
                TBPassword.PasswordChar = '*';
                BSeePass.Image = Properties.Resources.eye;
                BSeePass.Refresh();
                return;
            }
            if (TBPassword.PasswordChar == '*')
            {
                TBPassword.PasswordChar = '\0';
                BSeePass.Image = Properties.Resources.eyehidden;
                BSeePass.Refresh();
                return;
            }
        }
    }
}
