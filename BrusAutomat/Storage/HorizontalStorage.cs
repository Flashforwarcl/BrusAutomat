﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrusAutomat.Storage
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
              HorizontalList.Add(new DepthStorage(Depth, new Stack<Item>()));
            }
        }
    }
}
