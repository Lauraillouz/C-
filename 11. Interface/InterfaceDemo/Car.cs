using System;
using System.Collections.Generic;

namespace InterfaceDemo
{
    public class Car : Vehicule, IDestroyable
    {
        // implement interface's property
        public string DestructionSound { get; set; }

        /* 
        Creating a new property to store the destroyable objects nearby.
        When a car gets destroyed it should also destroy the nearby objects.
        This list is of type IDestroyable which means it can store any object
        that implements this interface and we can only access the properties
        and methods in this interface
        */
        public List<IDestroyable> DestroyableNearby;

        // constructor
        public Car(float speed, string color):base(speed, color)
        {

            // initialise the interface's property with a value in the constructor
            DestructionSound = "CarExplosionSound.mp3";

            // initialise the list of destroyable objects
            DestroyableNearby = new List<IDestroyable>();
        }

        // implementing interface's method
        public void Destroy()
        {
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Create fire");

            foreach(IDestroyable destroyable in DestroyableNearby)
            {
                destroyable.Destroy();
            }
        }
    }
}
