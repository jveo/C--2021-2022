using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Jesse_Viau {
    class Validation {
         
        /*
         this method requires two strings to check if they are equal and returns a header along with a bool
        if so return true
        else return false
         */
        public static Boolean checkIfTie(string p1Card, string p2Card) {
            if (p1Card == p2Card) {
                Console.WriteLine("             >>>>>>>>> WAR <<<<<<<<<");
                return true;
            }
            return false;
        }

        /*
         method takes in two Player object params to compare
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "J",
            "Q",
            "K",
            "A"

        values to each other to decide who wins. 
        from values 2-10 this method takes the two Player object params and parses as an int to compare

        else

        manually compares the letters (Face Cards) to each other
         */
        public static void whoWins(Player p1, Player p2) {

                int.TryParse(p1.card, out var playerCard1);
                int.TryParse(p1.card, out var playerCard2);
            if (p1.card == "10" && p2.card == "J") {
                p2.score++;
                Console.WriteLine($"Player 2 wins {p2.score} Points");
            }

            if (p1.card == "J" && p2.card == "10") {
                p1.score++;
                Console.WriteLine($"Player 1 wins {p1.score} Points");
            }

            if (p1.card == "J" && p2.card == "Q") {
                p2.score++;
                Console.WriteLine($"Player 2 wins {p2.score} Points");
            }
            if (p1.card == "Q" && p2.card == "J") {
                p1.score++;
                Console.WriteLine($"Player 1 wins {p1.score} Points");
            }

            if (p1.card == "Q" && p2.card == "K") {
                p2.score++;
                Console.WriteLine($"Player 2 wins {p2.score} Points");
            }

            if (p1.card == "K" && p2.card == "Q") {
                p1.score++;
                Console.WriteLine($"Player 1 wins {p1.score} Points");
            }

            if (p1.card == "K" && p2.card == "A") {
                p2.score++;
                Console.WriteLine($"Player 2 wins {p2.score} Points");
            }

            if (p1.card == "A" && p2.card == "K") {
                p1.score++;
                Console.WriteLine($"Player 1 wins {p1.score} Points");
            }

            if (playerCard1 < playerCard2) {
                p2.score++;
                Console.WriteLine($"Player 2 wins {p2.score} Points");
            }

            if (playerCard1 > playerCard2) {
                p1.score++;
                Console.WriteLine($"Player 1 wins {p1.score} Points");
            }

            if (p1.score == 7) {
                Console.WriteLine($"Player 1 wins with {p1.score} points");
            }
            if (p2.score == 7) {
                Console.WriteLine($"Player 1 wins with {p2.score} points");
            }


        }

    }
}
