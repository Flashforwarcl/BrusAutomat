namespace InputHandler.StorageCommands
{
    public class AddItem : ICommands
    {
        protected readonly string SpecifyParameters = "Specify Name, then the placement as: Height Width Depth";
        public string Run()
        {
            return HandleInput.StringParamsFromInputList.Count != 4 ? SpecifyParameters : Add();
        }

        private static string Add()
        {
            if (!int.TryParse(HandleInput.StringParamsFromInputList[1], out var height)) return $"Could not parse height, passed value:{height}";
            if (!int.TryParse(HandleInput.StringParamsFromInputList[2], out var width)) return $"Could not parse width, passed value:{width}";
            if (!int.TryParse(HandleInput.StringParamsFromInputList[2], out var depth)) return $"Could not parse depth, passed value:{depth}";
            //return Storage.AddStorageUnit.Create(HandleInput.StringParamsFromInputList[0], height, width, depth);
            

            return $"";
        }
    }
}