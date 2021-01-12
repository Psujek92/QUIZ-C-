using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZ
{
    public partial class OpenQuizForm : Form
    {
        static int questionNumber;
        static List<string> answers;
        static Quiz quiz;
        public OpenQuizForm(string path)
        {
            InitializeComponent();
            answerARadioButton.Checked = false;
            previousButton.Enabled = false;
            finishButton.Enabled = false;
            PlayQuiz(path);
        }

        // Events
        private void SubmitButton_Click(object sender, EventArgs e)
        {

        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void HelpButton_Click(object sender, EventArgs e)
        {
            var helpForm = new HelpForm("HelpOpenQuiz.txt");
            helpForm.Show();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {

            if (IsAnswerChosen())
            {
                SaveAnswer();
                questionNumber += 1;
                if (questionNumber == quiz.questions.Count())
                {
                    nextButton.Enabled = false;
                    finishButton.Enabled = true;
                }
                else
                {
                    AskQuestion(quiz.questions[questionNumber]);
                    foreach (var radioButton in questionPanel.Controls.OfType<RadioButton>())
                    {
                        radioButton.Checked = false;
                    }
                }    
            }
            else
            {
                var msg = "Answer not selected";
                MessageBox.Show(msg, this.Text, MessageBoxButtons.OK);
            }            
        }
        private void finishButton_Click(object sender, EventArgs e)
        {
            DisplayScore();
            this.Close();
        }  

        // Methods
        private void PlayQuiz(string path)
        {
            questionNumber = 0;
            answers = new List<string>();
            quiz = FileHandler.OpenXml(path);
            quizTitleLabel.Text = quiz.title;
            quizDescriptionLabel.Text = quiz.description;
            AskQuestion(quiz.questions[questionNumber]);
        }
        private void AskQuestion(Question question)
        {

            questionNumberLabel.Text = $"Question number: {question.id}";
            questionTextLabel.Text = question.content;
            answerARadioButton.Text = question.answerA;
            answerBRadioButton.Text = question.answerB;
            answerCRadioButton.Text = question.answerC;
            answerDRadioButton.Text = question.answerD;


        }
        private void SaveAnswer()
        {
            string answer = "A";
            foreach (var radioButton in questionPanel.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked == true)
                {
                    answer = radioButton.Name.Substring(6, 1);
                }
            }
            answers.Add(answer);
        }
        private bool IsAnswerChosen()
        {
            bool valid = true;
            if (questionPanel.Controls.OfType<RadioButton>().Where(r => r.Checked).Select(r => r).Count() == 0)
            {
                valid = false;
            }
            return valid;
        }
        private void DisplayScore()
        {
            var msg = $"Your score is: {CalculateScore()}";
            MessageBox.Show(msg, this.Text, MessageBoxButtons.OK);
        }
        private int CalculateScore()
        {
            var score = 0;
            int i = 0;
            foreach (var answer in answers)
            {
                if (answer == quiz.questions[i].answerCorrect)
                {
                    score += 1;
                }
                i += 1;
            }    
            return score;
        }
    }
}
