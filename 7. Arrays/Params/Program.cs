using System;

namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(6, 4, 2, 8, -1, 5);

            Console.WriteLine("The minimum is: {0}", min);

            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "The Hobbit";

            // even with no parameters, the method will not crash the program
            ParamsMethod("This", "is", "a", "string");

            ParamsMethod2(price, pi, at, book);
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for (int i = 0; i < sentence.Length; i++)
                {
                Console.Write(sentence[i] + " ");
                }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach(object obj in stuff)
            {
                Console.Write(obj + " ");
            }
        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;

            foreach(int num in numbers)
            {
                if(num < min)
                {
                    min = num;
                }
            }
                return min;
        }
    }
}
