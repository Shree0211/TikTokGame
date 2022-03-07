using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokGame
{
    
    public class TicTacToeGame
    {
        static char[] board = new char[9];
        public static void BoardGame()
        {
            for(int i=1;i<=board.Length;i++)
            {
                Console.WriteLine(board[i] + "   ");
            }
        }
    }
}
