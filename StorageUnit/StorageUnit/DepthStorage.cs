using System.Collections.Generic;
using Storage.Items;

namespace Storage.StorageUnit
{
    public class DepthStorage
    {
        public int Depth { get; set; }
        public Stack<IItems> ItemStack { get; set; }

        public DepthStorage(int depth, Stack<IItems> itemStack)
        {
            Depth = depth;
            ItemStack = itemStack;
        }
        internal IItems CheckItem()
        {
            return ItemStack.TryPeek(out var result) ? result : null;
        }

        internal IItems AddItem(IItems item)
        {
            if (ItemStack.Count >= Depth) return null;
            ItemStack?.Push(item);
            return item;
        }
        
        internal IItems TakeItem()
        {
            return ItemStack.Count <= 0 ? null : ItemStack.Pop();
        }
    }
}
