using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting;

namespace InputHandler
{
    public class HandleInput
    {
        public static Dictionary<string, object?> CommandDictionary = new();

        public static void CreateCommands()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var typesOfICommands = TypeLoaderExtensions.GetTypesWithInterface(assembly);
            foreach (var command in typesOfICommands)
            {
                //Console.WriteLine(command);
                //Console.WriteLine(command.Name);
                //Console.WriteLine(command.FullName);

                //  var runMethod = command.GetMethod("Run");
                //  var initiatedObject = Activator.CreateInstance(command);
                //  runMethod.Invoke(initiatedObject, null);
                
                CommandDictionary.Add(command.Name, Activator.CreateInstance(command));  
            }
        }
    }
}