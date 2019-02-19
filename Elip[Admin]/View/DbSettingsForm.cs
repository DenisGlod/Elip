using ElipAdmin.Model;
using ElipAdmin.Model.Entity;
using System;
using System.Windows.Forms;
using System.Xml;

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
                    dbContext.SaveChanges();

                    for (int i = 1; i < 11; i++)
                    {
                        var xDoc = new XmlDocument();
                        xDoc.LoadXml(Properties.Resources.lab);
                        var root = xDoc.DocumentElement;
                        var lab = root.GetElementsByTagName("lab").Item(0);
                        lab.Attributes.GetNamedItem("number").Value = i.ToString();
                        lab.Attributes.GetNamedItem("text").Value = "Название лабораторной";
                        var task = lab.FirstChild;
                        lab.RemoveChild(lab.FirstChild);
                        for (int j = 1; j < 6; j++)
                        {
                            var tempTask = task.Clone();
                            tempTask.Attributes.GetNamedItem("number").Value = j.ToString();
                            tempTask.Attributes.GetNamedItem("text").Value = "Текст задачи";
                            lab.AppendChild(tempTask);
                        }
                        var data = new DataInGroup
                        {
                            Text = "Лабораторная №" + i,
                            Data = xDoc.OuterXml,
                            DataType = DataType.Lab.ToString(),
                            GroupId = rnd.Next(1, 6)
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
