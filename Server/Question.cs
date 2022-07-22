using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Question
    {
        public int questionid { get; set; }
        public string question { get; set; }
        public string a { get; set; }
        public string b { get; set; }
        public string c { get; set; }
        public string d { get; set; }
        public string correctAnswer { get; set; }

        public Question()
        {
            this.questionid = 0;
            this.question = "";
            this.a = "";
            this.b = "";
            this.c = "";
            this.d = "";
            this.correctAnswer = "";
        }

        public Question(int questionid, string question, string a, string b, string c, string d, string correctAnswer)
        {
            this.questionid = questionid;
            this.question = question;
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            this.correctAnswer = correctAnswer;
        }
    }
}
