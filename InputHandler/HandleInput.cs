using System;

namespace InputHandler
{
    public class HandleInput
    {
        public static string Input { get; set; }
        public static string Response { get; set; }

        public static void ReadInput()
        {
            Input = Console.ReadLine();
        }
        public static void SetResponse()
        {
            Response = InputCommand(Input);
        }
        public static void PrintResponse()
        {
            Console.WriteLine(Response);
        }
        public static string InputCommand(string command)
        {
            var commandAsLower = command.ToLower();
            var output = "Unknown command.\nTry: help, to show all available commands";
            if (CommandGenerator.CommandDictionary.TryGetValue(commandAsLower, out var result))
            {
                output = (string) result.GetType().GetMethod("Run")?.Invoke(result, null);
            }
            return output;
        }
    }
}