using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);


            Console.WriteLine(box.Width);
            box.Width = 10;
            Console.WriteLine("Width is {0}", box.Width);
            Console.WriteLine("Front surface is {0}" ,box.FrontSurface);
            Console.WriteLine("Box volume is {0}", box.Volume);

            box.DisplayInfo();
        }
    }
}
