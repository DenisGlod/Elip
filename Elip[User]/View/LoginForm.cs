﻿using ElipModel.Model;
using ElipUser.View;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ElipUser
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            using (ElipContext dbContext = new ElipContext())
            {
                if (!dbContext.Database.Exists())
                {
                    MessageBox.Show("База данных не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var user = dbContext.Users.Where(u => u.Login.Equals(TBLogin.Text) && u.Password.Equals(TBPassword.Text) && u.Role.Equals("Пользователь"));
                    if (user.Count() == 0)
                    {
                        MessageBox.Show("Неверный логин/пароль либо\r\nтакого пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        new UserForm(user.First()).Show();
                        Hide();
                    }
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BRegistration_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
        }
    }
}
