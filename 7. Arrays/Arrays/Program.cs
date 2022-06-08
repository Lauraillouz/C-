using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialising array with the length of it
            int[] grades = new int[5];

            // filling in the array
            grades[0] = 20;
            grades[1] = 16;
            grades[2] = 5;
            grades[3] = 14;
            grades[4] = 19;

            Console.WriteLine("grade at index {0}", grades[0]);

            string input = Console.ReadLine();

            // assign value to the array at a certain index
            grades[0] = int.Parse(input);

            Console.WriteLine("grade at index {0}", grades[0]);

            // other way of initialising
            int[] gradesOfMyStudentsA = { 20, 13, 12, 8, 8 };

            int[] gradesOfMyStudendsB = new int[] { 15, 20, 9, 17, 15, 11 };

            Console.WriteLine("Length of grades student A is {0}", gradesOfMyStudentsA.Length);
            Console.ReadKey();

        }
    }
}
