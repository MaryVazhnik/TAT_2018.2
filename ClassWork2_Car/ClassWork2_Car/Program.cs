using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork2_Car
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<Car> myList = new MyList<Car>();
            myList.Add(new Car("X5", "BMW", "Red"));
            myList.Add(new Car("X6", "BMW", "Blue"));
            myList.Add(new Car("7", "BMW", "Black"));
            myList.Add(new Car("TT", "Audi", "Black"));
            myList.Add(new Car("2110", "Zhiguly", "Gold"));
            foreach(var car in myList)
            {
                Console.WriteLine(car);
            }

            Searcher searcher = new Searcher();
            var cars = searcher.SearchCarSameColor("Black", myList);
            foreach(var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}