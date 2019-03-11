using System;
using System.Collections.Generic;

namespace ElipModel.Entity
{
    [Serializable]
    public class Test
    {
        public string TestName { get; set; }
        public Dictionary<int, string> QuestionsList { get; set; }
        public Dictionary<int, List<Answer>> AnswerList { get; set; }

        public Test()
        {
            QuestionsList = new Dictionary<int, string>();
            AnswerList = new Dictionary<int, List<Answer>>();
        }
    }

    [Serializable]
    public class Answer
    {
        public int Number { get; set; }
        public string Text { get; set; }
        public bool Flag { get; set; }

        public Answer(int number, string text, bool flag)
        {
            Number = number;
            Text = text;
            Flag = flag;
        }
    }
}
