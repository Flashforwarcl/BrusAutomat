using System;
using System.Collections.Generic;
using System.Linq;

namespace InputHandler
{
    public class HandleInput
    {
        public static string Input { get; set; }
        public static string Response { get; set; }
        public static List<string> ParamListFromInput = new();
        public static void ReadInput()
        {
            Input = Console.ReadLine();
            GetParamsFromInput();
        }

        private static void GetParamsFromInput()
        {
            if (!Input.Contains(" ")) return;
            //ParamListFromInput.Clear();
            ParamListFromInput = Input.Split(' ').ToList();
            if (ParamListFromInput.Count <= 1)
            {
                Input = ParamListFromInput[0];
            }
            else
            {
                Input = ParamListFromInput[0];
                ParamListFromInput.RemoveAt(0);
            }
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