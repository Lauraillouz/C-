using System;

namespace Challenge2
{
    class Program
    {
        static int highscore = 20;
        static string highScorePlayer = "Laura";

        static void Main(string[] args)
        {
            string playerName = "Lauro";
            CheckScore(15, playerName);
            Console.Read();

        }

        public static void CheckScore(int score, string playerName)
        {
            if (score > highscore)
            {
                highscore = score;
                highScorePlayer = playerName;

                Console.WriteLine("New highscore is {0}", score);
                Console.WriteLine("New highscore holder is {0}", playerName);
            }
            else
            {
                Console.WriteLine("The old highscore of {0} could not be broken and is still held by {1}", highscore, highScorePlayer);
            }
        }

    }
}
