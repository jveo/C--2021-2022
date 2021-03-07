using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_Jesse_Viau {


    /*
     
    getter setter score Integer
    getter setter card string that is populated with the printCard Method from Card Class
     
     */

    class Player : Card {

        public int score { get; set; }
        public Card card { get; set; }
     
        /*
         Whenever a Player() object is created
            * the card variable is populated
            * score variable is initlized
         */
        public Player() {
            card = drawCard();
            score = 0;
          
        }



    }
   
}



