using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    public class Safekeeping
    {
        ICommandForCars command;
        public void SetCommand(ICommandForCars com)
        {
            command = com;
        }
        public void WorkCommand(List<Car> cars)
        {
            command.Work(cars);
        }
    }
}   