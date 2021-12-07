using System;
using System.Collections.Generic;
using System.Reflection;

namespace InputHandler
{
    public class HandleInput
    {
        public static Dictionary<string, object> CommandDictionary = new();

        public static void CreateCommands()
        {
            //var assembly = Assembly.GetExecutingAssembly();
            //var command = assembly.GetType();
            //var runMethod = command.GetMethod("Run");
            //var initiatedObject = Activator.CreateInstance(command);
            //runMethod.Invoke(initiatedObject, null);
            
            var assembly = Assembly.GetExecutingAssembly();
            var typesOfICommands = TypeLoaderExtensions.GetTypesWithInterface(assembly);
            foreach (var command in typesOfICommands)
            {
                CommandDictionary.Add(command.Name, Activator.CreateInstance(command));  
            }
        } 
    }
}