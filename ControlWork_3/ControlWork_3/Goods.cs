using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_3
{
    public class Goods
    {
        public String type { get; set; }
        public String name { get; set; }
        public String shelfLife { get; set; }
        public double cost { get; set; }

        public Goods() { }

        public Goods(String type, String name, String shelfLife, double cost)
        {
            this.type = type;
            this.name = name;
            this.shelfLife = shelfLife;
            this.cost = cost;
        }
    }
}
