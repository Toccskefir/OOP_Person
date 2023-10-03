using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    internal class Sponsor : Person
    {
        private string company;
        private int hiredStudents;

        public Sponsor(string name, int age, bool gender, string company) : base(name, age, gender)
        {
            this.company = company;
            this.hiredStudents = 0;
        }

        public Sponsor() : base()
        {
            this.company = "Google";
            this.hiredStudents = 0;
        }

        public string Company { get => company; set => company = value; }
        public int HiredStudents { get => hiredStudents; set => hiredStudents = value; }

        public override string GetGoal()
        {
            return "Hire brilliant junior software developers.";
        }

        public override string Introduce()
        {
            return $"{base.Introduce()} who represents {this.company} and hired {this.hiredStudents} students so far.";
        }
    }
}
