using System;
using System.Threading.Tasks.Sources;

namespace CSharp.Assign
{
    public class Program
    {
        public static bool Checker(string[,] board)
        {
            

           
            for(int i = 0; i < board.GetLength(0); i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2]) return true;

                if (board[0, i] == board[1, i] && board[1, i] == board[2, i]) return true;
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2,2]) return true;

            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0]) return true;
                
            return false;
        }

        public static void Main(string[] args)
        {
            string[,] board = new string[,]
            {
                {"X","O","X"},
                {"O","O","O"},
                {"O","X","O"}
            };

            bool winner = Checker(board);
            Console.WriteLine(winner);
            Console.ReadLine();
        }


    }
}
