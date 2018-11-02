using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    class AverageByBrand : ICommandForCars
    {
        public void Work(List<Car> cars)
        {
            double average = 0;
            int count = 0;
            double sum = 0;
            foreach (Car c in cars)
            {
                if (Brand.Equals(c.Brand))
                {
                    count++;
                    sum += c.CostPerUnit;
                }
            }
            average = sum / count;
            Console.WriteLine(average);
        }
    }
}