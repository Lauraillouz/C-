using System;

namespace TicTacToe
{
    class Program
    {
        static string[,] board =
        {
            {"1", "2", "3"},
            {"4", "5", "6"},
            {"7", "8", "9"},
        };
        static bool victory = false;


        static void Main(string[] args)
        {
            int player = 0;
            string choice;
            bool inputCorrect = true;


            Board();
            //start game
            Console.WriteLine("\n Player 1: X / Player 2: O");
            choice = Console.ReadLine();

            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != "X" && board[i, j] != "O")
                    {
                        board[i, j]
                    }
                }
            }

            Console.ReadLine();
            
        }

        private static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[0, 0], board[0, 1], board[0, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[1, 0], board[1, 1], board[1, 2]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", board[2, 0], board[2, 1], board[2, 2]);
            Console.WriteLine("     |     |      ");
            
        }

        private static bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if(board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2])
                {
                    return victory = true;
                }

                if(board[0, i] == board[1, i] && board[1, i] == board[2, i])
                {
                    return victory = true;
                }
            }

            if(board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return victory = true;
            }
            if(board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return victory = true;
            }

            return victory = false;
        }
            
    }
}
