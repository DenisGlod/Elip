using Elip.Model;
using Elip.Model.Entity;
using System.Windows.Forms;

namespace Elip.View
{
    public partial class AddEditDataForm : Form
    {
        private DataInGroup data;
        private bool flag;
        private AdminForm adminForm;

        public AddEditDataForm(AdminForm form, object data, bool flag)
        {
            this.data = (DataInGroup)data;
            this.flag = flag;
            adminForm = form;
            InitializeComponent();
            if (flag) { Text = "Добавление"; }
            else { Text = "Редактирование"; InitTextBox(); }
        }

        private void InitTextBox()
        {
            if (data.DataType.Equals(DataType.Lab.ToString()))
            {
                CBDataType.SelectedIndex = 0;
            }
            else
            {
                CBDataType.SelectedIndex = 1;
            }
            TBText.Text = data.Text;
            RTBData.Text = data.Data;
            TBGroupId.Text = data.GroupId.ToString();
            TBUserId.Text = data.UserId.ToString();
        }

        private void BSave_Click(object sender, System.EventArgs e)
        {
            if (flag)
            {
                DataInGroup saveData = new DataInGroup
                {
                    Text = TBText.Text,
                    Data = RTBData.Text,
                    DataType = CBDataType.SelectedItem.ToString(),
                    GroupId = int.Parse(TBGroupId.Text),
                    UserId = int.Parse(TBUserId.Text),
                };
                using (var dbContext = new ElipContext())
                {
                    dbContext.DataInGroups.Add(saveData);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                /*group.NumberGroup = TBGroup.Text;
                using (var dbContext = new ElipContext())
                {
                    dbContext.Entry(group).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }*/
            }
            Hide();
            MessageBox.Show("Сохранено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminForm.InitGroupTable();
        }
    }
}
