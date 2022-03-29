using System;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            TicTacToe.AnimationStart();
            TicTacToe.Game();
        }

        public static void Game (){
            char player = 'X';
            string choice;
            char winner = 'P';
            char[] board = new char[9] { ' ', ' ' , ' ', ' ', ' ' , ' ', ' ', ' ' , ' ' };

            do
            {
                
                Console.Clear();
                Console.WriteLine("         BOARD");
                Console.WriteLine("       |       |      ");
                Console.WriteLine($"   {board[0]}   |   {board[1]}   |   {board[2]} ");
                Console.WriteLine("_______|_______|_______ ");
                Console.WriteLine("       |       |      ");
                Console.WriteLine($"   {board[3]}   |   {board[4]}   |   {board[5]} ");
                Console.WriteLine("_______|_______|_______");
                Console.WriteLine("       |       |      ");
                Console.WriteLine($"   {board[6]}   |   {board[7]}   |   {board[8]} ");
                Console.WriteLine("       |       |     ");
                Console.WriteLine("");
                Console.WriteLine($"Type your choice - Player {player}");
                TicTacToe.Caption();
                int n;
                choice = Console.ReadLine();
                while (!Int32.TryParse(choice, out n) || n < 1 || n > 9 || board[n - 1] != ' ')
                {
                    Console.WriteLine("Type a valid choice! Try again!");
                    choice = Console.ReadLine();
                } 


                board[Convert.ToInt32(choice) - 1] = player;
                if (player == 'X')
                    player = 'O';
                else player = 'X';
                winner = TicTacToe.VerifyWinner(board);
            } while (winner=='P');
            Console.WriteLine($"O jogador {winner} venceu!");
            Console.ReadLine();
        } 
        
        public static char VerifyWinner(char[] board)
        {
            char winner='P', columnWinner='P';

            winner = VerifyColumn(board);
            if(winner == 'P')
            {
                winner = VerifyRow(board);
                if(winner == 'P')
                {
                    winner = VerifyDiagonal(board);
                }
            }
            return winner;
        }

        public static char VerifyDiagonal(char[] board)
        {
            char diagonalWinner = 'P';
            if ((board[0] == 'X' && board[4] == 'X' && board[8] == 'X') || (board[0] == 'O' && board[4] == 'O' && board[8] == 'O'))
            {
                diagonalWinner = board[0];
            }
            else
            {
                if ((board[6] == 'X' && board[4] == 'X' && board[2] == 'X') || (board[6] == 'O' && board[4] == 'O' && board[2] == 'O'))
                {
                    diagonalWinner = board[1];
                }
            }


            return diagonalWinner;

        }

        public static char VerifyColumn(char[] board)
        {
            char columnWinner = 'P';
            if ((board[0] == 'X' && board[3] == 'X' && board[6] == 'X') || (board[0] == 'O' && board[3] == 'O' && board[6] == 'O'))
            {
                columnWinner = board[0];
            }
            else
            {
                if ((board[1] == 'X' && board[4] == 'X' && board[7] == 'X') || (board[1] == 'O' && board[4] == 'O' && board[7] == 'O'))
                {
                    columnWinner = board[1];
                }
                else if ((board[2] == 'X' && board[5] == 'X' && board[8] == 'X') || (board[2] == 'O' && board[5] == 'O' && board[8] == 'O'))
            {
                    columnWinner = board[1];
                }
            }
            

                return columnWinner;
        }

        public static char VerifyRow(char[] board)
        {
            char rowWinner = 'P';
            if ((board[0] == 'X' && board[1] == 'X' && board[2] == 'X') || (board[0] == 'O' && board[1] == 'O' && board[2] == 'O'))
            {
                rowWinner = board[0];
            }
            else
            {
                if ((board[3] == 'X' && board[4] == 'X' && board[5] == 'X') || (board[3] == 'O' && board[4] == 'O' && board[5] == 'O'))
                {
                    rowWinner = board[1];
                }
                else if ((board[6] == 'X' && board[7] == 'X' && board[8] == 'X') || (board[6] == 'O' && board[7] == 'O' && board[8] == 'O'))
                {
                    rowWinner = board[1];
                }
            }


            return rowWinner;
        }
        public static void Caption()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("        CAPTION");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   1   |   2   |   3 ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   4   |   5   |   6  ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   7   |   8   |   9");
            Console.WriteLine("       |       |     ");
        }
        public static void AnimationStart()
        {
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |    ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |     ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |    ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |    ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |     ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |    ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |     ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |    ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |   X   |     ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |     ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |   X   |     ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |       |   O  ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |   X   |     ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Starting the game...");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("       |   X   |   O  ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   X   |       |   O  ");
            Console.WriteLine("       |       |     ");
            Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine(" WELCOME TO TICTACTOE");
            Console.WriteLine(" Press enter to start");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
