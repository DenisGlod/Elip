using ElipModel.Model.Entity;
using System;
using System.Windows.Forms;

namespace ElipAdmin.View
{
    public partial class BeforeForm : Form
    {
        private AdminForm adminForm;
        private User user;

        public BeforeForm(AdminForm adminForm, User user)
        {
            InitializeComponent();
            this.user = user;
            this.adminForm = adminForm;
            RBLab.Checked = true;
        }

        private void BOpenAddEditDataForm_Click(object sender, EventArgs e)
        {
            if (RBLab.Checked)
            {
                Hide();
                new AddEditDataForm(adminForm, DataType.Lab, "Add", null, user).Show();
            }
            else
            {
                Hide();
                new AddEditDataForm(adminForm, DataType.Test, "Add", null, user).Show();
            }
        }
    }
}
