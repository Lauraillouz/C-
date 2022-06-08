using System;

namespace NestedLoopsAndArrays
{
    class Program
    {

        static int[,] matrix =
        {
            {1, 2, 3 },
            {4, 5, 6 },
            {7, 8, 9 }
        };

        static void Main(string[] args)
        {

            foreach(int num in matrix)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine("\n");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j) // prints the diagonal 1 5 9
                    {
                        Console.Write(matrix[i, j] + " ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine(" ");

            }

            // same with only one loop
            /*
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                Console.WriteLine(matrix[i, i]);
            }
            */

            // this will cross iterations and print 3 5 7
            for (int i = 0, j = 2; i < matrix.GetLength(0); i++, j--)
            {
                
                Console.WriteLine(matrix[i, j]);
            }

            Console.Read();

        }
    }
}
