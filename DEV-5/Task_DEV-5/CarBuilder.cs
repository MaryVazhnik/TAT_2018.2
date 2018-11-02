using System;

namespace Task_DEV-5
{
    public class CarBuilder
    {
        private Car car;
        public CarBuilder()
        {
            car = new Car();
        }
        public CarBuilder SetBrand(string brand)
        {
            if(brand.Equals(String.Empty))
            {
                throw new ArgumentException();
            }
            car.Brand = brand;
            return this;
        }
        public CarBuilder SetModel(string model)
        {
            if (model.Equals(String.Empty))
            {
                throw new ArgumentException();
            }
            car.Model = model;
            return this;
        }
        public CarBuilder SetQuantity(string quantity)
        {
            car.Quantity = Int32.Parse(quantity);
            return this;
        }
        public CarBuilder SetQuantity(int quantity)
        {
            if(quantity < 0)
            {
                throw new ArgumentException();
            }
            car.Quantity = quantity;
            return this;
        }
        public CarBuilder SetCostPerUnit(string costPerUnit)
        {
            car.CostPerUnit = Double.Parse(costPerUnit);
            return this;
        }
        public CarBuilder SetCostPerUnit(double costPerUnit)
        {
            if (costPerUnit < 0)
            {
                throw new ArgumentException();
            }
            car.CostPerUnit = costPerUnit;
            return this;
        }
        public Car Create()
        {
            return car;
        }
    }
}