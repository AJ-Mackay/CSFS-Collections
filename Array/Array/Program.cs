using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            // var items = new Item[5];
            // Random r = new Random();
            // for (int i = 0; i < items.Length; i++)
            // {
            //    items[i] = new Item(r.Next());
            // }
            
            // Console.WriteLine("Items: ");
            // foreach (Item item in items)
            // {
            //    Console.WriteLine("ItemID = {0}", item.ID);
            // }

            // Item myItem = items[1];
            // Console.WriteLine("ID of second item = {0}", myItem.ID);

            var Authors = new String[5];
            Authors[0] = "Faulkner";
            Authors[1] = "Proust";
            Authors[2] = "Stephenson";
            Authors[3] = "Gibson";
            Authors[4] = "Melville";
            
            Console.WriteLine("Authors...");
            foreach (string s in Authors)
            {
                Console.WriteLine(s);
            }

            System.Array.Sort(Authors);
            
            Console.WriteLine("Authors...");
            foreach (string s in Authors)
            {
                Console.WriteLine(s);
            }
        }
    }
}