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
            var inputHandlerAssembly = Assembly.GetExecutingAssembly();   // commands using ICommands that are located inside Inputhandler
            var topLevelAssembly = Assembly.GetCallingAssembly();        // commands using ICommands that are located inside class calling Inputhandler

            GenerateDictionaryEntriesFrom(inputHandlerAssembly);
            GenerateDictionaryEntriesFrom(topLevelAssembly);
            }
        private static void GenerateDictionaryEntriesFrom(Assembly assembly)
        {
            var typesOfICommands = TypeLoaderExtensions.GetTypesWithInterface(assembly, typeof(ICommands));
            foreach (var command in typesOfICommands)
            {
               CommandDictionary.Add(command.Name.ToLower(), Activator.CreateInstance(command));
            }
        }
    
    }
}

//var assembly = Assembly.GetExecutingAssembly(); // or Assembly.GetCallingAssembly();
//var command = assembly.GetType();
//var runMethod = command.GetMethod("Run");
//var initiatedObject = Activator.CreateInstance(command);
//runMethod.Invoke(initiatedObject, null);
//var assembly = Assembly.GetExecutingAssembly();   