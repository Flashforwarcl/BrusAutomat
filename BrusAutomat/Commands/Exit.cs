using InputHandler;

namespace BrusAutomat.Commands
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
