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
        private Lab lab, resultLab;
        private Test test, resultTest;
        private UserForm userForm;
        private DataInGroup dataInGroup;
        private DataType dataType;
        private User user;

        public CompletingOfTheWorkForm(UserForm userForm, DataType dataType, DataInGroup dataInGroup, User user)
        {
            InitializeComponent();
            this.userForm = userForm;
            this.dataType = dataType;
            this.dataInGroup = dataInGroup;
            this.user = user;
            Text = dataInGroup.Text;

            switch (dataType)
            {
                case DataType.Lab:
                    resultLab = new Lab();
                    lab = (Lab)Util.Deserialization(dataInGroup.Data);
                    foreach (var item in lab.TaskList)
                    {
                        TVQuestions.Nodes.Add(item.Key.ToString(), "№ " + item.Key); //item.Value
                    }
                    GBAnswerLab.Visible = true;
                    GBAnswerTest.Visible = false;
                    break;
                case DataType.Test:
                    resultTest = new Test();
                    test = (Test)Util.Deserialization(dataInGroup.Data);
                    foreach (var item in test.QuestionsList)
                    {
                        TVQuestions.Nodes.Add(item.Key.ToString(), "№ " + item.Key);
                    }
                    GBAnswerLab.Visible = false;
                    GBAnswerTest.Visible = true;
                    break;
            }
        }

        private void TVQuestions_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var key = int.Parse(TVQuestions.SelectedNode.Name);
            switch (dataType)
            {
                case DataType.Lab:
                    lab.TaskList.TryGetValue(key, out string str);
                    RTBQuestion.Text = str;
                    resultLab.AnswerTaskList.TryGetValue(key, out string ansStr);
                    RTBAnswerText.Text = ansStr;
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
                                    break;
                                case 2:
                                    RTB2.Text = item.Text;
                                    break;
                                case 3:
                                    RTB3.Text = item.Text;
                                    break;
                                case 4:
                                    RTB4.Text = item.Text;
                                    break;
                            }
                        }
                    }
                    resultTest.AnswerList.TryGetValue(key, out var rlist);
                    if (rlist != null)
                    {
                        foreach (var item in rlist)
                        {
                            switch (item.Number)
                            {
                                case 1:
                                    CB1.Checked = item.Flag;
                                    break;
                                case 2:
                                    CB2.Checked = item.Flag;
                                    break;
                                case 3:
                                    CB3.Checked = item.Flag;
                                    break;
                                case 4:
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

        private void BSave_Click(object sender, EventArgs e)
        {
            using (var dbContext = new ElipContext())
            {
                var result = new Result
                {
                    UserId = user.Id,
                    DateTimeResult = DateTime.Now,
                    DataInGroupId = dataInGroup.Id,
                    GroupId = user.GroupId,
                };
                switch (dataType)
                {
                    case DataType.Lab:
                        result.AnswerData = Util.Serializatoin(resultLab);
                        result.Status = "Не проверено";
                        break;
                    case DataType.Test:
                        result.AnswerData = Util.Serializatoin(resultTest);
                        result.Status = "Проверено";
                        var tempR = resultTest.AnswerList;
                        var temp = test.AnswerList;
                        int mark = 0;
                        for (int i = 1; i <= temp.Count; i++)
                        {
                            temp.TryGetValue(i, out var tempAnswer);
                            tempR.TryGetValue(i, out var tempRAnswer);
                            if (tempAnswer[0].Flag == tempRAnswer[0].Flag &&
                                tempAnswer[1].Flag == tempRAnswer[1].Flag &&
                                tempAnswer[2].Flag == tempRAnswer[2].Flag &&
                                tempAnswer[3].Flag == tempRAnswer[3].Flag)
                            {
                                mark += 1;
                            }
                        }
                        result.Mark = 10 * mark / temp.Count;
                        break;
                }
                dbContext.Results.Add(result);
                dbContext.SaveChanges();
            }
            Hide();
            MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            userForm.InitDGVResultLabAndTest();
        }

        private void TVQuestions_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            RTBQuestion.Clear();
            CB1.Checked = CB2.Checked = CB3.Checked = CB4.Checked = false;
            RTB1.Clear();
            RTB2.Clear();
            RTB3.Clear();
            RTB4.Clear();
            RTBAnswerText.Clear();
            if (TVQuestions.SelectedNode != null)
            {
                TVQuestions.SelectedNode.BackColor = Color.Transparent;
                TVQuestions.SelectedNode.ForeColor = SystemColors.ControlText;
            }
        }

        private void BSaveAnswerLab_Click(object sender, EventArgs e)
        {
            if (TVQuestions.SelectedNode == null)
            {
                MessageBox.Show("Ошибка, не выбран вопрос из списка вопросов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var lkey = int.Parse(TVQuestions.SelectedNode.Name);
                if (resultLab.TaskList.ContainsKey(lkey)) { resultLab.TaskList.Remove(lkey); }
                resultLab.TaskList.Add(lkey, RTBQuestion.Text);
                if (resultLab.AnswerTaskList.ContainsKey(lkey)) { resultLab.AnswerTaskList.Remove(lkey); }
                resultLab.AnswerTaskList.Add(lkey, RTBAnswerText.Text);
            }
        }

        private void BSaveAnswerTest_Click(object sender, EventArgs e)
        {
            if (TVQuestions.SelectedNode == null)
            {
                MessageBox.Show("Ошибка, не выбран вопрос из списка вопросов!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var tkey = int.Parse(TVQuestions.SelectedNode.Name);
                var value = RTBQuestion.Text;
                if (resultTest.QuestionsList.ContainsKey(tkey)) { resultTest.QuestionsList.Remove(tkey); }
                resultTest.QuestionsList.Add(tkey, value);
                if (resultTest.AnswerList.ContainsKey(tkey)) { resultTest.AnswerList.Remove(tkey); }
                resultTest.AnswerList.Add(tkey, new List<Answer>
                {
                    new Answer(1, RTB1.Text, CB1.Checked),
                    new Answer(2, RTB2.Text, CB2.Checked),
                    new Answer(3, RTB3.Text, CB3.Checked),
                    new Answer(4, RTB4.Text, CB4.Checked)
                });
            }
        }
    }
}
