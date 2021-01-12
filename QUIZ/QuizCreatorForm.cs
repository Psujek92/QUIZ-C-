using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace QUIZ
{
    public partial class QuizCreatorForm : Form
    {
        static int questionId;
        static List<Question> questions;
        private readonly QuizMainMenu parentForm;

        public QuizCreatorForm(QuizMainMenu parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            questionId = 0;
            questions = new List<Question>();
            questionNumberLabel.Text = "1 / 1";
        }

        // Events
        private void SameAsQuizNameBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sameAsQuizNameBox.Checked == true)
            {
                fileNameBox.Text = nameBox.Text;
                fileNameBox.Enabled = false;
            }
            else
            {
                fileNameBox.Enabled = true;
            }

        }
        private void QuestionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (sameAsQuizNameBox.Checked == true)
            {
                fileNameBox.Text = nameBox.Text;
            }
        }
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            if (questionId > 0)
            {
                questionId -= 1;
                ClearQuestionControls();
                LoadQuestion();
            }
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (QuestionIsValid()) SaveCurrentQuestion();
            else DisplayQuestionError();
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DeleteQuestion();
        }
        private void NextButton_Click(object sender, EventArgs e)
        {
            if (questionId < questions.Count())
            {
                questionId += 1;
                ClearQuestionControls();
                if (questions.Count != questionId)
                {
                    LoadQuestion();
                }
            }
            else
            {
                messageLabel.Text = "Cannot add another empty question. Have you saved the current one?";
            }
        }

        private void CloseWithoutSavingButton_Click(object sender, EventArgs e)
        {
            var msg = "Are you sure you want to close? This quiz will not be saved";

            if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void SaveAndCloseButton_Click(object sender, EventArgs e)
        {
            if (questions.Count > 0)
            {
                if (File.Exists($"{fileNameBox.Text}.csv"))
                {
                    var msg = $"File { fileNameBox.Text } already exists, overwrite?";

                    if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.No)
                    {
                        return;
                    }
                }
                FileHandler.CreateXml(nameBox.Text, $"{fileNameBox.Text}.csv", descriptionBox.Text, questions);
                this.Close();
            }
            else
            {
                var msg = "There are no questions to save";
                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK);
            }
            
        }
        private void QuizCreatorForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (parentForm != null)
            {
                parentForm.PopulateQuizFilesListBox();
            }
        }

        // Methods
        private void LoadQuestion()
        {
            questionTextBox.Text = questions[questionId].content;
            answerATextBox.Text = questions[questionId].answerA;
            answerBTextBox.Text = questions[questionId].answerB;
            answerCTextBox.Text = questions[questionId].answerC;
            answerDTextBox.Text = questions[questionId].answerD;
            foreach (var radioButton in addQuestionPanel.Controls.OfType<RadioButton>())
                if (radioButton.Name == $"answer{questions[questionId].answerCorrect}RadioButton")
                {
                    radioButton.Checked = true;
                }

        }     
        private void ClearQuestionControls()
        {
            questionTextBox.Text = "";
            answerATextBox.Text = "";
            answerBTextBox.Text = "";
            answerCTextBox.Text = "";
            answerDTextBox.Text = "";
            answerARadioButton.Checked = false;
            answerBRadioButton.Checked = false;
            answerCRadioButton.Checked = false;
            answerDRadioButton.Checked = false;
            messageLabel.Text = "";
            questionNumberLabel.Text = $"{questionId + 1}";
        }
        private void SaveCurrentQuestion()
        {
            AddQuestionToList();
            messageLabel.Text = "Question saved succesfully";
        }
        private bool QuestionIsValid()
        {
            bool valid = true;
            if (addQuestionPanel.Controls.OfType<RadioButton>().Where(r => r.Checked).Select(r => r).Count() == 0)
            {
                valid = false;
            }
            foreach (TextBox box in addQuestionPanel.Controls.OfType<TextBox>().Select(b => b))
            {
                if (box.Text == "")
                {
                    valid = false;
                }
            }
            return valid;
        }
        private void AddQuestionToList()
        {
            string correctButton = "A";
            foreach (var radioButton in addQuestionPanel.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked == true)
                {
                    correctButton = radioButton.Name.Substring(6,1);
                }
            }
            var question = new Question()
            {
                id = questionNumberLabel.Text,
                content = questionTextBox.Text,
                answerA = answerATextBox.Text,
                answerB = answerBTextBox.Text,
                answerC = answerCTextBox.Text,
                answerD = answerDTextBox.Text,
                answerCorrect = correctButton
            }; 
            if (questionId >= questions.Count)
            {
                questions.Add(question);
            }
            else
            {
                questions[questionId] = question;
            }
        }
        private void DisplayQuestionError()
        {
            messageLabel.Text = "Question save failed. Make sure that all text fields are filled and a correct answer is chosen";
        }
        private void DeleteQuestion()
        {
            var msg = "Are you sure you want to delete this question?";

            if (MessageBox.Show(msg, this.Text, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                questions.Remove(questions[questionId]);
                if (questions.Count > questionId)
                {
                    ClearQuestionControls();
                    LoadQuestion();
                }
                else
                {
                    ClearQuestionControls();
                }           
            }
            
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm("HelpCreateQuiz.txt");
            helpForm.Show();
        }
    }
}
