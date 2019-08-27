using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LudoGame
{
    class Warehouse
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Warehouse(string Name, int ID)
        {
            this.Name = Name;
            this.ID = ID;
        }
        public Item FindAndReturnItem(int itemID)
        {
            Item returnItem = new Item()
            {
                ID = 101,
                Name = "Microsoft Office"
            };
            return returnItem;
        }
    }

}
