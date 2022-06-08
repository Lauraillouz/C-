using System;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = { new Sphere(4), new Cube(3) };

            foreach(Shape shape in shapes)
            {
                shape.GetInfo();
                Console.WriteLine("{0} has a volume of {1}", shape.Name, shape.Volume());

                // we create a new instance of Cube that is of type Cube
                Cube iceCube = shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This shape is no cube");
                }
                if(shape is Cube)
                {
                    Console.WriteLine("This shape is a cube");
                }

                // object that contains Cube (type)
                object cube1 = new Cube(7);
                // we cast the object cube1 into a type Cube cube2
                Cube cube2 = (Cube)cube1;
                // the, below will work only if cube2 is in fact a Cube
                Console.WriteLine("{0} has a volume of {1}", cube2.Name, cube2.Volume());
            }

        }
    }
}
