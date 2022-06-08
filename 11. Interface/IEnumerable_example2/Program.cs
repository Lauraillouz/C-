using System;
using System.Collections.Generic;

namespace IEnumerable_example2
{
    class Program
    {
        static void Main(string[] args)
        {
            // a list initialised with some numbers
            List<int> numbersList = new List<int>() { 8, 6, 2 };

            // an array initialised with some numbers
            int[] numbersArray = new int[] { 1, 7, 1, 3 };

            // call collectionSum() and pass the list to it
            CollectionSum(numbersList);

            CollectionSum(numbersArray);

        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            // sum variable to store the sum of the numbers in anyCollection
            int sum = 0;

            // for each nummber in the collection passed to this methid, we add it to the sum
            foreach(int number in anyCollection)
            {
                sum += number;
            }

            // print the sum
            Console.WriteLine("Sum is {0}", sum);
        }
    }
}
