using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    internal class Mentor : Person
    {
        private string level;

        public Mentor(string name, int age, bool gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor() : base()
        {
            this.level = "intermediate";
        }

        public string Level { get => level; set => level = value; }

        public override string GetGoal()
        {
            return "Educate brilliant junior software developers.";
        }

        public override string Introduce()
        {
            return $"{base.Introduce()} {this.level} mentor.";
        }
    }
}
