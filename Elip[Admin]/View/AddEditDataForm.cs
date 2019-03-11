using ElipModel.Model;
using ElipModel.Model.Entity;
using System.Data.Entity;
using System.Windows.Forms;

namespace ElipAdmin.View
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
            RTBData.Text = data.Data.ToString();
            TBGroupId.Text = data.GroupId.ToString();
            TBUserId.Text = data.UserId.ToString();
        }

        private void BSave_Click(object sender, System.EventArgs e)
        {
            /*if (flag)
            {
                DataInGroup saveData = new DataInGroup
                {
                    Text = TBText.Text,
                    Data = RTBData.Text.,
                    DataType = CBDataType.SelectedItem.ToString()
                };
                ValidateUserAndGroupId(saveData);
                using (var dbContext = new ElipContext())
                {
                    dbContext.DataInGroups.Add(saveData);
                    dbContext.SaveChanges();
                }
            }
            else
            {
                data.Text = TBText.Text;
                data.Data = RTBData.Text;
                data.DataType = CBDataType.SelectedItem.ToString();
                ValidateUserAndGroupId(data);
                using (var dbContext = new ElipContext())
                {
                    dbContext.Entry(data).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
            }*/
            Hide();
            MessageBox.Show("Сохранено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            adminForm.InitDataInGroupTable();
        }

        private void ValidateUserAndGroupId(DataInGroup data)
        {
            if (TBGroupId.Text.Trim().Equals(""))
            {
                data.GroupId = null;
            }
            else
            if (TBUserId.Text.Trim().Equals(""))
            {
                data.UserId = null;
            }
            else
            {
                data.GroupId = int.Parse(TBGroupId.Text);
                data.UserId = int.Parse(TBUserId.Text);
            }
        }

        private void ValidateKey(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

    }
}
