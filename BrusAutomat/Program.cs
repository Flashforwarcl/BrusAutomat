using System;
using InputHandler;

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
            
            //var drinks = Drinks.DrinkList;
            //Console.WriteLine(Drinks.DrinkList.Count);
            CommandGenerator.CreateCommands();
            
            while (Checks.IsRunning)
            {
                HandleInput.ReadInput();
                HandleInput.SetResponse();
                HandleInput.PrintResponse();
            }
        }
    }
}
