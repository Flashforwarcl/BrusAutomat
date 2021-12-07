using System;
using System.Collections.Generic;
using InputHandler;
using Storage.Items;
using Storage.StorageUnit;
using HandleInput = BrusAutomat.CommandHandling.HandleInput;

namespace BrusAutomat
{
    public class Program
    {
        // Make list of Drinks
        public static IItems[] ListOfDrinks = {
            new Drink("Solo", 5),
            new Drink("Coca Cola", 5),
            new Drink("Apple Juice")
        };
        public static List<IItems> Drinks = new(ListOfDrinks);


        private static void Main()
        {
            //  Create Unit, takes 3 int parameters.
            //  var UnitName = new Unit(Height, Width, Depth)
            //
            //  Add item at position V:0 H:0 (Drinks[0] is here a "Solo" from the list Drinks)
            //  UnitName.AddItemTo(0, 0, Drinks[0]);
            //
            //  find item at position V:0 H:0
            //  UnitName.FindItemAt(0,0)
            //
            /*
            var vendingMachine = new Storage.StorageUnit.Unit(5, 5, 5);
            vendingMachine.AddItemTo(0, 0, Drinks[0]);
            Console.WriteLine(vendingMachine.FindItemAt(0, 0).Name);
            */
            InputHandler.HandleInput.CreateCommands();

            while (Checks.IsRunning)
            {
                InputHandler.HandleInput.ReadInput();
                InputHandler.HandleInput.SetResponse();
                InputHandler.HandleInput.PrintResponse();
            }
        }
    }
}
