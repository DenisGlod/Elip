using ElipModel.Entity;
using ElipModel.Model;
using ElipModel.Model.Entity;
using ElipModel.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ElipUser.View
{
    public partial class CompletingOfTheWorkForm : Form
    {
        private Lab lab;
        private Test test;
        private UserForm userForm;
        private string method;
        private DataType dataType;

        private DataInGroup dataInGroup;

        public CompletingOfTheWorkForm()
        {
            InitializeComponent();
        }

        private void TVQuestions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var key = int.Parse(TVQuestions.SelectedNode.Name);
            switch (dataType)
            {
                case DataType.Lab:
                    lab.TaskList.TryGetValue(key, out string str);
                    RTBQuestion.Text = str;
                    break;
                case DataType.Test:
                    test.QuestionsList.TryGetValue(key, out string value);
                    RTBQuestion.Text = value;
                    test.AnswerList.TryGetValue(key, out var list);
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
                    break;
            }
            if (TVQuestions.SelectedNode != null)
            {
                TVQuestions.SelectedNode.BackColor = SystemColors.Highlight;
                TVQuestions.SelectedNode.ForeColor = Color.White;
            }
        }

        private void BSaveOneObj_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case DataType.Lab:
                    var lkey = int.Parse(TVQuestions.SelectedNode.Name);
                    if (lab.TaskList.ContainsKey(lkey)) { lab.TaskList.Remove(lkey); }
                    lab.TaskList.Add(lkey, RTBQuestion.Text);
                    break;
                case DataType.Test:
                    var tkey = int.Parse(TVQuestions.SelectedNode.Name);
                    var value = RTBQuestion.Text;
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
                    break;
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                switch (method)
                {
                    case "Add":
                        if (dataType == DataType.Lab)
                        {
                            dataInGroup.DataType = DataType.Lab.ToString();
                            dataInGroup.Data = Util.Serializatoin(lab);
                        }
                        else
                        {
                            dataInGroup.DataType = DataType.Test.ToString();
                            dataInGroup.Data = Util.Serializatoin(test);
                        }
                        dbContext.DataInGroups.Add(dataInGroup);
                        break;
                    case "Edit":
                        if (dataType == DataType.Lab)
                        {
                            dbContext.DataInGroups.Attach(dataInGroup);
                            dataInGroup.Data = Util.Serializatoin(lab);
                        }
                        else
                        {
                            dbContext.DataInGroups.Attach(dataInGroup);
                            dataInGroup.Data = Util.Serializatoin(test);
                        }
                        break;
                }
                //dataInGroup.Text = TBNameProject.Text;
                //dataInGroup.UserId = userForm.User.Id;
                dbContext.SaveChanges();
            }
            Hide();
            MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //userForm.InitDGVMyLabAndTest();
        }

        private void TVQuestions_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            RTBQuestion.Clear();
            CB1.Checked = CB2.Checked = CB3.Checked = CB4.Checked = false;
            RTB1.Clear();
            RTB2.Clear();
            RTB3.Clear();
            RTB4.Clear();
            if (TVQuestions.SelectedNode != null)
            {
                TVQuestions.SelectedNode.BackColor = Color.Transparent;
                TVQuestions.SelectedNode.ForeColor = SystemColors.ControlText;
            }
        }
    }
}
