using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlWork_3
{
    public class Action
    {
        List<Goods> list = new List<Goods>();
        Goods goods = new Goods();
        public void ListArray()
        {
            foreach (Goods goods in list)
            {
                Console.WriteLine(goods.type + "-" + goods.name + "-" + goods.shelfLife + "-" + goods.cost);
            }
        }

        public string shelfLifeFinished = "30.06.2019";

        public void Action()
        {
            List<String> shelfLife = new List<String>();
            foreach (Goods goods in list)
            {
                shelfLife.Add(goods.shelfLife);
            }

            string shelfLifeForGoods = goods.shelfLife.ToString();
            if (shelfLifeForGoods.Equals(shelfLifeFinished))
            {
                Console.WriteLine("Good merchandise");
            }
            else
            {
                Console.WriteLine("Not good");
            }
        }

    }
}
