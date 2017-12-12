using System;

namespace GreenFoxOrganization
{
    class Mentor : Person
    {
        public string level;

        public Mentor(string name, int age, string gender, string level) : base(name, age, gender)
        {
            this.level = level;
        }

        public Mentor()
        {
            level = "Intermediate";
        }

        public override void GetGoal()
        {
            Console.WriteLine("Educate brilliant software developers");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + level + " mentor.");
        }
    }
}
