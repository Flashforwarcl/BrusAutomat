using InputHandler;

namespace BrusAutomat.Commands
{
    class Exit : ICommands
    {
        public string Run()
        {
            Checks.IsRunning = false;
            return "exiting";
        }
    }
}
