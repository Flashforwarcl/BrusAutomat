using System;
using System.Collections.Generic;
using BrusAutomat.Storage;

namespace BrusAutomat
{
    public class Program
    {
        // Make list of items
        public static Item[] items = {
            new("Solo", 5),
            new("Coca Cola", 5),
            new("Apple Juice")
        };
        public List<Item> ItemList = new List<Item>(items);
        static void Main(string[] args)
        {
            //  Create StorageUnit, takes 3 int parameters.
            //  var UnitName = new StorageUnit(Height, Width, Depth)
            //
            //  target a Stack at position 0 0
            //  UnitName.Storage.VerticalList[0].HorizontalList[0]
            var StorageUnit1 = new StorageUnit(5, 5, 5);
            

            while (Checks.IsRunning)
            {
                HandleInput.ReadInput();
                HandleInput.SetResponse();
                HandleInput.PrintResponse();
                
            }

        }

    }
}
