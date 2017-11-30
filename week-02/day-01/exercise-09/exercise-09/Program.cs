using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Print the Body mass index (BMI) based on these values
            double massInKg = 81.2;
            double heightInM = 1.78;
            heightInM = heightInM * heightInM;
            double BMI = massInKg / heightInM;
            Console.WriteLine(BMI);
            Console.ReadLine();
        }
    }
}