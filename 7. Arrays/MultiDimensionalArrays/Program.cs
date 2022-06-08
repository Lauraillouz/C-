using System;

namespace MultiDimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare a 2D array
            string[,] matrix;

            //declare 3D array
            string[,,] threeD;

            // initialising 2D array
            int[,] array2D = new int[,] {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 }
            };

            Console.WriteLine("Central value is {0}", array2D[1, 1]);
            Console.WriteLine("Access to the 7: {0}", array2D[2, 0]);

            // intialise 3D array
            // they always need the same number of rows.
            string[,,] array3D = new string[,,]
            {
                {
                    {"1", "2", "3" },
                    {"4", "5", "6" }
                },
                {
                    {"7", "8", "9" },
                    {"10", "11", "12" }
                }
            };

            Console.WriteLine("Access to the 10: {0}", array3D[1, 1, 0]);


            // it is possible to specify the number of rows we want before hand
            string[,] array2DString = new string[3, 2]
            {
                { "one", "two" },
                { "three", "four" },
                { "five", "six" }
            };

            // Challenge change four to chicken
            Console.WriteLine("Before: {0}", array2DString[1, 1]);
            array2DString[1, 1] = "chicken";
            Console.WriteLine("After: {0}", array2DString[1, 1]);

            // allows to find out the number of dimensions an array has
            int dimensions = array2DString.Rank;

            Console.ReadKey();
        }
    }
}
