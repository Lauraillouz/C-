using System;

namespace DateTimeT
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateTime = new DateTime(2022, 11, 11);

            Console.WriteLine(dateTime);

            // write today's date
            Console.WriteLine(DateTime.Today);

            // write current time on screen
            Console.WriteLine(DateTime.Now);

            //write tomrrow's date
            DateTime tomorrow = GetTomorrow();
            Console.WriteLine(tomorrow);

            // write which day of the week it is
            var dayOfTheWeek = DateTime.Today.DayOfWeek;
            Console.WriteLine(dayOfTheWeek);

            // Write first day of a year
            Console.WriteLine(GetFirstDayOfYear(1999).DayOfWeek);

            // number of days in a month
            Console.WriteLine(DateTime.DaysInMonth(1989, 2));

            // get current minutes
            DateTime now = DateTime.Now;
            Console.WriteLine(now.Minute);

            // Challenge: display the time in this structure: x o'clock y minutes and z seconds
            Console.WriteLine("{0} o'clock {1} minutes and {2} seconds", now.Hour, now.Minute, now.Second);

            // Write a date in a certain format
            Console.WriteLine("Enter a date in format  yyyy-mm-dd");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out dateTime))
            {
                Console.WriteLine(dateTime);
                TimeSpan daysPassed = now.Subtract(dateTime);
                Console.WriteLine(daysPassed.Days);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
        }

        static DateTime GetTomorrow()
        {
            return DateTime.Today.AddDays(1);
        }

        static DateTime GetFirstDayOfYear(int year)
        {
            return new DateTime(year, 1, 1);
        }
    }
}
