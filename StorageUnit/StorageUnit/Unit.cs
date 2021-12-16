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
        public string ShowAllItemsAsGrid()
        {
            var result = StringOfHorisontalStorages();
            var numberOfLetter = 0;

            string WriteNumberOfLetters(int v)
            {
                string letters = null;
                var modulusOfV = v % 26;                 // 26 = length of alphabet A-Z
                var vNrAsLetter = modulusOfV + 65;       // 65 = ascii-table index for A
                if (modulusOfV == 0)numberOfLetter++; 

                for (var i = 0; i < numberOfLetter; i++)
                {
                    letters += $"{(char) vNrAsLetter}";
                }

                return letters;
            }

            string GenItemString(int v)
            {
                var vList = Storage.VerticalList[v];
                string itemString = null;

                foreach (var t in vList.HorizontalList)
                {
                    itemString += t.CheckItem() != null ? $"{t.CheckItem().Name}\t" : $"Empty\t";
                }

                return itemString;
            }
            string StringOfHorisontalStorages()
            {
                string stringOfStorages = null;
                for (var i = 0; i < Storage.VerticalList[0].HorizontalList.Count; i++)
                {
                    stringOfStorages += $"\t{i}";
                }

                return stringOfStorages;
            }
           
            for (var v = 0; v < Storage.VerticalList.Count; v++)
            {
                result += $"\n{WriteNumberOfLetters(v)}\t{GenItemString(v)}";
            }
            return result;
        }
    }
}
