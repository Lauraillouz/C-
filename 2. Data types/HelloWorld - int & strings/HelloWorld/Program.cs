using System;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = 123456789;
            long bigNum = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;
            myFloat.ToString();

            Console.WriteLine(myFloat);


            double myDouble = 13.37;
            int myInt;

            // cat double to int with explicit conversion
            myInt = (int)myDouble;

            // type conversion
            string myString = myDouble.ToString();
            num.ToString();
            bool sunIsShining = true;
            sunIsShining.ToString();

            Console.WriteLine(sunIsShining);

            Console.WriteLine(myInt); // output is 13
            Console.Read();

            // Parse from a string to an integer
            string someString = "15";
            string anotherString = "13";
            int num1 = Int32.Parse(someString);
            int num2 = Int32.Parse(anotherString);
            int intResult = num1 + num2;
            string result = someString + anotherString;

            Console.WriteLine(result);
            Console.WriteLine(intResult);
            Console.Read();

            string stringForFloat = "0.85";
            string stringForInt = "12345";
            float thisFloat = float.Parse(stringForFloat, CultureInfo.InvariantCulture.NumberFormat);
            int thisInt = Int32.Parse(stringForInt);

            Console.WriteLine(thisFloat);
            Console.WriteLine(thisInt);
            Console.Read();


        }

    }
}
