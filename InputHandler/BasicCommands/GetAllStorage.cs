namespace InputHandler.AdvancedCommands
{
    public class GetAllStorage : ICommands
    {
        public string Run()
        {
            return new Storage.AddStorageUnit().GetAllStorage();
        }
    }
}