using System.Collections.Generic;
using Storage.Items;

namespace Storage.StorageUnit
{
    public class Unit
    {
        public VerticalStorage Storage;

        public Unit(int height, int width, int depth)
        {
            Storage = new VerticalStorage(height, width, depth,new List<HorizontalStorage>(height));
            Storage.CreateVerticalStorage();
        }

        public IItems FindItemAt(int vertical,int horizontal)
        {
           return Storage.VerticalList[vertical].HorizontalList[horizontal].CheckItem();
        }
        public IItems AddItemTo(int vertical, int horizontal, IItems item)
        {
            return Storage.VerticalList[vertical].HorizontalList[horizontal].AddItem(item);
        }
        public IItems TakeItemAt(int vertical, int horizontal)
        {
            return Storage.VerticalList[vertical].HorizontalList[horizontal].TakeItem();
        }
    }
}
