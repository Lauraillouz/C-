using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int otherCounter = 0;

            while(otherCounter < 10)
            {
                Console.WriteLine("Keep going and press enter");
                Console.ReadLine();
                otherCounter++;
            }
            Console.WriteLine("Thank you!");

            Console.Read();

            for (int counter = 0; counter < 50; counter++)
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
            }

        }
    }
}
