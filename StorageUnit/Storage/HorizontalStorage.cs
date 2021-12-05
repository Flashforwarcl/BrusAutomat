using System.Collections.Generic;
using StorageUnit.Items;

namespace StorageUnit.Storage
{
    class HorizontalStorage
    {
        public List<DepthStorage> HorizontalList { get; set; }
        public int Width;
        public int Depth;
        public HorizontalStorage(int width, int depth, List<DepthStorage> horizontalList)
      {
          Width = width;
          Depth = depth;
          HorizontalList = horizontalList;
        }
        public void CreateHorizontalStorage()
        {
            for (var i = 0; i < Width; i++)
            {
              HorizontalList.Add(new DepthStorage(Depth, new Stack<IItems>()));
            }
        }
    }
}
