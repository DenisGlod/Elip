using ElipModel.Entity;
using System;
using System.IO;
using System.Windows.Forms;

namespace ElipTeacher.View
{
    public partial class AttachFilesForm : Form
    {
        private readonly Lab lab;
        private readonly string method;

        public AttachFilesForm(Lab lab, string method)
        {
            InitializeComponent();
            this.lab = lab;
            this.method = method;
            switch (method)
            {
                case "Edit":
                    lab.FileNameList.ForEach(item => { TVAttachFiles.Nodes.Add(item); });
                    break;
            }
        }

        private void BAddFile_Click(object sender, EventArgs e)
        {
            var result = OpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                int i = 0;
                foreach (var item in OpenFileDialog.SafeFileNames)
                {
                    TVAttachFiles.Nodes.Add(OpenFileDialog.FileNames[i++], item);
                }
            }
        }

        private void BDeleteFile_Click(object sender, EventArgs e)
        {
            if (TVAttachFiles.SelectedNode != null)
            {
                TVAttachFiles.Nodes.Remove(TVAttachFiles.SelectedNode);
                if (method.Equals("Edit"))
                {
                    lab.FileList.RemoveAt(TVAttachFiles.SelectedNode.Index);
                    lab.FileNameList.Remove(TVAttachFiles.SelectedNode.Text);
                }
            }
        }

        private void BSaveAttachFiles_Click(object sender, EventArgs e)
        {
            foreach (TreeNode item in TVAttachFiles.Nodes)
            {
                if (!item.Name.Equals(""))
                {
                    lab.FileNameList.Add(item.Text);
                    lab.FileList.Add(File.ReadAllBytes(item.Name));
                }
            }
            MessageBox.Show("Файлы сохранены!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Hide();
        }
    }
}
