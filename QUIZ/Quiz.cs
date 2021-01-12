using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    class Quiz
    {
        public Quiz() { }
        public Quiz(string title, string description, List<Question> questions)
        {
            this.title = title;
            this.description = description;
            this.questions = questions;
        }

        public string title { get; set; }
        public string description { get; set; }
        public List<Question> questions { get; set; }

    }
}
