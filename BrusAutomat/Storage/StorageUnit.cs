using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrusAutomat.Storage
{
    class StorageUnit
    {
        public VerticalStorage Storage;

        public StorageUnit(int height, int width, int depth)
        {
            Storage = new VerticalStorage(height, width, depth,new List<HorizontalStorage>(height));
            Storage.CreateVerticalStorage();
        }
        public string FindItemAt(int vertical,int horizontal)
        {
           return Storage.VerticalList[vertical].HorizontalList[horizontal].NameItem();
        }
        public string AddItemTo(int vertical, int horizontal, string name, int cost)
        {
            return Storage.VerticalList[vertical].HorizontalList[horizontal].AddItem(vertical, horizontal, name, cost);
        }
        public string TakeItemAt(int vertical, int horizontal)
        {
            return Storage.VerticalList[vertical].HorizontalList[horizontal].TakeItem( vertical,  horizontal);
        }
    }
}
