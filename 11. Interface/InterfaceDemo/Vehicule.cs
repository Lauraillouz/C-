using System;
namespace InterfaceDemo
{
    public class Vehicule
    {
        public float Speed { get; set; }
        public string Color { get; set; }

        public Vehicule()
        {
            Speed = 120f;
            Color = "red";
        }

        public Vehicule(float speed, string color)
        {
            this.Speed = speed;
            this.Color = color;
        }
    }
}
