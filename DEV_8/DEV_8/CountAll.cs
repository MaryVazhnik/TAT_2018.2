using System;

namespace DEV_8
{
    public class CountAll : ICommand
    {
        private Vehicle vehicle;
        public CountAll(CarService car)
        {
            this.vehicle = car;
        }

        public CountAll(TruckService truck)
        {
            this.vehicle = truck;
        }

        public void Execute()
        {
            vehicle.CountAll();
        }
    }
}