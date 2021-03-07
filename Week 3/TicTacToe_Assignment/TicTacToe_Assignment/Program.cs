using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Assignment{

    class Program : validator {

        static void Main(string[] args) {

            char[] gameBoardSpots = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

            Console.WriteLine(gameBoardSpots[0]);

            Console.WriteLine("Enter first Player's name: ");
            string player1 = Console.ReadLine();

            Console.WriteLine("Enter second Player's name: ");
            string player2 = Console.ReadLine();


            bool playing = true;
            int rounds = 1;

            do {

                //PLAYER 1
                initGameBoard(gameBoardSpots);
                Console.WriteLine($"Round: {rounds}");
                Console.WriteLine($"{player1} ( X ) - Enter move:");
                String userMove1 = Console.ReadLine();
                int userMoveNumber1 = Convert.ToInt16(userMove1);
                gameBoardSpots[userMoveNumber1-1] = 'X';
              
                Console.Clear();


                //PLAYER 2
                initGameBoard(gameBoardSpots);
                Console.WriteLine($"{player2} ( O ) - Enter move:");
                String userMove2 = Console.ReadLine();
                int userMoveNumber2 = Convert.ToInt16(userMove2);
                Console.WriteLine(userMoveNumber2);
                gameBoardSpots[userMoveNumber2 - 1] = 'O';
                Console.Clear();
              

                rounds++;

                if (rounds >= 3) {
                    hasWon(gameBoardSpots, gameBoardSpots[0], gameBoardSpots[3], gameBoardSpots[6], player1, player2, playing);
                }

                /*if (gameBoardSpots[0] == gameBoardSpots[3] && gameBoardSpots[3] == gameBoardSpots[6]) {
                    if (gameBoardSpots[0] == 'X') {
                        Console.WriteLine($" {player1} won with a vertical match!");
                    }
                }*/

            } while (playing == true);




            Console.ReadLine();
        }


        /*
        
        initGameBoard Method returns the TicTacToe Game Board 

        @params String array of the possible player chosen positions
    
         */

        private static void initGameBoard(char[] gameBoardSpots){



            Console.WriteLine($"    |    |    ");
            Console.WriteLine($"  {gameBoardSpots[0]} |  {gameBoardSpots[1]} |  {gameBoardSpots[2]} ");
            Console.WriteLine($" ----+---+----");
            Console.WriteLine($"    |    |    ");
            Console.WriteLine($"  {gameBoardSpots[3]} |  {gameBoardSpots[4]} |  {gameBoardSpots[5]} ");
            Console.WriteLine($" ----+---+----");
            Console.WriteLine($"    |    |    ");
            Console.WriteLine($"  {gameBoardSpots[6]} |  {gameBoardSpots[7]} |  {gameBoardSpots[8]} ");

       
        }

       

      


    }
}
