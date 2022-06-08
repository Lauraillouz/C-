using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Chair officeChair = new Chair("brown", "plastic");
            Chair gamingChair = new Chair("red", "wood");

            Car damagedCar = new Car(80f, "blue");

            /* 
            Add the 2 chairs to the IDestroyable list of the car
            so that when we destroy the car, the destroyable objects
            that are near the car will get destroyed as well
            */
            damagedCar.DestroyableNearby.Add(officeChair);
            damagedCar.DestroyableNearby.Add(gamingChair);

            // destroy car
            damagedCar.Destroy();

            Console.ReadLine();

        }
    }
}
