using System.Collections.Generic;
using System.Linq;
using Storage.StorageUnit;

namespace Storage
{
    public class AddStorageUnit
    {
        public static Dictionary<string, Unit> StorageDictionary = new();

        //var vendingMachine = new Storage.StorageUnit.Unit(53, 13, 1);
        //vendingMachine.AddItemTo(15, 1, drinks[0]);
        public static string Create(string name, int height, int width, int depth)
        {
            if (StorageDictionary.ContainsKey(name)) return $"{name} is all ready a storage";
            var sUnit = new Unit(height, width, depth);
            StorageDictionary.Add(name.ToLower(), sUnit);
            return $"{name} was Created and added to the StorageDictionary, with size: {height}.{width}.{depth}";
        }
        public static string GetAllStorage()
        {
            return StorageDictionary.Aggregate<KeyValuePair<string, Unit>, string>(null, (current, pair) => current + $"{pair.Key}\n");
        }
        public static string PrintAllItems(string unitName)
        {
            StorageDictionary.TryGetValue(unitName, out var unit);
            return unit?.ShowAllItemsAsGrid();
        }
    }
}