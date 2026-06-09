using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductWareHouse
{
    public class Product
    {
        public string Name { get; set; }
        public int ShelfLifeDays { get; set; } 

        public Product(string name, int shelfLifeDays)
        {
            Name = name;
            ShelfLifeDays = shelfLifeDays;
        }

        public override string ToString() => ($"{Name} (годен {ShelfLifeDays} дн.)");
    }
}
