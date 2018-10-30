using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2_Car
{
    public class Searcher
    {
        public MyList<Car> SearchCarSameColor(string color, MyList<Car> cars)
        {
            var newList = new MyList<Car>();
            
            foreach(var car in cars)
            {
                if (car.Color.Equals(color))
                    newList.Add(car);
            }
            return newList;
        }
    }
}