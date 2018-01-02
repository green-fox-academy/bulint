using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenFoxOrganization
{
    class Student : Person, ICloneable
    {
        public string previousOrganization;
        public int skippedDays;

        public Student(string name, int age, string gender, string previousOrganization) : base(name, age, gender)
        {
            this.previousOrganization = previousOrganization;
        }

        public Student()
        {
            skippedDays = 0;
        }

        public object Clone()
        {
            return new Student(name, age, gender, previousOrganization);
        }

        public override void GetGoal()
        {
            Console.WriteLine("Be a junior software developer");
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " from " + previousOrganization + " who skipped " + skippedDays + " days from the course already.");
        }

        public void SkipDays(int numberOfDays)
        {
            skippedDays = skippedDays + numberOfDays;
        }
    }
}
