using System.Linq;

namespace InputHandler.BasicCommands
{
    public class ListParams : ICommands
    {
        public string Run()
        {
         return HandleInput.StringParamsFromInputList.Count <= 0 ? null : HandleInput.StringParamsFromInputList.Aggregate((string) null, (current, s) => current + (s + "\n"));
        }
    }
}