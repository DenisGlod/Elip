using ElipModel.Model.Entity;
using System;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class BeforeForm : Form
    {
        private TeacherForm teacherForm;
        public BeforeForm(TeacherForm teacherForm)
        {
            InitializeComponent();
            this.teacherForm = teacherForm;
            RBLab.Checked = true;
        }

        private void BOpenAddEditDataForm_Click(object sender, EventArgs e)
        {
            if (RBLab.Checked)
            {
                Hide();
                new AddEditDataForm(teacherForm, DataType.Lab, "Add", null).Show();
            }
            else
            {
                Hide();
                new AddEditDataForm(teacherForm, DataType.Test, "Add", null).Show();
            }
        }
    }
}
