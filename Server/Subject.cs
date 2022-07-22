using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Subject
    {
        public int subjectid { get; set; }
        public string subjectName { get; set; }
        public List<Question> questionsList { get; set; }

        public Subject()
        {
            this.subjectid = 0;
            this.subjectName = "";
            this.questionsList = new List<Question>();
        }

        public Subject(int subjectid, string subjectName, List<Question> questionsList)
        {
            this.subjectid = subjectid;
            this.subjectName = subjectName;
            this.questionsList = questionsList;
        }
    }
}
