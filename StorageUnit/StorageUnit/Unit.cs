using System;
using System.Collections.Generic;
using Storage.Items;

namespace Storage.StorageUnit
{
    public class Unit
    {
        public VerticalStorage Storage;

        public Unit(int height, int width, int depth)
        {
            Storage = new VerticalStorage(height, width, depth, new List<HorizontalStorage>(height));
            Storage.CreateVerticalStorage();
        }

        public IItems FindItemAt(int vertical, int horizontal)
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

        public void FindAllItemsAtFrontOfStorage()
        {
            var result = StringOfHorisontalStorages();
            var numberOfLetter = 0;
            for (var v = 0; v < Storage.VerticalList.Count; v++)
            {
                var vList = Storage.VerticalList[v];
            
                var modulusOfV = v % 26;
                var vNrAsLetter = modulusOfV + 65;
               
                if (modulusOfV == 0){numberOfLetter++;}

                result += "\n";
                for (var i = 0; i < numberOfLetter; i++)
                {
                    result += $"{(char)vNrAsLetter}";
                }
                result += "\t";
                
                for (var h = 0; h < vList.HorizontalList.Count; h++)
                {
                    var t = vList.HorizontalList[h];
                    //Console.WriteLine(t.CheckItem() != null ? $"{i}.{h} {t.CheckItem().Name}" : $"{i}.{h} Empty");
                    result += t.CheckItem() != null ? $"{t.CheckItem().Name}\t" : $"Empty\t";
                }
            }

            Console.WriteLine(result);
        }

        private string StringOfHorisontalStorages()
        {
            string stringOfStorages = null;
            for (var i = 0; i < Storage.VerticalList[0].HorizontalList.Count; i++)
            {
                stringOfStorages += $"\t{i}";
            }

            return stringOfStorages;
        }
    }
}
