using System;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = 0;
            int total = 0;
            string scoreInput;
            int intScore = 0;
            int average = 0;

            while (intScore != -1)
            {

                Console.WriteLine("Enter a note between 0 and 20. Enter -1 when you're done");
                scoreInput = Console.ReadLine();

                bool isScoreInt = int.TryParse(scoreInput, out intScore);

                if (isScoreInt)
                {
                    if (intScore == -1)
                    {
                        Console.WriteLine("The average is: {0}", average);
                        break;
                    }

                    total += intScore;
                    numberOfStudents++;
                }
                average = total / numberOfStudents;
            }

            Console.Read();

        }


    }
}
