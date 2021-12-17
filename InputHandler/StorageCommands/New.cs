namespace InputHandler.StorageCommands
{
    public class New : ICommands
    {
        protected readonly string SpecifyParameters = "You must specify parameters in this order: Name, Height, Width, Depth";
        public string Run()
        {
            return HandleInput.StringParamsFromInputList.Count != 4 ? SpecifyParameters : CreateUnit();
        }

        private static string CreateUnit()
        {
            if (!int.TryParse(HandleInput.StringParamsFromInputList[1], out var height)) return $"Could not parse height, passes value:{height}";
            if (!int.TryParse(HandleInput.StringParamsFromInputList[2], out var width)) return $"Could not parse width, passes value:{width}";
            if (!int.TryParse(HandleInput.StringParamsFromInputList[2], out var depth)) return $"Could not parse depth, passes value:{depth}";
            return Storage.AddStorageUnit.Create(HandleInput.StringParamsFromInputList[0], height, width, depth);
            // return $"StorageUnit:{HandleInput.StringParamsFromInputList[0].ToLower()} with spec:{HandleInput.StringParamsFromInputList[1]}.{HandleInput.StringParamsFromInputList[2]}.{HandleInput.StringParamsFromInputList[3]} was created.";
        }
    }
}