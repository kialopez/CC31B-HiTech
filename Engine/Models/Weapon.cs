using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Weapon : GameItem
    {
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int V4 { get; }
        public int V5 { get; }

        public Weapon(int itemTypeID, string name, int price, string imageName, int minDamage, int maxDamage)
            : base(itemTypeID, name, price, imageName)
        {
            MinimumDamage = minDamage;
            MaximumDamage = maxDamage;
        }

        public Weapon(int v1, string v2, int v3, int v4, int v5) : base(v1, v2, v3)
        {
            V4 = v4;
            V5 = v5;
        }

        public new Weapon Clone()
        {
            return new Weapon(ItemTypeID, Name, Price, ImageName, MinimumDamage, MaximumDamage);
        }
    }
}
