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

            var firstStorageUnit = new Unit(5, 5, 5);

           // firstStorageUnit.AddItemTo(0, 0, Drinks[0]);
            //Console.WriteLine(firstStorageUnit.FindItemAt(0, 0).Name);

            InputHandler.HandleInput.CreateCommands();

            Console.WriteLine(InputHandler.HandleInput.CommandDictionary["ListDrinks"].GetType().GetMethod("Run")
                .Invoke(InputHandler.HandleInput.CommandDictionary["ListDrinks"], null));
            //Console.WriteLine(InputHandler.HandleInput.CommandDictionary["ListDrinks"]);
            

            while (Checks.IsRunning)
            {
                HandleInput.ReadInput();
                HandleInput.SetResponse();
                HandleInput.PrintResponse();
                
            }
        }
    }
}
