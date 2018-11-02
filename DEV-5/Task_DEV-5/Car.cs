using System;

namespace Task_DEV-5
{
    public class Car
    {
        public String Brand { get; set; }
        public String Model { get; set; }
        public int Quantity { get; set; }
        public double CostPerUnit { get; set; }

        public static CarBuilder CreateBuilder()
        {
            return new CarBuilder();
        }
    }
}