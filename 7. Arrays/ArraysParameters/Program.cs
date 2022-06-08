using System;

namespace ArraysParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsGrades = new int[] { 15, 13, 8, 12, 6, 16 };
            double averageResult = GetAverage(studentsGrades);

            Console.WriteLine("The average is {0}", averageResult);

            int[] happiness = new int[] { 1, 2, 3, 4, 5 };

            SunIsShining(happiness);

            foreach(int item in happiness)
            {
                Console.WriteLine("Increased values is: {0}", item);
            }
        }

        static void SunIsShining(int[] hapiness)
        {
            for (int i = 0; i < hapiness.Length; i++)
            {
                hapiness[i] += 2;
            }
        }

        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for(int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
