using System;

namespace DEV_8
{
    class Car
    {
        public string brand { get; set; }
        public string name { get; set; }
        public int costPerUnit { get; set; }
        public int amount { get; set; }

        public Car(string brand, string name, int costPerUnit, int amount)
        {
            this.brand = brand;
            this.name = name;
            this.costPerUnit = costPerUnit;
            this.amount = amount;
        }
    }
}
