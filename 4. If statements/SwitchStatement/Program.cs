using System;

namespace SwitchStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 25;

            switch (age)
            {
                case 15:
                    Console.WriteLine("Too young to praty in the club");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you, then?");
                    break;
            }

            if (age == 15)
            {
                Console.WriteLine("Too young to praty in the club");
            }
            else if (age == 25)
            {
                Console.WriteLine("Good to go!");
            }
            else
            {
                Console.WriteLine("How old are you, then?");
            }

            string username = "Laura";

            switch(username)
            {
                case "Denis":
                    Console.WriteLine("username is Denis");
                    break;
                case "root":
                    Console.WriteLine("username is root");
                    break;
                default:
                    Console.WriteLine("username is unknown");
                    break;
            }
        }
    }
}
