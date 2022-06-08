using System;
using System.Collections.Generic;

namespace IEnumerable_example1
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a generic IEnumerable variable that takes any collection of type int
            // we will use this variable to store the collections that will get returned by the GetCollection

            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(1);

            Console.WriteLine("This was a List<int>");
            // fore each number in the collection we got back from GetCollection()
            foreach(int number in unknownCollection)
            {
                Console.WriteLine(number + " ");
            }

            // will be stored in the base of type of generic collections
            unknownCollection = GetCollection(2);

            Console.WriteLine("This was a Queue<int>");
            // fore each number in the collection we got back from GetCollection()
            foreach (int number in unknownCollection)
            {
                Console.WriteLine(number + " ");
            }
        }

        static IEnumerable<int> GetCollection(int option)
        {
            // create a list of nnumbers and initialise it
            List<int> numbersList = new List<int>() { 1, 2, 3, 4, 5 };

            Queue<int> numbersQueue = new Queue<int>();
            // add values to the queue
            numbersQueue.Enqueue(6);
            numbersQueue.Enqueue(7);
            numbersQueue.Enqueue(8);
            numbersQueue.Enqueue(9);
            numbersQueue.Enqueue(10);

            if(option == 1)
            {
                return numbersList;
            }
            else if (option == 2)
            {
                return numbersQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14, 15};
            }


        }
    }
}
