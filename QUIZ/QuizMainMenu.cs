using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUIZ
{
    public partial class QuizMainMenu : Form
    {
        public QuizMainMenu()
        {
            InitializeComponent();
            PopulateQuizFilesListBox();
            openButton.Enabled = false;   
        }
        // Events
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var msg = "Are you sure you want to close?";

            if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm("HelpMainMenu.txt");
            helpForm.Show();
        }
        private void FolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            try
            {
                Directory.SetCurrentDirectory(folderBrowserDialog1.SelectedPath);
            }
            catch { }
            PopulateQuizFilesListBox();
            openButton.Enabled = false;
        }
        private void OpenButton_Click(object sender, EventArgs e)
        {
            var path = "quizFilesListBox.SelectedItem.ToString()";
            var openQuizForm = new OpenQuizForm(path);
            openQuizForm.Show();

        }
        private void CreateButton_Click(object sender, EventArgs e)
        {
            var createQuizForm = new QuizCreatorForm(this);
            createQuizForm.Show();
        }
        private void quizFilesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DetailsLabel.Text = FileHandler.PreviewXml("quizFilesListBox.SelectedItem.ToString()");
            openButton.Enabled = true;
        }
        private void quizFilesListBox_DoubleClick(object sender, EventArgs e)
        {
            var path = "quizFilesListBox.SelectedItem";
            var openQuizForm = new OpenQuizForm(path);
            openQuizForm.Show();
        }

        // Methods
        public void PopulateQuizFilesListBox()
        {
            quizFilesListBox.Items.Clear();
            var files = Directory.GetFiles(Directory.GetCurrentDirectory());
            foreach (var file in files)
            {
                if (file.Substring(file.Length - 3) == "csv")
                {
                    quizFilesListBox.Items.Add(file.Substring(Directory.GetCurrentDirectory().Length + 1));
                }
            }
        }
    }
}
