using System;

namespace DEV_8
{
    public class AveragePriceType : ICommand
    {
        private Vehicle vehicle;

        public AveragePriceType(CarService car)
        {
            this.vehicle = car;
        }

        public AveragePriceType(TruckService truck)
        {
            this.vehicle = truck;
        }

        public void Execute()
        {
            vehicle.AveragePriceOfType();
        }
    }
}