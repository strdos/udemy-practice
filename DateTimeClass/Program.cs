using System;

namespace DateTimeClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2022, 6, 7);
            Console.WriteLine(dateTime);
            Console.WriteLine(DateTime.Today);
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now - dateTime);
            Console.WriteLine(GetTomorrow());
            Console.WriteLine(DateTime.Today.DayOfWeek);
            Console.WriteLine(GetFirstDayOfYear(2022));

            DateTime now = DateTime.Now;
            Console.WriteLine("Current minute is: {0}", now.Minute);
            Console.WriteLine("Now is: {0} o'clock, {1} minutes, and {2} seconds.", now.Hour, now.Minute, now.Second);

            // calculates how many days have passed since a date entered by the user
            Console.WriteLine("Enter a date in this format: yyyy-mm-dd");
            string input = Console.ReadLine();
            if(DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now - dateTime; // or TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine(daysPassed.Days);
            }
        }
        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }
        static DayOfWeek GetFirstDayOfYear(int year)
        {
            DateTime dateTime = new DateTime(year, 1, 1);
            return dateTime.DayOfWeek;
        }
    }
}
