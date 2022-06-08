using System;

namespace Methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            Operators();
            TryAndCatch();

            Console.WriteLine("Hello, what is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Hello, {0}", input);
            Console.Write(Calculate());

            Console.Read();

        }

        public static int Calculate()
        {
            string num1;
            string num2;

            Console.WriteLine("Please choose a number and press enter");
            num1 = Console.ReadLine();
            Console.WriteLine("Thanks. Now please choose a second number to add to the first one and press enter.");
            num2 = Console.ReadLine();
            int result = Int32.Parse(num1) + Int32.Parse(num2);
            Console.Write("The result is: ");
            return result;
            ;
        }

        public static void TryAndCatch()
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();

            try
            {

                int userInputAsInt = int.Parse(userInput);

            }
            catch(Exception)
            {
                // You can have as many catch as you want, in order to separate the message you send depending on the type of error
                throw;
            }
            finally
            {
                Console.WriteLine("This is called anyways");
            }


            Console.ReadKey();
        }

        public static void Operators()
        {
            int num1 = 5;
            int num2 = 3;
            int num3;

            //unary operators
            num3 = -num1;
            Console.WriteLine("num 3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("is it sunny? {0}", isSunny);

            // increment operators (works the same for decrement operators)
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            // post increment
            Console.WriteLine("num is {0}", num++);
            // pre increment
            Console.WriteLine("num is {0}", ++num);
            Console.ReadKey();

        }
    }
}
