using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Jesse_Viau {

    class Card {

        char cardSuit { get; set; }
        string cardFace { get; set; }
        private Card(char suit, string face) {
            this.cardSuit = suit;
            this.cardFace = face;
        }

        public Card() { }

        private char[] suits = {
             '♥',
             '♦',
             '♣',
             '♠'
        };

        private string[] faces = {
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
        };

       



        /*
         
        Prints a random card and pairs it with a random suit from the above
        Private arrays
         
         */
        public Card drawCard() {
            Random r = new Random();
            Shuffle(faces);
            int suitIndx = r.Next(suits.Length);
            Card result = new Card(suits[suitIndx], faces[0]);

            Shuffle(faces);
            return result;

        }

        /*
         DOESN'T WORK
         
        attemps to randomize the printCard method so that it doesn't output the same randomized
        index each time.
         */
        private void Shuffle(string[] arr) {
            Random r = new Random();
            for (int i = arr.Length; i > 1; i--) {
                int pos = r.Next(i);
                var x = arr[i - 1];
                arr[i - 1] = arr[pos];
                arr[pos] = x;
            }
        }


    }
    


}
