using System;

namespace FInalTest_pt5
{
    class Program
    {
        //ข้อ5
        struct ItemProperty
        {
            public string ItemName;
            public string ItemType;
        }

        static void Main(string[] args)
        {
            int ItemNumber = int.Parse(Console.ReadLine());
            ItemProperty[] Item = new ItemProperty[ItemNumber];
            for (int i = 0; i <= ItemNumber; i++)
            {
                Item[i].ItemName = Console.ReadLine();
                Item[i].ItemType = Console.ReadLine();
            }

            string mode = Console.ReadLine();
            if(mode == "Showall")
            {
                Console.WriteLine(Item);
            }
        }
    }
}
