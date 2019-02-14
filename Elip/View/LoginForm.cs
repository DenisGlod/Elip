using Elip.Model;
using Elip.View;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Xml;

namespace Elip
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void BDbSetting_Click(object sender, EventArgs e)
        {
            new DbSettingsForm().ShowDialog();
        }

        private void BLogin_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                if (!dbContext.Database.Exists())
                {
                    MessageBox.Show("База данных не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var user = dbContext.Users.Where(u => u.Login.Equals(TBLogin.Text) && u.Password.Equals(TBPassword.Text));
                    if (user.Count() == 0)
                    {
                        MessageBox.Show("Неверный логин/пароль либо\r\nтакого пользователя не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        new AdminForm(user.First()).Show();
                        Hide();
                    }
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
