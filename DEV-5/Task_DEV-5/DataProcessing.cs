using System;
using System.Collections.Generic;

namespace Task_DEV-5
{
    public class DataProcessing
    {
        public List<Car> listCars = new List<Car>();
        public void SetInfo()
        {
            String word;
            Boolean flag = true;
            while (flag)
            {
                CarBuilder car = new CarBuilder();

                Console.WriteLine("Enter a brand");
                car.SetBrand(Console.ReadLine());
                
                Console.WriteLine("Enter a model");
                car.SetModel(Console.ReadLine());

                Console.WriteLine("Enter a quantity");
                car.SetQuantity(Console.ReadLine());

                Console.WriteLine("Enter a cost per unit in $");
                car.SetCostPerUnit(Console.ReadLine());

                Console.WriteLine("Continue? yes/no");
                listCars.Add(car.Create());
                word = Console.ReadLine();
                switch (word)
                {
                    case "yes": continue;
                    case "no": OutputCars();
                        flag = false;
                        break;
                    default: break;
                }
            }
        }
        public void OutputCars()
        {
            foreach (Car cars in listCars)
            {
                Console.WriteLine(cars.Brand + "-" + cars.Model + "-" + cars.Quantity + "-" + cars.CostPerUnit);
            }
        }
        public void EnterCommand()
        {
            Safekeeping safekeeping = new Safekeeping();
            List<Car> cars = new List<Car>();
            Console.WriteLine("Enter a command: | count types | count all | average price | average price [type] | exit |");
            String commandString = Console.ReadLine();
            if (commandString == String.Empty)
            {
                Console.WriteLine("Error, you did not enter the command. Try again");
                EnterCommand();
            }
            String[] command = commandString.Split(' ');
            Console.Write(commandString + ": ");
            if (command.Length == 3 && command[0].Equals("average") && command[1].Equals("price"))
            {
                safekeeping.SetCommand(new AverageByBrand());
            }
            switch (commandString)
            {
                case "count types":
                    safekeeping.SetCommand(new CountOfBrand());
                    safekeeping.WorkCommand(cars);
                    break;
                case "count all": 
                    safekeeping.SetCommand(new AmountCars());
                    safekeeping.WorkCommand(cars);
                    break;
                case "average price": 
                    safekeeping.SetCommand(new AveragePrice());
                    safekeeping.WorkCommand(cars);
                    break;
                case "exit": Environment.Exit(1);
                    break;
                default: Console.WriteLine("Unknown command, try again");
                    break;
            }
            EnterCommand();
        }
    }
}