using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    class AveragePrice : ICommandForCars
    {
        public void Work(List<Car> cars)
        {
            double sumCost = 0;
            foreach (Car c in cars)
            {
                sumCost += c.CostPerUnit;
            }
            Console.WriteLine(sumCost / cars.Count);
        }
    }
}