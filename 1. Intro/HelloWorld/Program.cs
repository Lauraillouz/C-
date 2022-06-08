using System;

namespace HelloWorld
{
    class Program
    {
        // Entry point of program
        static void Main(string[] args)
        {
            // Declaring variable
            int num1;

            // Assigning the variable a value
            num1 = 13;

            // Declaring and assigning value
            int num2 = 23;
            int sum = num1 + num2;

            // Declaring multiple variables at once
            int num3, num4, num5;

            // Using decimals
            double d1 = 3.1415;
            double d2 = 5.1;
            double dDiv = d1 / d2;

            // Using float
            float f1 = 3.1415f;
            float f2 = 5.1f;
            float fDiv = f1 / f2;

            // Strings
            string myName = "Laura";

            string myNameInCaps = myName.ToUpper();

            //Console.WriteLine(myNameInCaps);

            //Console.WriteLine("f1/f2 is: " + fDiv);
            //Console.WriteLine(dDiv);
            //Console.WriteLine(sum);

            Console.Write("Enter a string and press enter: ");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter any key and press enter: ");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}", asciiValue);
            Console.ReadKey();

        }
    }

}