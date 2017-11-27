using System;

namespace exercise_06
{
    class Program
    {
        static void Main(string[] args)
        {
            // An average Green Fox attendee codes 6 hours daily
            // The semester is 17 weeks long
            //
            // Print how many hours is spent with coding in a semester by an attendee,
            // if the attendee only codes on workdays.
            //
            // Print the percentage of the coding hours in the semester if the average
            // work hours weekly is 52

            int hoursSpentCoding = (17 * 5) * 6;
            int workHoursInSemester = 17 * 52;
            double percentage = workHoursInSemester / 100;

            Console.WriteLine(hoursSpentCoding);
            Console.WriteLine(hoursSpentCoding / percentage);
            Console.ReadLine();


        }
    }
}
