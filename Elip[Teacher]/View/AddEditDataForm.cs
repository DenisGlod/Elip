using ElipModel.Entity;
using ElipModel.Model;
using ElipModel.Model.Entity;
using ElipModel.Util;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AddEditDataForm : Form
    {
        private readonly Lab lab;
        private readonly Test test;
        private readonly TeacherForm teacherForm;
        private readonly string method;
        private readonly DataType dataType;

        private readonly DataInGroup dataInGroup;

        private readonly Result result;
        public AddEditDataForm(TeacherForm teacherForm, string method, Result result, string labName)
        {
            InitializeComponent();
            this.method = method;
            this.teacherForm = teacherForm;
            this.result = result;
            panel1.Visible = false;
            panel3.Visible = true;
            GBAnswer.Visible = false;
            GBAnswerLab.Visible = true;
            LCount.Text = "Количество заданий:";
            GBList.Text = "Список заданий";
            GBData.Text = "Текст задания";
            BSave.Text = "Сохранить";
            Text = "Проверка лабораторной работы";
            NUDMark.Value = (int)result.Mark;

            lab = (Lab)Util.Deserialization(result.AnswerData);
            NUpDown.Value = lab.TaskList.Count;
            TBNameLab.Text = labName;
            switch (result.Status)
            {
                case "Проверено":
                    CBStatus.SelectedIndex = 1;
                    break;
                case "Не проверено":
                    CBStatus.SelectedIndex = 0;
                    break;
            }
        }

        public AddEditDataForm(TeacherForm form, DataType dataType, string method, DataInGroup dataInGroup)
        {
            InitializeComponent();
            teacherForm = form;
            this.method = method;
            this.dataType = dataType;
            switch (dataType)
            {
                case DataType.Lab:
                    panel1.Visible = true;
                    panel3.Visible = false;
                    GBAnswer.Visible = false;
                    LCount.Text = "Количество заданий:";
                    GBList.Text = "Список заданий";
                    GBData.Text = "Текст задания";
                    BSave.Text = "Сохранить лабораторную";
                    BSaveOneObj.Text = "Сохранить задание";
                    break;
                case DataType.Test:
                    panel1.Visible = true;
                    panel3.Visible = false;
                    GBAnswer.Visible = true;
                    BAttachFiles.Visible = false;
                    LCount.Text = "Количество вопросов:";
                    GBList.Text = "Список вопросов";
                    GBData.Text = "Текст вопроса";
                    BSave.Text = "Сохранить тест";
                    BSaveOneObj.Text = "Сохранить вопрос";
                    break;
            }
            switch (method)
            {
                case "Add":

                    this.dataInGroup = new DataInGroup();
                    if (DataType.Lab == dataType)
                    {
                        Text = "Добавление лабораторной работы";
                        lab = new Lab();
                    }
                    else
                    {
                        Text = "Добавление теста";
                        test = new Test();
                    }
                    break;
                case "Edit":
                    this.dataInGroup = dataInGroup;
                    TBNameProject.Text = dataInGroup.Text;
                    if (dataInGroup.DataType.Equals(DataType.Lab.ToString()))
                    {
                        Text = "Редактирование лабораторной работы";
                        this.dataType = DataType.Lab;
                        lab = (Lab)Util.Deserialization(dataInGroup.Data);
                        NUpDown.Value = lab.TaskList.Count;
                    }
                    else
                    {
                        Text = "Редактирование теста";
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
                    if (method.Equals("Check"))
                    {
                        lab.AnswerTaskList.TryGetValue(key, out string strATL);
                        RTBAnswerText.Text = strATL;
                    }
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
                        dataInGroup.Text = TBNameProject.Text;
                        dataInGroup.UserId = teacherForm.User.Id;
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
                        dataInGroup.Text = TBNameProject.Text;
                        dataInGroup.UserId = teacherForm.User.Id;
                        break;
                    case "Check":
                        var saveResult = dbContext.Results.Find(result.Id);
                        saveResult.Mark = (int)NUDMark.Value;
                        saveResult.Status = CBStatus.SelectedItem.ToString();
                        break;
                }
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
            if (TVQuestions.SelectedNode != null)
            {
                TVQuestions.SelectedNode.BackColor = Color.Transparent;
                TVQuestions.SelectedNode.ForeColor = SystemColors.ControlText;
            }
        }

        private void BAttachFiles_Click(object sender, EventArgs e)
        {
            new AttachFilesForm(lab, method).Show();
        }
    }
}
