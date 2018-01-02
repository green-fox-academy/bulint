using System;

namespace GreenFoxOrganization
{
    class Sponsor : Person
    {
        public string company;
        public int hiredStudents;

        public Sponsor(string name, int age, string gender, string company) : base(name, age, gender)
        {
            hiredStudents = 0;
            company = "Google";
        }

        public Sponsor()
        {
            hiredStudents = 0;
            company = "Google";
        }

        public override void Introduce()
        {
            Console.WriteLine("Hi, I'm " + name + ", a " + age + " year old " + gender + " who represents " + company + " and hired " + hiredStudents + " students so far.");
        }

        public override void GetGoal()
        {
            Console.WriteLine("Hire brilliant junior software developers");
        }

        public void Hire()
        {
            hiredStudents = hiredStudents + 1;
        }
    }
}
