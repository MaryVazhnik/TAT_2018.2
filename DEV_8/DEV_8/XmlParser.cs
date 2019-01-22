using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DEV_8
{
    class XmlParser
    {
        List<Car> carList = new List<Car>();
        List<Truck> truckList = new List<Truck>();

        private List<Vehicle> XmlParser(List<String> args)
        {
			for (int i = 0; i < 2; i++)
			{
				XDocument xdoc = XDocument.Load(args.ElementAt(0));
				if (xdoc.Element("cars")
				{
					foreach (XElement carElement in xdoc.Element("cars").Elements("car"))
					{
						XElement modelElement = phoneElement.Element("model");
						XElement brandElement = phoneElement.Element("brand");
						XElement quantityElement = phoneElement.Element("amount");
						XElement priceElement = phoneElement.Element("price");

						if (modelElement != null && brandElement != null && quantityElement != null && priceElement != null)
						{
							Console.WriteLine("Model: ", modelElement.Value);
							Console.WriteLine("Price of one: ", priceElement.Value);
							Console.WriteLine("Quantity: ", quantityElement.Value);
							Console.WriteLine("Brand: ", brandElement.Value);

							carList.Add(new Car(brandElement.Value, modelElement.Value, Convert.ToInt32(priceElement.Value), Convert.ToInt32(quantityElement.Value)));
						}
					}
					return carList;
				}
				else if (xdoc.Element("trucks")
				{
					foreach (XElement truckElement in xdoc.Element("trucks").Elements("truck"))
					{
						XElement modelElement = phoneElement.Element("model");
						XElement brandElement = phoneElement.Element("brand");
						XElement quantityElement = phoneElement.Element("amount");
						XElement priceElement = phoneElement.Element("price");

						if (modelElement != null && brandElement != null && quantityElement != null && priceElement != null)
						{
							Console.WriteLine("Model: ", modelElement.Value);
							Console.WriteLine("Price of one: ", priceElement.Value);
							Console.WriteLine("Quantity: ", quantityElement.Value);
							Console.WriteLine("Brand: ", brandElement.Value);

							truckList.Add(new Truck(brandElement.Value, modelElement.Value, Convert.ToInt32(priceElement.Value), Convert.ToInt32(quantityElement.Value)));
						}
					}
					return truckList;
				}
			}
        }
    }
}
