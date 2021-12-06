namespace InputHandler
{
    public class ListDrinks : ICommands
    {
        public string Name()
        {
            return GetType().Name;
        }

        public bool IsCommand = true;

        public string Run()
        {
           return "TEst";
        }
    }
}