using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokGame
{
    public class TicTacToeGame
    {
        static char[] board = new char[10];
        static int player=1;
     
        public static void BoardGame()
        {
            for(int i=1;i<board.Length;i++)
            {
                Console.WriteLine(board[i] + "   ");
             
            }
        }
        public static void Choose()
        {
            Console.WriteLine("Select X or O:");
            
            int input;
            input = Convert.ToInt32(Console.ReadLine());


            switch (input)
            {
                case 1:
                    Console.WriteLine("Player Turn:" + input);
                    break;

                case 2:
                    Console.WriteLine("Computer Turn:" + input);
                    break;

                default: 
                    Console.WriteLine("Input appropriate");
                    break;
            }
        }
        public static void showBoard()
        {
            player = Convert.ToInt32(Console.ReadLine());
            if (player == 'X')
            {
                Console.WriteLine("Computer Turn");
                player++;
            }
            else
                Console.WriteLine("Player Turn");
                player++;
        }
        
    }
}
