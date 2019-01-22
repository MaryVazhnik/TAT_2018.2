using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_8
{
    public class CarService : Vehicle
    {
        private List<Car> carList;
        public int CountType()
        {
            foreach (Car cars in carList)
            {
                carList.Add(cars.brand);
            }
            return carList.Distinct().Count();
        }

        public int CountAll()
        {
            return carList.Distinct().Count();
        }

        public double AveragePrice()
        {
            double sumCost = 0;
            foreach (Car cars in carList)
            {
                sumCost += cars.costPerUnit;
            }
            return sumCost / carList.Count;
        }

        public double AveragePriceOfType(string brand)
        {
            double average = 0;
            int count = 0;
            double sum = 0;
            foreach (Car cars in carList)
            {
                if (brand.Equals(cars.brand))
                {
                    count++;
                    sum += cars.costPerUnit;
                }
            }
            average = sum / count;
            return average;
        }
    }
}