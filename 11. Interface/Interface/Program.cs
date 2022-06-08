using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Ticket ticket1 = new Ticket(10);
            Ticket ticket2 = new Ticket(10);

            Console.WriteLine(ticket2.Equals(ticket1));
        }
    }
}
