using System.Collections.Generic;

namespace Storage.StorageUnit
{
    public class VerticalStorage
    {
        public int Height { get; set; }
        public int Width { get; set; }
        public int Depth { get; set; }

        public List<HorizontalStorage> VerticalList { get; set; }

        public VerticalStorage(int height, int width, int depth, List<HorizontalStorage> verticalList)
        {
            Height = height;
            Width = width;
            Depth = depth;
            VerticalList = verticalList;
        }
        public void CreateVerticalStorage()
        {
            for (var i = 0; i < Height; i++)
            {
                VerticalList.Add(new HorizontalStorage(Width, Depth, new List<DepthStorage>(Width)));
                VerticalList[i].CreateHorizontalStorage();
            }
        }
    }
}
