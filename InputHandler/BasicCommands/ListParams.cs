using System.Linq;

namespace InputHandler.BasicCommands
{
    public class ListParams : ICommands
    {
        public string Run()
        {
         return HandleInput.ParamListFromInput.Count <= 0 ? null : HandleInput.ParamListFromInput.Aggregate((string) null, (current, s) => current + (s + "\n"));
        }
    }
}