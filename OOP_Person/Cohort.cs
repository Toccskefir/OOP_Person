using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    internal class Cohort
    {
        private string name;
        private List<Mentor> mentors;
        private List<Student> students;

        public Cohort(string name)
        {
            this.name = name;
            this.mentors = new List<Mentor>();
            this.students = new List<Student>();
        }

        public string Name { get => name; set => name = value; }
        internal List<Mentor> Mentors { get => mentors; set => mentors = value; }
        internal List<Student> Students { get => students; set => students = value; }

        public void AddStudent(Student s)
        {
            students.Add(s);
        }

        public void AddMentor(Mentor m)
        {
            mentors.Add(m);
        }

        public string Info()
        {
            return $"The {this.name} cohort has {students.Count} students and {mentors.Count} mentors.";
        }
    }
}
