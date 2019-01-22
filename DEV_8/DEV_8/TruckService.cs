using System;
using System.Collections.Generic;
using System.Linq;

namespace DEV_8
{
    public class TruckService : Vehicle
    {
        private List<Truck> truckList;
        public int CountType()
        {
            foreach (Truck trucks in truckList)
            {
                truckList.Add(trucks.brand);
            }
            return truckList.Distinct().Count();
        }

        public int CountAll()
        {
            return truckList.Distinct().Count();
        }

        public double AveragePrice()
        {
            double sumCost = 0;
            foreach (Truck trucks in truckList)
            {
                sumCost += trucks.costPerUnit;
            }
            return sumCost / truckList.Count;
        }

        public double AveragePriceOfType(string brand)
        {
            double average = 0;
            int count = 0;
            double sum = 0;
            foreach (Truck trucks in truckList)
            {
                if (brand.Equals(trucks.brand))
                {
                    count++;
                    sum += trucks.costPerUnit;
                }
            }
            average = sum / count;
            return average;
        }
    }
}