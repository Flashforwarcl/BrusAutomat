using InputHandler;

namespace BrusAutomat.Commands
{
    class ListCommands : ICommands
    {
        public string Run()
        {
            var result = "List of commands:";
            foreach (var (key, value) in InputHandler.HandleInput.CommandDictionary)
            {
                result += "\n\t" + key;
            }
            return result;
        }
    }
}
