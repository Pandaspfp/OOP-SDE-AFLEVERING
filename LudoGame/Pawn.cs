using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Pawn
    {
        // Status consist of 1 "In Nest"
        // Status consist of 2 "On Board"
        // Status consist of 3 "Last Run"
        // Status consist of 4 "Finish"
        public string status { get; set; }
        public int number { get; set; }
        public string color { get; set; }
        public int position { get; set; }

        public Pawn(string status, int number, string color, int position)
        {
            this.status = status;
            this.number = number;
            this.color = color;
            this.position = position;
        }

        public Pawn()
        {

        }

        public void ChangePawnStatus(string status)
        {
            // Status consist of 1 "In Nest"
            // Status consist of 2 "On Board"
            // Status consist of 3 "Last Run"
            // Status consist of 4 "In Goal"
            switch (status)
            {
                case "In Nest":
                    status = "On Board";
                    break;
                case "On Board":
                    status = "Last Run";
                    break;
                case "Last Run":
                    status = "In Goal";
                    break;
                default:
                    Console.WriteLine("The pawn is in goal!");
                    break;
            }
        }

        public void PawnColor(Pawn[]pawnArray, string pawnColor)
        {
            foreach (Pawn pawn in pawnArray)
            {
                if (pawn.color == pawnColor)
                    Console.WriteLine("Status {0} {1}Pawn {2} position {3}", pawn.status, pawn.number, pawn.color, pawn.position);
            }
        }

        public void ShowPawnOnBoard()
        {

        }

        public string GeneratePawns(int numOfPawnsPerPlayer, string[]colors)
        {
            // Generate Pawns
            foreach (string color in colors)
            {
                    string pawns = "pawn" + color;

                    Console.WriteLine(pawns);
            }

            return "wups";
        }

        //public Pawn(String color, int startX, int startY)
        //{
        //    this.color = color;
        //    _x = startX;
        //    _y = startY;
        //}

        //private void generatePieces(Colors color)
        //{
        //    pieces[(int)color] = new Piece[numOfPiecesPerPlayer];
        //    for (int i = 0; i < numOfPiecesPerPlayer; i++)
        //    {
        //        pieces[(int)color][i] = new Piece(color, i);
        //    }
        //}


    }
    
}
