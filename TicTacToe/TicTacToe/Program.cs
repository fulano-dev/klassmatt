using System;
using System.Threading;
using System.Threading.Tasks;

namespace TicTacToe
{
    class TicTacToe
    {
        static void Main(string[] args)
        {
            bool continueGame;
            TicTacToe.AnimationStart();
            TicTacToe.Game();
        }

        public static void Game (){
            char player = 'X';
            string choice;
            char winner = 'P';
            char[] board = new char[9] { ' ', ' ' , ' ', ' ', ' ' , ' ', ' ', ' ' , ' ' };
            int time=0;
            do
            {
                time++;
                
                Console.Clear();
                Console.WriteLine("         TABULEIRO");
                Console.WriteLine("       |       |      ");
                Console.WriteLine($"   {board[6]}   |   {board[7]}   |   {board[8]} ");
                Console.WriteLine("_______|_______|_______ ");
                Console.WriteLine("       |       |      ");
                Console.WriteLine($"   {board[3]}   |   {board[4]}   |   {board[5]} ");
                Console.WriteLine("_______|_______|_______");
                Console.WriteLine("       |       |      ");
                Console.WriteLine($"   {board[0]}   |   {board[1]}   |   {board[2]} ");
                Console.WriteLine("       |       |     ");
                Console.WriteLine("");
                Console.WriteLine($"Agora é a vez do Jogador {player}");
                Console.WriteLine($"Digite um número de 1-9 que ainda não foi jogado");
                TicTacToe.Caption();
                int n;
                choice = Console.ReadLine();
                while (!Int32.TryParse(choice, out n) || n < 1 || n > 9 || board[n - 1] != ' ')
                {
                    Console.WriteLine("Jogada inválida! Tente novamente!");
                    choice = Console.ReadLine();
                } 


                board[Convert.ToInt32(choice) - 1] = player;
                if (player == 'X')
                    player = 'O';
                else player = 'X';
                winner = TicTacToe.VerifyWinner(board);
                if (time >= 9 && winner == 'P')
                {
                    winner = 'T';
                }
            } while (winner=='P');
            congratsWinner(winner, board);
            
        } 
        
        public static void congratsWinner(char winner, char[] board )
        {
            Console.Clear();
            if(winner == 'T')
            {
                Console.WriteLine($"O JOGO EMPATOU, VELHA!");
            } else
            Console.WriteLine($"O JOGADOR {winner} VENCEU!");
            Console.WriteLine("       |       |      ");
            Console.WriteLine($"   {board[6]}   |   {board[7]}   |   {board[8]} ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine($"   {board[3]}   |   {board[4]}   |   {board[5]} ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine($"   {board[0]}   |   {board[1]}   |   {board[2]} ");
            Console.WriteLine("       |       |     ");
            Console.WriteLine("Obrigado por jogar, desenvolvido por João Pedro Vargas para o desafio da Klassmatt");
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
            Console.WriteLine("        LEGENDA");
            Console.WriteLine("");
            Console.WriteLine("Use a sequencia do teclado numérico para se guiar");
            Console.WriteLine("");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   7   |   8   |   9 ");
            Console.WriteLine("_______|_______|_______ ");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   4   |   5   |   6  ");
            Console.WriteLine("_______|_______|_______");
            Console.WriteLine("       |       |      ");
            Console.WriteLine("   1   |   2   |   3");
            Console.WriteLine("       |       |     ");
        }
        public static void AnimationStart()
        {
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine("Iniciando o Jogo...");
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
            Console.WriteLine(" Bem vindo ao Jogo da Velha");
            Console.WriteLine(" Aperte enter para começar!");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
