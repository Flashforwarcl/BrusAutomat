namespace InputHandler.BasicCommands
{
    class Help : ICommands
    {
        public string Run()
        {
            var result = "List of commands:";
            foreach (var (key, value) in CommandGenerator.CommandDictionary)
            {
                result += "\n\t" + key;
            }
            return result;
        }
    }
}
