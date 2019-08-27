using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Dize
    {
        public int RollDize()
        {
            Random dice = new Random();
            int res = dice.Next(1, 7);
            return res;
        }

        public int AddDizeNumber(int position, int number)
        {
            position = position + number;
            return position;
        }

        public int SubtractDizeNumber(int position, int number)
        {
            position = position - number;
            return position;
        }

        public void DisplayRoll(int caseSwitch)
        {
            switch (caseSwitch)
            {
                case 1:
                    Console.WriteLine("/////////");
                    Console.WriteLine("//  1  //");
                    Console.WriteLine("/////////");
                    break;
                case 2:
                    Console.WriteLine("/////////");
                    Console.WriteLine("//  2  //");
                    Console.WriteLine("/////////");
                    break;
                case 3:
                    Console.WriteLine("/////////");
                    Console.WriteLine("//  3  //");
                    Console.WriteLine("/////////");
                    break;
                case 4:
                    Console.WriteLine("/////////");
                    Console.WriteLine("//  4  //");
                    Console.WriteLine("/////////");
                    break;
                case 5:
                    Console.WriteLine("/////////");
                    Console.WriteLine("//  5  //");
                    Console.WriteLine("/////////");
                    break;
                case 6:
                    Console.WriteLine("/////////");
                    Console.WriteLine("//  6  //");
                    Console.WriteLine("/////////");
                    break;
                default:
                    Console.WriteLine("Invalid number");
                    break;
            }
        }

    }
}
