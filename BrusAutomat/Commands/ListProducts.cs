using System.Linq;
using InputHandler;
using Storage.Items;

namespace BrusAutomat.Commands
{
    public class ListProducts : ICommands
    {
        public string Run()
        {
            var products = Drinks.DrinkList.Aggregate<IItems, string>(null, (current, item) => current + $"\n{item.Name}");
            return $"Here is a list of products:{products}";
        }

    }
}