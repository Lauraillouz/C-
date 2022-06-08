using System;

namespace MakingDecisions
{
    class Program
    {
        static void Main(string[] args)
        {
            NestedCheck(3);
            NestedCheck(28);
            NestedCheck(1);

            Nested();
            Check(4);
            Check(5);
            string nnumberAsString = "128";
            int parsedValue;

            bool success = int.TryParse(nnumberAsString, out parsedValue);
            // the returned boolean is true when parsing was successful

            if (success)
                Console.WriteLine("Parsing worked - number is {0}", parsedValue);
            else
                Console.WriteLine("Parsing failed");

            // also usable: float.TryParse()
        }

        public static void Check(int num)
        {
            if(num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        public static void Nested()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("Please enter your name");

            userName = Console.ReadLine();

            if (isRegistered && userName != "")
            {
                Console.WriteLine("Hi there, registered user");

                if(userName != "")
                {
                    Console.WriteLine("Hi there, {0}", userName);

                    if(userName == "admin")
                    {
                        isAdmin = true;
                        Console.WriteLine("Hi, Admin");
                    }
                }
            }
            Console.Read();
        }

        public static void NestedCheck(int num)
        {
            if(num % 3 == 0)
            {
                Console.WriteLine("Divisible by 3");
            } else if(num % 7 == 0)
            {
                Console.WriteLine("Divisible by 7");
            }
            else
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("Even number");
                }
                else
                {
                    Console.WriteLine("Odd number");
                }
            }
        }
    }
}
