using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    public class Question
    {
        public Question(string id, string content, string answerA, string answerB, string answerC, string answerD, string answerCorrect)
        {
            this.id = id;
            this.content = content;
            this.answerA = answerA;
            this.answerB = answerB;
            this.answerC = answerC;
            this.answerD = answerD;
            this.answerCorrect = answerCorrect;
        }
        public Question() { }
        public string id { get; set; }
        public string content { get; set; }
        public string answerA { get; set; }
        public string answerB { get; set; }
        public string answerC { get; set; }
        public string answerD { get; set; }
        public string answerCorrect { get; set; }
    }
}
