using BrusAutomat;
using NUnit.Framework;
using System.Collections.Generic;

namespace TestBrusAutomat
{
   public class TestInputAndCommand
    {
        [Test]
        public void TestInputCommandResponse([Values(" ", "list", "Help", "exit")] string values)
        {
            var listOfCommandReturns = new List<string>
            {
                HandleInput.Help(),
                HandleInput.List(),
                HandleInput.UnknownCommand(),
                HandleInput.CloseApplication()
            }; 
            HandleInput.Input = values;
            HandleInput.SetResponse(); 
            CollectionAssert.Contains(listOfCommandReturns, HandleInput.Response);
        }
    }
}

