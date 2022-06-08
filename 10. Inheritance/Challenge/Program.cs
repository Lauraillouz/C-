using System;

namespace Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss Laura = new Boss("Laura", "Illouz", 100000, "Tesla");
            Laura.Lead();

            Trainee Eric = new Trainee("Eric", "Chhim", 15000, "barely 2hrs a week", "doesn't need school, is an engineer");
            Eric.Work();

            Console.ReadLine();
        }
    }
}
