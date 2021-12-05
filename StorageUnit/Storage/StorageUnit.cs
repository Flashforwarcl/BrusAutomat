using System.Collections.Generic;
using StorageUnit.Items;


namespace StorageUnit.Storage
{
    class StorageUnit
    {
        public VerticalStorage Storage;

        public StorageUnit(int height, int width, int depth)
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
