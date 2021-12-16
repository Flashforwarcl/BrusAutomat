using System;
using InputHandler;
using Storage;

namespace BrusAutomat
{
    public class Program
    {
        private static void Main()
        {
            // Console hack for StorageUnits over 13-Width
            Console.BufferHeight = 300;
            Console.BufferWidth = 300;
            /////////////////////////////////////////////////////
            
            var drinks = Drinks.DrinkList;
            //Console.WriteLine(Drinks.DrinkList.Count);
            CommandGenerator.CreateCommands();
            
            while (Checks.IsRunning)
            {
                InputHandler.HandleInput.ReadInput();
                InputHandler.HandleInput.SetResponse();
                InputHandler.HandleInput.PrintResponse();
            }
        }
    }
}
