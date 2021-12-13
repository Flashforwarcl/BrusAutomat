using System;
using System.Collections.Generic;
using System.Reflection;

namespace InputHandler
{
    public class CommandGenerator
    {
        public static Dictionary<string, object> CommandDictionary { get; } = new();

        public static void CreateCommands()
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var command = assembly.GetType();
            //var runMethod = command.GetMethod("Run");
            //var initiatedObject = Activator.CreateInstance(command);
            //runMethod.Invoke(initiatedObject, null);

            //var assembly = Assembly.GetExecutingAssembly();   // commands using ICommands that are located inside Inputhandler
            var InputAssembly = Assembly.GetExecutingAssembly();
            var TopLevelAssembly = Assembly.GetCallingAssembly();       // commands using ICommands that are located inside class calling Inputhandler

            GenerateDictionaryEntriesFrom(InputAssembly);
            GenerateDictionaryEntriesFrom(TopLevelAssembly);
        }

        private static void GenerateDictionaryEntriesFrom(Assembly assembly)
        {
            var typesOfICommands = TypeLoaderExtensions.GetTypesWithInterface(assembly);
            foreach (var command in typesOfICommands)
            {
                CommandDictionary.Add(command.Name.ToLower(), Activator.CreateInstance(command));
            }
        }
    }
}