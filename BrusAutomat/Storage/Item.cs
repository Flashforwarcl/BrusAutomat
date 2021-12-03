namespace BrusAutomat.Storage
{
    public class Item
    {
        public string Name { get; set; }
        public int Cost { get; set; }

        public Item(string name, int cost = 0)
        {
            Name = name;
            Cost = cost;
        }
    }
}
