using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    internal class Person
    {
        private string name;
        private int age;
        private bool gender;

        public Person(string name, int age, bool gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public Person()
        {
            this.name = "Jane Doe";
            this.age = 30;
            this.gender = false;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public bool Gender { get => gender; set => gender = value; }

        public virtual string GetGoal()
        {
            return "My goal is: Live for the moment!";
        }

        public virtual string Introduce()
        {
            if (this.gender)
            {
                return $"Hi, I'm {this.name}, a {this.age} year old female.";
            }
            else
            {
                return $"Hi, I'm {this.name}, a {this.age} year old male.";
            }
        }
    }
}
