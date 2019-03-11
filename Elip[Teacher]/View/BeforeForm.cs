using ElipModel.Entity;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class BeforeForm : Form
    {
        private TeacherForm teacherForm;
        public BeforeForm(TeacherForm form)
        {
            teacherForm = form;
            InitializeComponent();
            RBLab.Checked = true;
        }

        private void BOk_Click(object sender, System.EventArgs e)
        {
            if (TBText.Text.Trim().Equals(""))
            {
                MessageBox.Show("Не неуказано название работы.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (RBLab.Checked)
            {
                var lab = new Lab
                {
                    LabName = TBText.Text
                };
                Hide();
                new AddDataForm("Добавление лабораторной работы", teacherForm, lab, true).Show();
            }
            else if (RBTest.Checked)
            {
                var test = new Test
                {
                    TestName = TBText.Text
                };
                Hide();
                new AddDataForm("Добавление теста", teacherForm, test, false).Show();
            }

        }
    }
}
