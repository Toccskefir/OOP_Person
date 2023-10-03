using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    internal class Student : Person
    {
        private string previousOrganization;
        private int skippedDays;

        public Student(string name, int age, bool gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
            this.skippedDays = 0;
        }

        public Student() : base()
        {
            this.previousOrganization = "The School of Life";
            this.skippedDays = 0;
        }

        public string PreviousOrganization { get => previousOrganization; set => previousOrganization = value; }
        public int SkippedDays { get => skippedDays; set => skippedDays = value; }

        public override string GetGoal()
        {
            return "Be a junior software developer.";
        }

        public override string Introduce()
        {
            return $"{base.Introduce()} from {this.previousOrganization} who skipped {this.skippedDays} days from the course already.";
        }

        public void skipDays(int numberOdDays)
        {
            this.skippedDays += numberOdDays;
        }
    }
}
