using System;

namespace DEV_8
{
    public class CountType : ICommand
    {
        private Vehicle vehicle;
        public CountType(CarService car)
        {
            this.vehicle = car;
        }

        public CountType(TruckService truck)
        {
            this.vehicle = truck;
        }
 
        public void Execute()
        {
            vehicle.CountType();
        }
    }
}