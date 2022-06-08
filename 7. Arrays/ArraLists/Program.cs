using System;
using System.Collections;

namespace ArraLists
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare ArrayList with undefinite amount of objects
            ArrayList myArrayList = new ArrayList();

            // with defined amount of objetcs
            ArrayList myArrayList2 = new ArrayList();

            myArrayList.Add(25);
            myArrayList.Add("Hello");
            myArrayList.Add("Oh my");
            myArrayList.Add(13.37);
            myArrayList.Add(true);

            // delete element with specific value from the ArrayList
            myArrayList.Remove(true);

            // delete element at specific position
            myArrayList.RemoveAt(1);

            // count how many elements
            Console.WriteLine(myArrayList.Count);

            double sum = 0;

            foreach(object obj in myArrayList)
            {
                if(obj is int)
                {
                    sum += Convert.ToDouble(obj);
                }
                else if(obj is double)
                {
                    sum += (double)obj;
                }
                else if (obj is string){
                    Console.WriteLine(obj);
                }
            }
            Console.WriteLine(sum);


        }
    }
}
