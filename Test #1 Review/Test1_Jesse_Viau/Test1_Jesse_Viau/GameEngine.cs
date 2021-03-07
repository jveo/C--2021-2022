using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Jesse_Viau {
    class GameEngine : Player {

        Validation validation = new Validation();
        public int round;


        /*
         drawWelcomeMenu

            Outputs the Console Header 


                *****************************
                *Welcome to the game of WAR!*
                *****************************
         */
        public void drawWelcomeMenu() {
            for (int i = 0; i <= 31; i++) {
                Console.Write("*");
            }
            Console.Write("\n| Welcome to the game of WAR! |\n");
            for (int i = 0; i <= 31; i++) {
                Console.Write("*");
            }
            Console.Write("\nPress <enter> to begin...\n");
        }


        /*
         
         General Game Logic Including Validation
         aswell as general menu output
         
         */
        public void play(Player player1, Player player2) {
            round++;
            Console.WriteLine($"P1 Score: {player1.score}               P2 Score: {player2.score}");
            Console.WriteLine($"Round: {round}");
            Console.WriteLine($"Player 1 plays: {player1.card}              Player 2 plays: {player2.card}");


            
        }



    }
}
