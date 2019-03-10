using ElipTeacher.Entity;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddDataForm : Form
    {
        private Lab lab;
        private Test test;
        private bool flag;
        public AddDataForm(string str, TeacherForm form, object data, bool flag)
        {
            InitializeComponent();
            Text = str;
            this.flag = flag;
            if (this.flag)
            {
                lab = (Lab)data;
                LCount.Text = "Количество заданий:";
                GBList.Text = "Список заданий";
                GBData.Text = "Текст задания";
                GBAnswer.Visible = false;
                BSave.Text = "Сохранить лабораторную";
                BSaveOneObj.Text = "Сохранить задание";
            }
            else
            {
                test = (Test)data;
                LCount.Text = "Количество вопросов:";
                GBList.Text = "Список вопросов";
                GBData.Text = "Текст вопроса";
                GBAnswer.Visible = true;
                BSave.Text = "Сохранить тест";
                BSaveOneObj.Text = "Сохранить вопрос";
            }
        }

        private void NUpDown_ValueChanged(object sender, EventArgs e)
        {
            TVQuestions.Nodes.Clear();
            for (int i = 1; i < NUpDown.Value + 1; i++)
            {
                TVQuestions.Nodes.Add(i.ToString(), "№ " + i);
            }
        }

        private void TVQuestions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (flag)
            {
                var lkey = int.Parse(TVQuestions.SelectedNode.Name);
                lab.TaskList.TryGetValue(lkey, out string str);
                RTBText.Text = str;
            }
            else
            {
                var tkey = int.Parse(TVQuestions.SelectedNode.Name);
                test.QuestionsList.TryGetValue(tkey, out string value);
                RTBText.Text = value;
                test.AnswerList.TryGetValue(tkey, out var list);
                if (list != null)
                {
                    foreach (var item in list)
                    {
                        switch (item.Number)
                        {
                            case 1:
                                RTB1.Text = item.Text;
                                CB1.Checked = item.Flag;
                                break;
                            case 2:
                                RTB2.Text = item.Text;
                                CB2.Checked = item.Flag;
                                break;
                            case 3:
                                RTB3.Text = item.Text;
                                CB3.Checked = item.Flag;
                                break;
                            case 4:
                                RTB4.Text = item.Text;
                                CB4.Checked = item.Flag;
                                break;
                        }
                    }
                }
            }
        }

        private void BSaveOneObj_Click(object sender, EventArgs e)
        {
            if (flag)
            {
                var lkey = int.Parse(TVQuestions.SelectedNode.Name);
                if (lab.TaskList.ContainsKey(lkey)) { lab.TaskList.Remove(lkey); }
                lab.TaskList.Add(lkey, RTBText.Text);
            }
            else
            {
                var tkey = int.Parse(TVQuestions.SelectedNode.Name);
                var value = RTBText.Text;
                if (test.QuestionsList.ContainsKey(tkey)) { test.QuestionsList.Remove(tkey); }
                test.QuestionsList.Add(tkey, value);
                if (test.AnswerList.ContainsKey(tkey)) { test.AnswerList.Remove(tkey); }
                test.AnswerList.Add(tkey, new List<Answer>
                    {
                        new Answer(1, RTB1.Text, CB1.Checked),
                        new Answer(2, RTB2.Text, CB2.Checked),
                        new Answer(3, RTB3.Text, CB3.Checked),
                        new Answer(4, RTB4.Text, CB4.Checked)
                    });
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            var tempLab = lab;
            var tempTest = test;
        }

        private void TVQuestions_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            RTBText.Clear();
            CB1.Checked = CB2.Checked = CB3.Checked = CB4.Checked = false;
            RTB1.Clear();
            RTB2.Clear();
            RTB3.Clear();
            RTB4.Clear();
        }
    }
}
