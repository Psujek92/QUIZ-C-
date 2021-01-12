using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    static class FileHandler
    {
        public static void CreateXml(string title, string path, string description, List<Question> questions)
        {
            var document = new XDocument();
            var quiz = new XElement("Quiz", 
                new XAttribute("Title", title), 
                new XAttribute("Description", description), 
                    from question in questions
                    select new XElement("Question",
                        new XAttribute("Id", question.id),
                        new XAttribute("Content", question.content),
                        new XAttribute("AnswerA", question.answerA),
                        new XAttribute("AnswerB", question.answerB),
                        new XAttribute("AnswerC", question.answerC),
                        new XAttribute("AnswerD", question.answerD),
                        new XAttribute("AnswerCorrect", question.answerCorrect)));
            document.Add(quiz);
            document.Save(path);
        }
        public static Quiz OpenXml(string path)
        {
            var document = XDocument.Load(path);
            var quiz = new Quiz();
            var questions = new List<Question>();
            quiz.title = document.Element("Quiz").Attribute("Title").Value;
            quiz.description = document.Element("Quiz").Attribute("Description").Value;
            foreach (var question in document.Element("Quiz")?.Elements("Question"))
            {
                questions.Add(new Question(
                    question.Attribute("Id").Value,
                    question.Attribute("Content").Value,
                    question.Attribute("AnswerA").Value,
                    question.Attribute("AnswerB").Value,
                    question.Attribute("AnswerC").Value,
                    question.Attribute("AnswerD").Value,
                    question.Attribute("AnswerCorrect").Value
                    ));
            }
            quiz.questions = questions;
            return quiz;
        }

        public static string PreviewXml(string path)
        {
            var document = XDocument.Load(path);
            return $"Title: {document.Element("Quiz").Attribute("Title").Value}\nDescription: {document.Element("Quiz").Attribute("Description").Value}";
        }

        public static string OpenText(string path)
        {
            string text = "";
            if (File.Exists(path))
            {
                using (StreamReader streamReader = new StreamReader(path))
                {
                    text = streamReader.ReadToEnd();
                }
            }
            else
            {
                text = "ERROR\nFile Not Found";
            }
            return text;
        }
    }
}
