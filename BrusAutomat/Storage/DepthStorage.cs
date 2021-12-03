using System.Collections.Generic;

namespace BrusAutomat.Storage
{
    public class DepthStorage
    {
        public int Depth { get; set; }
        public Stack<Item> StringStack { get; set; }

        public DepthStorage(int depth, Stack<Item> stringStack)
        {
            Depth = depth;
            StringStack = stringStack;
        }
        internal string NameItem()
        {
            return StringStack.TryPeek(out var result) ? result.Name : "There are no items in this slot";
        }

        internal string AddItem(int vertical, int horizontal, string item, int cost)
        {
            if (StringStack.Count >= Depth) return $"Slot: {vertical}.{horizontal} is full! Cannot add {item}.";
            StringStack?.Push(new Item(item, cost));
            return $"{item} added to slot: {vertical}.{horizontal}";
        }


        internal string TakeItem(int vertical, int horizontal)
        {
            return StringStack.Count <= 0 ? $"There are no items in slot {vertical}.{horizontal}" : $"Here is your: {StringStack.Pop().Name}";
        }
    }
}
