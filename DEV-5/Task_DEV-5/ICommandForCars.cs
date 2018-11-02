using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    public interface ICommandForCars
    {
        void Work(List<Car> list);
    }
}