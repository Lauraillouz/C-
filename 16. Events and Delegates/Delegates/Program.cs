using System;
using System.Collections.Generic;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "Pierre", "Paul", "Jacques" };

            Console.WriteLine("---before---");
            // print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            // call filtering method that is needed for RemoveAll delegate
            // the method is passed as a parameter
            names.RemoveAll(FilterContainsI);

            Console.WriteLine("---after---");
            // print the names after remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }


        static bool FilterContainsI(string s)
        {
            // returns whether the string contains the letter i
            return s.Contains("i");
        }
    }
}
