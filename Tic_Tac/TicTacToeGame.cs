using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac
{
   
        internal class TicTacToeGame
        {
            static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            static int player;
            static int choice;
            int flag = 0;

            private static void Board()

            {

                Console.WriteLine("     :     :      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
                Console.WriteLine("      :     :    ");
                Console.WriteLine("     :     :      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
                Console.WriteLine("     :     :     ");
                Console.WriteLine("     :     :      ");
                Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
                Console.WriteLine("     :     :      ");

            }

            public void Chance()
            {

                Console.WriteLine("Player1:X and Player2:O");

                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");

                choice = int.Parse(Console.ReadLine());
            }
}
