using System;

namespace Enums
{
    // these enums will be accessible in the whole namespace
    enum Day
    {
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    };

    // Specify to start at 1, otherwise it starts by default at 0
    enum Month
    {
        January = 1, February, March, April, May, June, July = 12, August, September, October, November, December
    };

    class Program
    {
        static void Main(string[] args)
        {
            Day fr = Day.Friday;

            Day a = Day.Friday;

            Console.WriteLine(fr == a); // should print True
            Console.WriteLine((int)Day.Monday); // Should print 0
            Console.WriteLine((int)Month.February); // Should print 2
            Console.WriteLine((int)Month.August); // Should print 13

            Console.Read();

            // Challenge : create an enum with the months of the year
            
        }
    }
}
