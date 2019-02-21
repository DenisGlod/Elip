using ElipAdmin.Model;
using ElipAdmin.Model.Entity;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddDataInGroupForm : Form
    {
        private User user;
        public AddDataInGroupForm(object user)
        {
            this.user = (User)user;
            InitializeComponent();
            InitDGVMyData();
        }

        private void InitDGVMyData()
        {
            using (var dbContext = new ElipContext())
            {
                var myDataList = dbContext.Users.Attach(user).DataInGroups;
                DGVMyData.DataSource = myDataList;
                DGVMyData.Columns["Group"].Visible = false;
                DGVMyData.Columns["User"].Visible = false;
                DGVMyData.Columns["Data"].Visible = false;
            }
        }

        private void BAdd_Click(object sender, System.EventArgs e)
        {
            var key = (int)DGVMyData.SelectedCells[0].Value;
            using (var dbContext = new ElipContext())
            {

            }
        }
    }
}
