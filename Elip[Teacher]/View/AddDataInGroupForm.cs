using ElipModel.Model;
using ElipModel.Model.Entity;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddDataInGroupForm : Form
    {
        private User user;
        private int groupId;
        private TeacherForm teacherForm;
        public AddDataInGroupForm(TeacherForm teacherForm, object user, int groupId)
        {
            this.user = (User)user;
            this.groupId = groupId;
            this.teacherForm = teacherForm;
            InitializeComponent();
            InitDGVMyData();
        }

        private void InitDGVMyData()
        {
            using (var dbContext = new ElipContext())
            {
                var myDataList = dbContext.Users.Find(user.Id).DataInGroups;
                DGVMyData.DataSource = myDataList;
                DGVMyData.Columns["Text"].HeaderText = "Название работы";
                DGVMyData.Columns["DataType"].HeaderText = "Тип работы";
                DGVMyData.Columns["GroupId"].HeaderText = "Id Группы";
                DGVMyData.Columns["Group"].Visible = false;
                DGVMyData.Columns["User"].Visible = false;
                DGVMyData.Columns["UserId"].Visible = false;
                DGVMyData.Columns["Data"].Visible = false;
            }
        }

        private void BAdd_Click(object sender, System.EventArgs e)
        {
            var key = (int)DGVMyData.SelectedCells[0].Value;
            using (var dbContext = new ElipContext())
            {
                var data = dbContext.DataInGroups.Find(key);
                data.GroupId = groupId;
                dbContext.SaveChanges();
            }
            Hide();
            MessageBox.Show("Сохранено!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            teacherForm.RefreshDGVDataInGroup();
        }
    }
}
