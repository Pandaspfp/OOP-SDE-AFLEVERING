using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Field
    {
        public int x;
        public int y;
        public string color;

        public Field(int x, int y, string color)
        {      
            this.x = x;
            this.y = y;
            this.color = color;
        }

        public void ShowField()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("(X)");
        }
    }
}
