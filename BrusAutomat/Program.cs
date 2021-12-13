using System.Collections.Generic;
using Storage.Items;

namespace BrusAutomat
{
    public class Program
    {
        // Make a list of Drinks
        public static IItems[] ListOfDrinks = {
            new Drink("Solo", 5),
            new Drink("Coca Cola", 5),
            new Drink("Apple Juice")
        };
        public static List<IItems> Drinks = new(ListOfDrinks);
        private static void Main()
        {
            var vendingMachine = new Storage.StorageUnit.Unit(53, 3, 1);
            //Console.WriteLine(Drinks.DrinkList.Count);
            InputHandler.HandleInput.CreateCommands();
            vendingMachine.AddItemTo(15, 1, Drinks[0]);
            vendingMachine.FindAllItemsAtFrontOfStorage();

            while (Checks.IsRunning)
            {
                InputHandler.HandleInput.ReadInput();
                InputHandler.HandleInput.SetResponse();
                InputHandler.HandleInput.PrintResponse();
            }
        }
    }
}
