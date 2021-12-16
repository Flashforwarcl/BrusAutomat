namespace InputHandler.AdvancedCommands
{
    public class NewStorage : ICommands
    {
        protected readonly string SpecifyParameters = "You must specify parameters in this order: Name, Height, Width, Depth";
        public string Run()
        {
            return HandleInput.ParamListFromInput.Count != 4 ? SpecifyParameters : CreateUnit();
        }

        private static string CreateUnit()
        {
            if (!int.TryParse(HandleInput.ParamListFromInput[1], out var height)) return $"Could not parse height, passes value:{height}";
            if (!int.TryParse(HandleInput.ParamListFromInput[2], out var width)) return $"Could not parse width, passes value:{width}";
            if (!int.TryParse(HandleInput.ParamListFromInput[2], out var depth)) return $"Could not parse depth, passes value:{depth}";
            new Storage.AddStorageUnit().Create(HandleInput.ParamListFromInput[0], height, width, depth);
            return $"StorageUnit:{HandleInput.ParamListFromInput[0].ToLower()} with spec:{HandleInput.ParamListFromInput[1]}.{HandleInput.ParamListFromInput[2]}.{HandleInput.ParamListFromInput[3]} was created.";
        }
    }
}