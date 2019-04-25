using System;
using System.Collections.Generic;

namespace ElipModel.Entity
{
    [Serializable]
    public class Lab
    {
        public string LabName { get; set; }
        public Dictionary<int, string> TaskList { get; set; }
        public Dictionary<int, string> AnswerTaskList { get; set; }

        public List<string> FileNameList { get; set; }
        public List<byte[]> FileList { get; set; }

        public Lab()
        {
            FileNameList = new List<string>();
            FileList = new List<byte[]>();
            TaskList = new Dictionary<int, string>();
            AnswerTaskList = new Dictionary<int, string>();
        }
    }
}
