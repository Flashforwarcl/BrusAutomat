using System.Collections.Generic;
using Storage.Items;

namespace BrusAutomat
{
    public class Drinks
    {
        public static IItems[] drinks = {
            new Drink("Solo", 5),
            new Drink("Coca Cola", 5),
            new Drink("Apple Juice")
        };

        public static List<IItems> DrinkList = new(drinks);
    }
}
