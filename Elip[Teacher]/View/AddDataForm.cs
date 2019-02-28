using System;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddDataForm : Form
    {
        public AddDataForm(string str)
        {
            InitializeComponent();
            Text = str;
        }

        private void NUpDown_ValueChanged(object sender, EventArgs e)
        {
            LBQuestions.Items.Clear();
            for (int i = 1; i < NUpDown.Value + 1; i++)
            {
                LBQuestions.Items.Add("№ " + i);
            }

        }
    }
}
