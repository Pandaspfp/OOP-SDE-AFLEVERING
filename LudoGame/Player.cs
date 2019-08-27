using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Player
    {
        // Properties
        public string colorID { get; set; }

        // Constructor
        public Player(string colorid)
        {
            colorID = colorid;
        }

        // Default Constructor
        public Player()
        {

        }

        static Random _random = new Random();

        public string[] RandomizeStrings(string[] arr)
        {
            // Add all strings from array.
            List<KeyValuePair<int, string>> list = new List<KeyValuePair<int, string>>();

            // Add new random int each time.
            foreach (string s in arr)
            {
                list.Add(new KeyValuePair<int, string>(_random.Next(), s));
            }

            // Sort the list by the random number.
            var sorted = from item in list
                         orderby item.Key
                         select item;

            // Allocate new string array.
            string[] result = new string[arr.Length];

            // Copy values to array.
            int index = 0;
            foreach (KeyValuePair<int, string> pair in sorted)
            {
                result[index] = pair.Value;
                index++;
            }
            // Return copied array.
            return result;
        }


        public string GeneratePlayers(int numOfPlayers)
        {

            // Generate Players
            for (int i = 0; i < numOfPlayers; i++)
            {
                string players = "player" + i;

                Console.WriteLine(players);
            }
            return "wups";
        }




    }
}
