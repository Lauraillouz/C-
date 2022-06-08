using System;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object of Human class = an instance of Human
            Human Laura = new Human("Laura", "Cutie", "brown", 33);
            // call method of the class
            Laura.IntroduceMyself();

            Human Michael = new Human("Michael", "Hubby", "green", 28);
            Michael.IntroduceMyself();

            Human BasicHuman = new Human();
            BasicHuman.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
