using System;

namespace StorageUnit.Items
{
    public class Drink : IItems
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Type { get;  set; }

        public Drink(string name, int cost = 0, string type = "")
        {
            if (cost < 0)
                throw new ArgumentOutOfRangeException(nameof(cost));

            Name = name ?? throw new ArgumentNullException(nameof(name));
            Cost = cost;
            Type = type;
        }
    }
}
