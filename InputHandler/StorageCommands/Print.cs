namespace InputHandler.StorageCommands
{
    public class Print : ICommands
    {
        protected readonly string SpecifyParameters = "You must specify a single Name as a parameter";
        public string Run()
        {
        return HandleInput.StringParamsFromInputList.Count != 1 ? SpecifyParameters : Storage.AddStorageUnit.PrintAllItems(InputHandler.HandleInput.StringParamsFromInputList[0]);
        }
    }
}