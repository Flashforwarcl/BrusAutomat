namespace InputHandler.StorageCommands
{
    public class GetAll : ICommands
    {
        public string Run()
        {
            return Storage.AddStorageUnit.GetAllStorage();
        }
    }
}