using System;
namespace InterfaceDemo
{
    public class Chair : Furniture, IDestroyable
    {
        // implements interface property
        public string DestructionSound { get; set; }

        // constructor
        public Chair(string color, string material):base(color,  material)
        {
            // initialise the interface property with a value in the constructor
            DestructionSound = "ChairDestructionSound.mp3";
        }

        public void Destroy()
        {
            Console.WriteLine("The {0} chair was destroyed", Color);
            Console.WriteLine("Playing destruction sound {0}", DestructionSound);
            Console.WriteLine("Spawning chair parts");

        }
    }
}
