using System;

namespace RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the question");
            Console.ReadLine();

            Random yesNoMaybe = new Random();
            int answer;

            // next method returns a value between a specific range
            answer = yesNoMaybe.Next(0, 4);
            switch (answer)
            {
                case 0:
                    Console.WriteLine("yes");
                    break;
                case 1:
                    Console.WriteLine("maybe");
                    break;
                case 2:
                    Console.WriteLine("no");
                    break;
                default:
                    Console.WriteLine("you're on the wrong path");
                    break;
            };
            

            Console.Read();

        }

    }
}
