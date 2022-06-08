using System;
namespace Abstract
{
    abstract class Shape
    {
        public string Name { get; set; }

        public virtual void GetInfo()
        {
            Console.WriteLine("\nThis is a {0}", Name);
        }

        public abstract double Volume();

    }
}
