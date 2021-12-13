namespace InputHandler.BasicCommands
{
    public class Exit : ICommands
    {
        public string Run()
        {
            Checks.IsRunning = false;
            return "exit";
        }
    }
}
