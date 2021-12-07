using System;
using System.Collections.Generic;
using System.Reflection;

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

        public static void PrintResponse()
        {
            Console.WriteLine(Response);
        }

        public static void SetResponse()
        {
            Response = InputCommand(Input);
        }

        public static string InputCommand(string command)
        {
            var commandAsLower = command.ToLower();
            var output = "Unknown command.\nTry: listcommands, to show all available commands";
            if (CommandDictionary.TryGetValue(commandAsLower, out var result))
            {
                output = (string) result.GetType().GetMethod("Run")?.Invoke(result, null);
            }
            return output;
        }

        public static Dictionary<string, object> CommandDictionary { get; } = new();
 
        public static void CreateCommands()
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var command = assembly.GetType();
            //var runMethod = command.GetMethod("Run");
            //var initiatedObject = Activator.CreateInstance(command);
            //runMethod.Invoke(initiatedObject, null);

            //var assembly = Assembly.GetExecutingAssembly();   // commands using ICommands that are located inside Inputhandler
            var assembly = Assembly.GetCallingAssembly();       // commands using ICommands that are located inside class calling Inputhandler
            var typesOfICommands = TypeLoaderExtensions.GetTypesWithInterface(assembly);
            foreach (var command in typesOfICommands)
            {
                CommandDictionary.Add(command.Name.ToLower(), Activator.CreateInstance(command));  
            }
        }
    }
}