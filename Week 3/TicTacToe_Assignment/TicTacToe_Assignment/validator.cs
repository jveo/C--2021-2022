using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe_Assignment {
    class validator {

        public static String hasWon(char[] board, int pos1, int pos2, int pos3, String player1, String player2, Boolean playing) {
            //int.TryParse(stringPos1, out var pos1);
            //int.TryParse(stringPos2, out var pos2);
            //int.TryParse(stringPos3, out var pos3);

            if (board[pos1].Equals(board[pos2]) && board[pos2].Equals(board[pos3])) {
                if (board[pos1] == 'X') {
                    return $"{player1} has won with a vertical match!";
                    playing = false;
                }
               
            }
            return "Draw !";
        }


        public static bool same(String[] gameBoardSpots, int position1, int position2, int position3) {
            return gameBoardSpots[position1].Equals(position2) && gameBoardSpots[position2].Equals(position3);
        }

    }
}
