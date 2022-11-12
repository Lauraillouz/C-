using System;

namespace Nullables
{
    class Program
    {
        static void Main(string[] args)
        {
            int? num1 = null;
            int? num2 = 1337;
            double? num3 = new Double?();
            double? num4 = 3.14157;
            bool? boolVal = new bool?();

            // null values won't display
            Console.WriteLine("Nullable numbers are {0}, {1}, {2}, {3}", num1, num2, num3, num4);
            Console.WriteLine("Nullable bool is {0}", boolVal);

            bool? isMale = null;

            if(isMale == true)
            {
                Console.WriteLine("User is male");
            } else if (isMale == false)
            {
                Console.WriteLine("User is female");
            } else
            {
                Console.WriteLine("No gender specified");
            };

            double? num5 = 13.1;
            double? num6 = null;
            double num7;

            if(num5 == null)
            {
                num7 = 0.0;
            } else
            {
                num7 = (double)num5;
            }

            // Null coalescing operator
            num7 = (double)(num6 ?? num5);

            Console.WriteLine("Value of num8 is {0}", num7);
        }
    }
}
