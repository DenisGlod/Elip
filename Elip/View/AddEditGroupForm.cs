using ElipAdmin.Model;
using ElipAdmin.Model.Entity;
using System.Data.Entity;
using System.Windows.Forms;

namespace ElipAdmin.View
{
    public partial class AddEditGroupForm : Form
    {
        private Group group;
        private bool flag;
        private AdminForm adminForm;

        public AddEditGroupForm(AdminForm form, object group, bool flag)
        {
            this.group = (Group)group;
            this.flag = flag;
            adminForm = form;
            InitializeComponent();
            if (flag) { Text = "Добавление"; }
            else { Text = "Редактирование"; InitTextBox(); }
        }

        private void InitTextBox()
        {
            TBGroup.Text = group.NumberGroup;
        }

        private void BSave_Click(object sender, System.EventArgs e)
        {
            if (flag)
            {
                Group saveGroup = new Group { NumberGroup = TBGroup.Text };
                using (var dbContext = new ElipContext())
                {
                    dbContext.Groups.Add(saveGroup);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                group.NumberGroup = TBGroup.Text;
                using (var dbContext = new ElipContext())
                {
                    dbContext.Entry(group).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }
            Hide();
            MessageBox.Show("Сохранено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminForm.InitGroupTable();
        }
    }
}
