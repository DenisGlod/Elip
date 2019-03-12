using ElipModel.Entity;
using ElipModel.Model;
using ElipModel.Model.Entity;
using ElipModel.Util;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddEditDataForm : Form
    {
        private Lab lab;
        private Test test;
        private TeacherForm teacherForm;
        private string method;
        private DataType dataType;

        private DataInGroup dataInGroup;

        public AddEditDataForm(TeacherForm form, DataType dataType, string method, DataInGroup dataInGroup)
        {
            InitializeComponent();
            teacherForm = form;
            this.method = method;
            this.dataType = dataType;
            switch (dataType)
            {
                case DataType.Lab:
                    LCount.Text = "Количество заданий:";
                    GBList.Text = "Список заданий";
                    GBData.Text = "Текст задания";
                    GBAnswer.Visible = false;
                    BSave.Text = "Сохранить лабораторную";
                    BSaveOneObj.Text = "Сохранить задание";
                    break;
                case DataType.Test:
                    LCount.Text = "Количество вопросов:";
                    GBList.Text = "Список вопросов";
                    GBData.Text = "Текст вопроса";
                    GBAnswer.Visible = true;
                    BSave.Text = "Сохранить тест";
                    BSaveOneObj.Text = "Сохранить вопрос";
                    break;
            }
            switch (method)
            {
                case "Add":
                    Text = "Добавление";
                    this.dataInGroup = new DataInGroup();
                    if (DataType.Lab == dataType) lab = new Lab();
                    else test = new Test();
                    break;
                case "Edit":
                    Text = "Редактирование";
                    this.dataInGroup = dataInGroup;
                    TBNameProject.Text = dataInGroup.Text;
                    if (dataInGroup.DataType.Equals(DataType.Lab.ToString()))
                    {
                        this.dataType = DataType.Lab;
                        lab = (Lab)Util.Deserialization(dataInGroup.Data);
                        NUpDown.Value = lab.TaskList.Count;
                    }
                    else
                    {
                        this.dataType = DataType.Test;
                        test = (Test)Util.Deserialization(dataInGroup.Data);
                        NUpDown.Value = test.QuestionsList.Count;
                    }
                    break;
            }
        }

        private void NUpDown_ValueChanged(object sender, EventArgs e)
        {
            TVQuestions.Nodes.Clear();
            for (int i = 1; i < NUpDown.Value + 1; i++)
            {
                TVQuestions.Nodes.Add(i.ToString(), "№ " + i);
            }
            switch (dataType)
            {
                case DataType.Lab:
                    while (lab.TaskList.Count > NUpDown.Value)
                    {
                        lab.TaskList.Remove(lab.TaskList.Count);
                    }
                    break;
                case DataType.Test:
                    while (test.QuestionsList.Count > NUpDown.Value)
                    {
                        test.QuestionsList.Remove(test.QuestionsList.Count);
                        test.AnswerList.Remove(test.AnswerList.Count);
                    }
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
                    RTBText.Text = str;
                    break;
                case DataType.Test:
                    test.QuestionsList.TryGetValue(key, out string value);
                    RTBText.Text = value;
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
        }

        private void BSaveOneObj_Click(object sender, EventArgs e)
        {
            switch (dataType)
            {
                case DataType.Lab:
                    var lkey = int.Parse(TVQuestions.SelectedNode.Name);
                    if (lab.TaskList.ContainsKey(lkey)) { lab.TaskList.Remove(lkey); }
                    lab.TaskList.Add(lkey, RTBText.Text);
                    break;
                case DataType.Test:
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
                dataInGroup.Text = TBNameProject.Text;
                dataInGroup.UserId = teacherForm.User.Id;
                dbContext.SaveChanges();
            }
            Hide();
            MessageBox.Show("Данные сохранены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            teacherForm.InitDGVMyLabAndTest();
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
