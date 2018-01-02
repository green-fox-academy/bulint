using System;
using System.Collections.Generic;

namespace GreenFoxOrganization
{
    class PallidaClass
    {
        public string className;
        public List<Person> students = new List<Person>();
        public List<Person> mentors = new List<Person>();

        public PallidaClass(string className)
        {
            this.className = className;
            students.Clear();
            mentors.Clear();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("Pallida " + className + " class has " + students.Count + " students and " + mentors.Count + " mentors.");
        }
    }
}
