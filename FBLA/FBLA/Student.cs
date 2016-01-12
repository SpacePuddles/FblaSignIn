using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBLA {
    class Student {
        private int id;
        private string firstName;
        private string lastName;
        private string studentID;
        private string fblaID;
        private string teamString;
        private string eventString;
        private int grade;

        public Student(int id, string firstName, string lastName, string studentID, int grade) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
            this.grade = grade;
        }

        public Student(int id, string firstName, string lastName, string studentID, string fblaID, int grade) {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
            this.grade = grade;
            this.fblaID = fblaID;
        }

        public int ID {
            get { return id; }
            set { id = value; }
        }

        public string FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName {
            get { return lastName; }
            set { lastName = value; }
        }

        public string FblaID {
            get { return fblaID; }
            set { fblaID = value; }
        }

        public string StudentID {
            get { return studentID; }
            set { studentID = value; }
        }

        public string TeamString {
            get { return teamString; }
            set { teamString = value; }
        }

        public string EventString {
            get { return eventString; }
            set { eventString = value; }
        }

        public int Grade {
            get { return grade; }
            set { grade = value; }
        }

        public List<int> getTeamIDs() {
            List<int> teams = new List<int>();

            string[] tmp = teamString.Split(',');
            foreach(string y in tmp) {
                int x = 0;
                x = Int32.Parse(y);
                teams.Add(x);
            }

            return teams;
        }

        public List<int> getEventIDs() {
            List<int> events = new List<int>();

            string[] tmp = eventString.Split(',');
            foreach(string y in tmp) {
                int x = 0;
                x = Int32.Parse(y);
                events.Add(x);
            }

            return events;
        }
}
