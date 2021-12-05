﻿using System;
using System.Linq;

namespace BrusAutomat
{
    public class HandleInput : IHandleInput
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
                        "list" => List(),
                        "Buy" => Buy(),
                        "clear" => Clear(),
                        "exit" => CloseApplication(),
                        _ => UnknownCommand()
                    };
        }

        private static string Buy()
        {
            throw new NotImplementedException();
        }

        public static string Help()
        {
            return "Test of Help()";
        }

        public static string List()
        {
            var products = Program.items.Aggregate<Item, string>(null, (current, item) => current + $"\n{item.Name}");
            return $"Here is a list of products:{products}";
        }

        public static string UnknownCommand() => "Unknown command";

        public static string Clear()
        {
            Console.Clear();
            return "";
        }

        public static string CloseApplication()
        {
            Checks.IsRunning = false;
            return "";
        }
    }
}