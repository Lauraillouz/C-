using System;

namespace MethodsAndFunctions
{
    class Program
    {
        const string friend1 = "Hélène";
        const string friend2 = "Guénael";
        const string friend3 = "Robin";


        static void Main(string[] args)
        {

            string myString = "hey there !";

            WriteSomething();
            WriteSomethingSpecific("Something specific");
            Console.WriteLine(Add(15, 31));
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Divide(25, 13));
            GreetFriend(friend1);
            GreetFriend(friend2);
            GreetFriend(friend3);
            myString = LowUpper(myString);
            Console.WriteLine(myString);
            Count(myString);
            Console.Read();
        }

        // void methods
        public static void WriteSomething ()
        {
            Console.WriteLine("I am called from a method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
        }

        // methods that return values
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        // careful with number types, cause if we use int as paramters, the return value will be an int
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        // Challenge
        public static void GreetFriend(string friendName)
        {
            Console.WriteLine("Hi {0}, my friend!", friendName);
        }

        // Test methods Challenge
        public static string LowUpper(string text)
        {
            return text.ToLower() + text.ToUpper();
        }

        public static void Count(string x)
        {
            Console.WriteLine("The amount of letters is {0}", x.Length);
        }
    }
}
