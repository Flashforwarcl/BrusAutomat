namespace BrusAutomat
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (Checks.IsRunning)
            {
                HandleInput.ReadInput();
                HandleInput.SetResponse();
                HandleInput.PrintResponse();
            }
        }

    }
}
