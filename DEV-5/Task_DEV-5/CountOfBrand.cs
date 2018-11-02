using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    class CountOfBrand : ICommandForCars
    {
        public void Work(List<Car> cars)
        {
            List<String> brandList = new List<String>();

            foreach (Car c in cars)
            {
                brandList.Add(c.Brand);
            }
            Console.WriteLine(brandList.Distinct().Count());
        }
    }
}