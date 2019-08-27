using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Board
    {
        private Field[] felterne = new Field[40];

        public Board()
        {
            felterne[0] = new Field(1, 10, "Blue");
            felterne[1] = new Field(11, 20, "Red");
            felterne[2] = new Field(21, 30, "Green");
            felterne[3] = new Field(31, 40, "Yellow");
        }

        public void ShowBoard()
        {
            foreach (Field f in felterne)
            {
                f.ShowField();
            }
        }

        public void DisplayBoard()
        {
            Console.WriteLine("////////////////////////////////////////////////////");
            Console.WriteLine("//                                                //");
            Console.WriteLine("//             WELCOME TO LUDO WTHIGO             //");
            Console.WriteLine("//                                                //");
            Console.WriteLine("////////////////////////////////////////////////////");
            Console.WriteLine("////////////////////////////////////////////////////");
            Console.WriteLine("//                                                //");
            Console.WriteLine("//    //////////    (08)(09)(10)    /////////     //");
            Console.WriteLine("//    ///BLUE///    (07)(R1)(11)    // RED //     //");
            Console.WriteLine("//    //////////    (06)(R2)(12)    /////////     //");
            Console.WriteLine("//                  (05)(R3)(13)                  //");
            Console.WriteLine("//  (40)(01)(02)(03)(04)(R4)(14)(15)(16)(17)(18)  //");
            Console.WriteLine("//  (39)(B1)(B2)(B3)(B4)(FF)(G4)(G3)(G2)(G1)(19)  //");
            Console.WriteLine("//  (38)(37)(36)(35)(34)(R4)(24)(23)(22)(21)(20)  //");
            Console.WriteLine("//                  (33)(R3)(25)                  //");
            Console.WriteLine("//    //////////    (32)(R2)(26)    /////////     //");
            Console.WriteLine("//    ///YELOW//    (31)(R1)(27)    //GREEN//     //");
            Console.WriteLine("//    //////////    (30)(29)(28)    /////////     //");
            Console.WriteLine("//                                                //");
            Console.WriteLine("////////////////////////////////////////////////////");
            Console.WriteLine("");

        }

        public void NumberOfPlayers()
        {
            int numOfPlayers = 0;
            Console.WriteLine("How many players would you like to play? you can choose from 2-4");
            Console.WriteLine("\t2 - 2 players");
            Console.WriteLine("\t3 - 3 players");
            Console.WriteLine("\t4 - 4 players");
            Console.Write("Your option? ");
            numOfPlayers = Convert.ToInt16(Console.ReadLine());
        }
    }
}
