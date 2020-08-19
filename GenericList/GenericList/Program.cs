using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
           // var r = new Random();
           // List<int> myList = new List<int>();
           // for (int i = 0; i < 10; i++)
           // {
           //     myList.Add(r.Next());
           // }
            
           // myList.Sort();

           // foreach (int i in myList)
           // {
           //     Console.WriteLine(i);
           // }

           List<Item> myItems = Item.GetItems(20);
           foreach (Item item in myItems)
           {
               Console.WriteLine("New item ID = {0}, name = {1}", item.ID, item.Name);
           }
        }
    }
}