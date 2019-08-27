using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] colors = { "Blue", "Red", "Green", "Yellow" };
            int[] numOfPlayersArray = { 1,1,1,1 };          
            int[] fields = { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40 };
            int[] finalFields = { 1,2,3,4,5};
            string InNest = "InNest";
            string OnBoard = "OnBoard";
            string LastRun = "LastRun";
            string InGoal = "InGoal";
            string roll;
            string endGame = "";
            int newPawnPosition;          
            int die = 0;
            int rounds = 0;
            int countRoll = 0;
            int arrayFieldsCount = fields.Count();
            int arrayFinalFields = arrayFieldsCount + finalFields.Count();


            // My Array of pawns
            Pawn[] arrayPawns = new Pawn[16];

            arrayPawns[0] = new Pawn("InNest", 1, "Blue", 0);
            arrayPawns[1] = new Pawn("InNest", 2, "Blue", 0);
            arrayPawns[2] = new Pawn("InNest", 3, "Blue", 0);
            arrayPawns[3] = new Pawn("InNest", 4, "Blue", 0);

            arrayPawns[4] = new Pawn("InNest", 1, "Red", 0);
            arrayPawns[5] = new Pawn("InNest", 2, "Red", 0);
            arrayPawns[6] = new Pawn("InNest", 3, "Red", 0);
            arrayPawns[7] = new Pawn("InNest", 4, "Red", 0);

            arrayPawns[8] = new Pawn("InNest", 1, "Green", 0);
            arrayPawns[9] = new Pawn("InNest", 2, "Green", 0);
            arrayPawns[10] = new Pawn("InNest", 3, "Green", 0);
            arrayPawns[11] = new Pawn("InNest", 4, "Green", 0);

            arrayPawns[12] = new Pawn("InNest", 1, "Yellow", 0);
            arrayPawns[13] = new Pawn("InNest", 2, "Yellow", 0);
            arrayPawns[14] = new Pawn("InNest", 3, "Yellow", 0);
            arrayPawns[15] = new Pawn("InNest", 4, "Yellow", 0);

            // List of pawns categories by color
            List<Pawn> bluePawn = arrayPawns.Where(p => p.color == "Blue").ToList();
            List<Pawn> redPawn = arrayPawns.Where(p => p.color == "Red").ToList();          
            List<Pawn> greenPawn = arrayPawns.Where(p => p.color == "Green").ToList();
            List<Pawn> yellowPawn = arrayPawns.Where(p => p.color == "Yellow").ToList();

            // Foreach loop of pawn colors
            bluePawn.ForEach(p => {
                Console.WriteLine("{0} number and color {1}", p.number, p.color);
            });

            redPawn.ForEach(p => {
                Console.WriteLine("{0} number and color {1}", p.number, p.color);
            });



            // Calling my Classes      
            Dize DizeOptions = new Dize();           
            Board board = new Board();
            Pawn getPawns = new Pawn();
            Player shufflePlayer = new Player();

            // Board display and number of players        
            board.DisplayBoard();
            board.NumberOfPlayers();

            // Shuffle players to decide who goes first           
            string[] shuffle = shufflePlayer.RandomizeStrings(colors);

            //board.ShowBoard();

            // Game Start
            do
            {
                rounds++;

                // Using this foreach statement to check the data
                foreach (Pawn pawnse in arrayPawns)
                {
                    Console.WriteLine("Status ({0}) {2} pawn {1} with position {3}", pawnse.status, pawnse.number, pawnse.color, pawnse.position);
                }

                // For each player by colors
                foreach (string colorid in shuffle)
                {
                Player player = new Player(colorid);
                    int checkInGoalPawns = 0;

                // Display of players turn
                Console.WriteLine("\n{0} player turn", player.colorID);
                Console.ReadLine();

                    // For each pawn do this.
                    foreach (Pawn pawn in arrayPawns)
                    {

                    if (pawn.position >= arrayFieldsCount)
                    {
                        pawn.status = LastRun;
                    }

                    if (pawn.position >= arrayFinalFields)
                    {
                        pawn.status = InGoal;
                    }

                        // In Nest statement
                        if (pawn.color == colorid && pawn.status == InNest)
                        {

                                Console.WriteLine("In nest {1} Pawn {0} with position {2}", pawn.number, pawn.color, pawn.position);
                                Console.WriteLine("Roll 6 to move pawn out");
                                Console.WriteLine("\nPress enter to Roll");
                                roll = Console.ReadLine();

                                if (roll != "e")
                                {
                                
                                    do
                                    {                                  
                                    countRoll++;
                                    // Random dize Start and display of roll
                                    die = DizeOptions.RollDize();
                                    Console.WriteLine("\n{0} player rolled:", player.colorID);
                                    DizeOptions.DisplayRoll(die);
                                    Console.ReadLine();
                                    } while (die != 6 && countRoll < 3);

                                    // If Dize rolled 6 take pawn out on the board
                                    if (die == 6)
                                    {
                                        pawn.status = OnBoard;
                                        Console.WriteLine("\n{1} Pawn {0}  is now on the board", pawn.number, pawn.color);
                                        Console.ReadLine();
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Sorry you didnt roll 6");
                                        Console.ReadLine();
                                        break;
                                    }
                                    
                                }
                  
                        Console.ReadLine();
                        }

                        // On Board statement
                        else if (pawn.color == colorid && pawn.status == OnBoard && pawn.position <= arrayFieldsCount)
                        {
                            Console.WriteLine("On board {1} Pawn {0} with position {2}", pawn.number, pawn.color, pawn.position);
                            Console.WriteLine("\nPress enter to Roll");
                            roll = Console.ReadLine();

                            if (roll != "e")
                            {
                                // Random dize Start and display of roll
                                die = DizeOptions.RollDize();
                                Console.WriteLine("\n{0} player rolled:", player.colorID);
                                DizeOptions.DisplayRoll(die);

                                // Giver pawn en ny position ud fra terning kastet
                                newPawnPosition = DizeOptions.AddDizeNumber(pawn.position, die);
                                pawn.position = newPawnPosition;
                                Console.WriteLine("New pawn position is " + newPawnPosition + "/40");
                                Console.ReadLine();
                                break;
                            }

                        }

                        // Last Run statement
                        else if (pawn.color == colorid && pawn.status == LastRun)
                        {
                            Console.WriteLine("Almost in goal! Pawn {0} {1} with position {2}/45", pawn.number, pawn.color, pawn.position);
                            Console.WriteLine("\nPress enter to Roll");
                            roll = Console.ReadLine();

                            if (roll != "e")
                            {
                                // Random dize Start and display of roll
                                die = DizeOptions.RollDize();
                                Console.WriteLine("\n{0} player rolled:", player.colorID);
                                DizeOptions.DisplayRoll(die);

                                // Giver pawn en ny position ud fra terning kastet
                                newPawnPosition = DizeOptions.AddDizeNumber(pawn.position, die);
                                pawn.position = newPawnPosition;

                                // Hvis pawn position er større end 45 altså slut position minus rest værdien og gør dette til den nye værdi
                                if (pawn.position > 45)
                                {
                                    Console.WriteLine("Your roll didnt match the final position");
                                    newPawnPosition = DizeOptions.SubtractDizeNumber(pawn.position, die);
                                    pawn.position = newPawnPosition;
                                }

                                Console.WriteLine("New pawn position is " + newPawnPosition + "/45");
                                Console.ReadLine();
                                break;
                            }
                        }

                        // In Goal statement
                        else if (pawn.color == colorid && pawn.status == InGoal)
                        {
                            checkInGoalPawns++;
                            Console.WriteLine("In Goal! {1} Pawn {0}", pawn.number, pawn.color);

                            if(checkInGoalPawns == 4)
                            {
                                Console.WriteLine("Congratulations you won the game ! {0}", player.colorID);
                                Console.ReadLine();
                                endGame = "e";
                            }
                        }

                    }

                }
                // Next players turn.
                Console.WriteLine("Rounds played " + rounds);
                Console.WriteLine("Press enter to keep playing");
                Console.WriteLine("\t e - Escape");
                Console.Write("Your option? ");

            } while (Console.ReadLine() != "e" | endGame != "e");
            // Wait for respond before closing.
            Console.Write("Press any key to close the game...");
            Console.ReadKey();
            // Game End

        }

    }
}
