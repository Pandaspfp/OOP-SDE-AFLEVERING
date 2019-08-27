using System;

namespace LudoGame
{
    public class Item
    {
            public int ID { get; set; }
            public string Name { get; set; }

        public virtual void Purchase()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        public static Item GetItem()
        {
            var newItem = new Item() { ID = 101, Name = "MyItem" };
            return newItem;
        }
    }

    public class Software : Item
    {
        public string ISBN { get; set; }
        public override void Purchase()
        {
            Console.WriteLine("My ID is {0} and my ISBN is {1}", ID, ISBN);
        }
    }

    public class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    public class Computer : Hardware
    {
        public string CPUType { get; set; }
        string Disks { get; set; }
        public override void Purchase()
        {
            base.Purchase();
            Console.WriteLine("myCPUType is {0}", CPUType);
        }
    }

    public class Peripheral : Hardware
    {
        string Description { get; set; }
    }

}