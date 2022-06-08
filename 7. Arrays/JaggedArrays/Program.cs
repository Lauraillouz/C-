using System;

namespace JaggedArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare jagged array : 3 arrays in on array
            int[][] jaggedArray = new int[3][];

            // initialise jagged arrays
            jaggedArray[0] = new int[5]; // 5 values in first array
            jaggedArray[1] = new int[3]; // and so on
            jaggedArray[2] = new int[2];

            jaggedArray[0] = new int[] { 1, 2, 3, 4, 5 };
            jaggedArray[1] = new int[] { 1, 2, 3 };
            jaggedArray[2] = new int[] { 1, 2 };

            // alternative way
            int[][] jaggedArray2 = new int[][]
            {
                new int[] { 1, 2, 3, 4, 5 },
                new int[] { 6, 7, 8 },
                new int[] { 9, 10 }
            };

            Console.WriteLine("Access to 7: {0}", jaggedArray2[1][1]);

            foreach(int[] item in jaggedArray2)
            {
                foreach(int el in item)
                {
                    Console.WriteLine(el);
                }
            }


            string[][] friendsArrays = new string[][]
            {
                new string[] {"Pierre", "Paul", "Jacques"},
                new string[] {"Jean", "Michel", "unknown"}
            };

            for (int i = 0; i < friendsArrays.GetLength(0); i++)
            {
                for (int j = 0; j < friendsArrays.GetLength(1); j++)
                {
                    Console.WriteLine("Hello {0}, this is {1}", friendsArrays[i][j]);
                }
            }
        }
    }
}
