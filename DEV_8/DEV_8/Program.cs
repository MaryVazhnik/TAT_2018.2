using System;
using System.Collections.Generic;

namespace DEV_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                XmlParser parser = new XmlParser();
                parser.XmlParser();
                CarService car = new CarService();
                TruckService truck = new TruckService();
                Inkover carInkover = new Inkover(new AveragePrice(car), new AveragePriceType(car), new CountAll(car), new CountType(car));
                Inkover truckInkover = new Inkover(new AveragePrice(truck), new AveragePriceType(truck), new CountAll(truck), new CountType(truck));

                string number;
                do
                {
                    chooseCommand:

                    Console.WriteLine("\nChoose command:" + "\n1) count types of cars\n" + "2) count all cars\n" +
                                      "3) average price of car\n" +
                                      "4) average price (type) of car\n" + "5)count types of trucks\n" +
                                      "6)count all trucks\n" +
                                      "7)average price of truck\n" + "8)average price (type) of truck\n" +
                                      "Input number: ");

                    number = Console.ReadLine();

                    switch (number)
                    {
                        case "1":
                            carInkover.CountType();
                            break;
                        case "2":
                            carInkover.CountAll();
                            break;
                        case "3":
                            carInkover.AveragePrice();
                            break;
                        case "4":
                            Console.WriteLine("Input type: ");
                            string brand = Console.ReadLine();
                            carInkover.AveragePriceType(brand);
                            break;
                        case "5":
                            truckInkover.CountType();
                            break;
                        case "6":
                            truckInkover.CountAll();
                            break;
                        case "7":
                            truckInkover.AveragePrice();
                            break;
                        case "8":
                            Console.WriteLine("Input type: ");
                            string type = Console.ReadLine();
                            truckInkover.AveragePriceType(type);
                            break;
                            return;
                        default:
                            goto chooseCommand;
                    }
                } while (true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}