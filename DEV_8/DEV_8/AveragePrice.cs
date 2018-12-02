using System;

namespace DEV_8
{
    public class AveragePrice : ICommand
    {
        private Vehicle vehicle;
        public AveragePrice(CarService carService)
        {
            this.vehicle = carService;
        }

        public AveragePrice(TruckService truckService)
        {
            this.vehicle = truckService;
        }

        public void Execute()
        {
            vehicle.AveragePrice();
        }
    }
}