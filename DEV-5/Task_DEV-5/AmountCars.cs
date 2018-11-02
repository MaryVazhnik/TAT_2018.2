using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    class AmountCars : ICommandForCars
    {
        public void Work(List<Car> cars)
        {
            int amount = 0;
            foreach (Car c in cars)
            {
                amount += c.Quantity;
            }
            Console.WriteLine(amount);
        }
    }
}