using System.Collections.Generic;
using System.Linq;
using Storage.StorageUnit;

namespace Storage
{
    public class AddStorageUnit
    {
        public Dictionary<string, Unit> StorageDictionary = new();

        //var vendingMachine = new Storage.StorageUnit.Unit(53, 13, 1);
        //vendingMachine.AddItemTo(15, 1, drinks[0]);
        public void Create(string name, int height, int width, int depth)
        {
            var sUnit = new Unit(height, width, depth);
            StorageDictionary.Add(name.ToLower(), sUnit);
            //return $"{name} was Created and added to the StorageDictionary, with size: {height}.{width}.{depth}";
        }
        public string GetAllStorage()
        {
            return StorageDictionary.Aggregate<KeyValuePair<string, Unit>, string>(null, (current, key) => current + $"{key}\n");
        }
        public string PrintAllItems(string unitName)
        {
            StorageDictionary.TryGetValue(unitName, out var unit);
            return unit?.ShowAllItemsAsGrid();
        }
        
        
    }
}