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
            string result = null;
            foreach (var (key, value) in InputHandler.HandleInput.CommandDictionary)
            {
                if (key != command) continue;
                {
                    result = (string) value.GetType().GetMethod("Run")?.Invoke(value, null);
                }
            }
            return result;
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
                CommandDictionary.Add(command.Name, Activator.CreateInstance(command));  
            }
            
        } 
    }
}