using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Person
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            Person mark = new Person("Mark", 46, true);
            people.Add(mark);
            Person jane = new Person();
            people.Add(jane);

            Student john = new Student("John Doe", 20, true, "BME");
            people.Add(john);
            Student student = new Student();
            people.Add(student);

            Mentor gandhi = new Mentor("Gandhi", 148, true, "senior");
            people.Add(gandhi);
            Mentor mentor = new Mentor();
            people.Add(mentor);

            Sponsor sponsor = new Sponsor();
            people.Add(sponsor);
            Sponsor elon = new Sponsor("Elon Musk", 46, true, "SpaceX");
            people.Add(elon);

            student.skipDays(3);

            for (int i = 0; i < 5; i++)
            {
                elon.Hire();
            }

            for (int i = 0; i < 3; i++)
            {
                sponsor.Hire();
            }

            foreach (Person person in people)
            {
                Console.WriteLine(person.Introduce());
                Console.WriteLine(person.GetGoal());
            }

            Cohort awesome = new Cohort("AWESOME");
            awesome.AddStudent(student);
            awesome.AddStudent(john);
            awesome.AddMentor(mentor);
            awesome.AddMentor(gandhi);
            Console.WriteLine(awesome.Info());
            Console.ReadKey();
        }
    }
}
