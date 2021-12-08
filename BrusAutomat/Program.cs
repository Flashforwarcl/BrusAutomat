namespace BrusAutomat
{
    public class Program
    {
        private static void Main()
        {
            //Console.WriteLine(Drinks.DrinkList.Count);
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
