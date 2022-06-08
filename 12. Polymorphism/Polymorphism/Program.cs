using System;
using System.Collections.Generic;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>
            {
                new Audi(200, "blue", "A4"),
                new BMW(250, "red", "M3")
            };

            foreach(var car in cars)
            {
                // this will call the methods from the child class because we're calling it from the sub classes (Audi and BMW)
                car.Repair();
            }

            Car bmwZ3 = new BMW(200, "black", "Z3");
            Car audiA3 = new Audi(100, "green", "A3");

            // this will call the methods from the parent class because we're calling it from the base class Car
            bmwZ3.ShowDetails();
            audiA3.ShowDetails();


            bmwZ3.SetCarIDInfo(1234, "Laura Illouz");
            audiA3.SetCarIDInfo(1233, "Frank White");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();

            BMW bmwM5 = new BMW(330, "white", "M5");
            bmwM5.ShowDetails();

            // cast a BMW instance into a Car instance
            Car carB = (Car)bmwM5;
            carB.ShowDetails();
        }
    }
}
