using System;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddDataForm : Form
    {
        public AddDataForm()
        {
            InitializeComponent();
        }

        private void NUpDown_ValueChanged(object sender, EventArgs e)
        {
            var count = NUpDown.Value + 1;
            TabControl.TabPages.Clear();
            for (int i = 1; i < count; i++)
            {
                var tp = new TabPage
                {
                    Text = "Задание № " + i,
                    UseVisualStyleBackColor = true
                };
                switch (CBDataType.SelectedIndex)
                {
                    case 0:
                        var rtb = new RichTextBox
                        {
                            Dock = DockStyle.Fill
                        };
                        tp.Controls.Add(rtb);
                        break;
                    case 1:
                        var gb = new GroupBox
                        {
                            Text = "Варианты ответов:",
                            Dock = DockStyle.Bottom,
                            Height = 100,
                            AutoSize = true
                        };
                        var rtb1 = new RichTextBox
                        {
                            Dock = DockStyle.Fill
                        };
                        var tb = new TextBox();
                        gb.Controls.Add(tb);
                        gb.Controls.Add(tb);
                        gb.Controls.Add(tb);
                        tp.Controls.Add(gb);
                        tp.Controls.Add(rtb1);
                        break;
                }
                TabControl.TabPages.Add(tp);
            }
        }
    }
}
