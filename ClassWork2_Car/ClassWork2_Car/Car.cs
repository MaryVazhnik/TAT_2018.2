using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2_Car
{
    class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public Car(string model, string brand, string color)
        {
            this.Model = model;
            this.Brand = brand;
            this.Color = color;
        }

        public override string ToString()
        {
            return "model: " + Model + ", brand: " + Brand +  ", color: " + Color;
        }
    }
}