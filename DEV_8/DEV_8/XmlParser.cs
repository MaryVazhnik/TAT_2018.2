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

        public List<Vehicle> XmlParser()
        {
            XDocument xdoc = XDocument.Load("cars.xml");
            foreach (XElement phoneElement in xdoc.Element("cars").Elements("car"))
            {
                XElement modelElement = phoneElement.Element("model");
                XElement brandElement = phoneElement.Element("brand");
                XElement quantityElement = phoneElement.Element("amount");
                XElement priceElement = phoneElement.Element("price");

                if (modelElement != null && brandElement != null && quantityElement != null && priceElement != null)
                {
                    Console.WriteLine("Model: {0}", modelElement.Value);
                    Console.WriteLine("Price of one: {0}", priceElement.Value);
                    Console.WriteLine("Quantity: {0}", quantityElement.Value);
                    Console.WriteLine("Brand: {0}", brandElement.Value);

                    carList.Add(new Car(brandElement.Value, modelElement.Value, Convert.ToInt32(priceElement.Value), Convert.ToInt32(quantityElement.Value)));
                }
            }
            XDocument xdocument = XDocument.Load("trucks.xml");
            foreach (XElement phoneElement in xdoc.Element("trucks").Elements("truck"))
            {
                XElement modelElement = phoneElement.Element("model");
                XElement brandElement = phoneElement.Element("brand");
                XElement quantityElement = phoneElement.Element("amount");
                XElement priceElement = phoneElement.Element("price");

                if (modelElement != null && brandElement != null && quantityElement != null && priceElement != null)
                {
                    Console.WriteLine("Model: {0}", modelElement.Value);
                    Console.WriteLine("Price of one: {0}", priceElement.Value);
                    Console.WriteLine("Quantity: {0}", quantityElement.Value);
                    Console.WriteLine("Brand: {0}", brandElement.Value);

                    truckList.Add(new Truck(brandElement.Value, modelElement.Value, Convert.ToInt32(priceElement.Value), Convert.ToInt32(quantityElement.Value)));
                }
            }
            return null;
        }
    }
}
