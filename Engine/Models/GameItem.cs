using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class GameItem
    {
        private int v1;
        private string v2;
        private int v3;

        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string ImageName { get; set; }
        public GameItem(int itemTypeID, string name, int price, string imageName)
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = imageName;
        }

        public GameItem(int v1, string v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName);
        }
    }
}
