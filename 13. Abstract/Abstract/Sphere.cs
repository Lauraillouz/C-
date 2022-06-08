using System;
namespace Abstract
{
    class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius)
        {
            Name = "Sphere";
            Radius = radius;
        }

        public override double Volume()
        {
            return (double)(4 / 3 * Math.PI * Math.Pow(Radius, 3));
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("The cube has a radius of {0}", Radius);
        }
    }
}
