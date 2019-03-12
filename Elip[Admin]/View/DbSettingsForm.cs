using ElipModel.Entity;
using ElipModel.Model;
using ElipModel.Model.Entity;
using ElipModel.Util;
using System;
using System.Windows.Forms;

namespace ElipAdmin.View
{
    public partial class DbSettingsForm : Form
    {
        public DbSettingsForm()
        {
            InitializeComponent();
        }

        private void BCreateDb_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                if (dbContext.Database.Exists())
                {
                    MessageBox.Show("База данных существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dbContext.Database.Create();

                    var rnd = new Random();
                    for (int i = 0; i < 6; i++)
                    {
                        var group = new Group { NumberGroup = rnd.Next(1000, 5000).ToString() };
                        dbContext.Groups.Add(group);
                    }
                    dbContext.SaveChanges();

                    var admin = new User
                    {
                        Login = "Admin",
                        Password = "1234",
                        LastName = "Перов",
                        FirstName = "Иван",
                        MiddleName = "Иванович",
                        Role = "Администратор"
                    };
                    dbContext.Users.Add(admin);
                    for (int i = 0; i < 8; i++)
                    {
                        var user = new User
                        {
                            Login = "user" + i,
                            Password = "user" + i,
                            LastName = "user" + i,
                            FirstName = "user" + i,
                            MiddleName = "user" + i,
                            Role = "Пользователь",
                            GroupId = rnd.Next(1, 6)
                        };
                        dbContext.Users.Add(user);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        var teacher = new User
                        {
                            Login = "teacher" + i,
                            Password = "teacher" + i,
                            LastName = "teacher" + i,
                            FirstName = "teacher" + i,
                            MiddleName = "teacher" + i,
                            Role = "Преподаватель",
                        };
                        dbContext.Users.Add(teacher);
                    }
                    dbContext.SaveChanges();

                    for (int i = 1; i < 11; i++)
                    {
                        var lab = new Lab
                        {
                            LabName = "Лабораторная №" + i
                        };
                        lab.TaskList.Add(1, "Task 1");
                        lab.TaskList.Add(2, "Task 2");
                        lab.TaskList.Add(3, "Task 3");
                        lab.TaskList.Add(4, "Task 4");
                        var data = new DataInGroup
                        {
                            Text = "Лабораторная №" + i,
                            DataType = DataType.Lab.ToString(),
                            GroupId = rnd.Next(1, 6),
                            Data = Util.Serializatoin(lab),
                            UserId = rnd.Next(10, 14)
                        };
                        dbContext.DataInGroups.Add(data);
                    }
                    dbContext.SaveChanges();

                    MessageBox.Show("База данных создана", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void BDeleteDb_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                if (!dbContext.Database.Exists())
                {
                    MessageBox.Show("База данных не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dbContext.DeleteDataBase();
                    MessageBox.Show("База данных удалена", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
