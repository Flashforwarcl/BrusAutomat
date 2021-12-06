namespace InputHandler
{
    public class Eatables : ICommands
    {
        public string Name()
        {
            return GetType().Name;
        }

        public string Run()
        {
            return "This is an Eatable";
        }
    }
}