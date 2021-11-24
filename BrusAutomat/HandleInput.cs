using System;

namespace BrusAutomat
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
         return command.ToLower() switch
                    {
                        "help" => Help(),
                        "list" => list(),
                        "clear" => Clear(),
                        _ => UnknownCommand()
                    };
        }

        public static string Help()
        {
            return "Test of Help()";
        }

        public static string list()
        {
            return "Test of list()";
        }

        public static string UnknownCommand()
        {
            return "Unknown command";
        }

        public static string Clear()
        {
            Console.Clear();
            return "";
        }
    }
}