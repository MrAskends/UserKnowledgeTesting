using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class User
    {
        public int userid { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int age { get; set; }
        public Dictionary<string, int> subjectScores { get; set; }
        public bool admin { get; set; }

        public User()
        {
            this.userid = 0;
            this.login = "";
            this.password = "";
            this.firstname = "";
            this.lastname = "";
            this.age = 0;
            this.subjectScores = new Dictionary<string, int>();
            this.admin = false;
        }

        public User(int userid, string login, string password, string firstname, string lastname, int age, Dictionary<string, int> subjectScores, bool admin)
        {
            this.userid = userid;
            this.login = login;
            this.password = password;
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
            this.subjectScores = subjectScores;
            this.admin = false;
        }
    }
}
