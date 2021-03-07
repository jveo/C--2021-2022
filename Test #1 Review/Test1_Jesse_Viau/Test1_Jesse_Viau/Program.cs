using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test1_Jesse_Viau {
    class Program {

        static void Main(string[] args) {
            GameEngine engine = new GameEngine();
            Validation checker = new Validation();
            

            engine.drawWelcomeMenu();
            
            /*
             checks to see the user input. 
                *if input is the ENTER key, the game will proceed
                *else the program exits
             */
            if (Console.ReadKey().Key != ConsoleKey.Enter){
                Console.WriteLine("\nError: Invalid Entry");
                Thread.Sleep(1000);
                Environment.Exit(0);
            }

            Player player1 = new Player();
            Player player2 = new Player();

            Console.WriteLine(player1.card);
            Console.WriteLine(player2.card);


            
            
           /*
            do while loop to keep playing until a user wins with a score of 7
            */
            Boolean playing = true;

            /*
            do {

                engine.play(player1, player2);
                


                Console.ReadLine();
            } while (playing);
            */



            Console.ReadLine();
        }



    }
}
