using System;
namespace Properties
{
    public class Box
    {
        // member variables
        private int length = 3;
        private int height;
        private int volume;

        // default getter and setter. No need for member variable
        public int Width { get; set; }

        // Challenge - read only property so it only needs a get
        public int FrontSurface
        {
            get
            {
                return this.height * this.length;
            }
        }

        // property can have only a getter
        public int Volume
        {
            get
            {
                return this.length * this.height * this.Width;
           }
           // since  
        }

        // property: other way to make getter and setter. Needs a member variable
        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value < 0)
                {
                    height = -value;
                }
                else
                {
                    height = value;

                }
            }
        }

        // constructor
        public Box(int length, int height, int width)
        {
            this.length = length;
            this.height = height;
            Width = width;
        }

        // ENCAPSULATION
        // setter
        public void SetLength(int length)
        {
            /* if (length < 0)
               {
                   throw new Exception("Length should be higher than 0");
               } */
            this.length = length; 
        }
        // getter
        public int GetLength()
        {
            return this.length;
        }

        public int GetVolume()
        {
            return this.length * this.height * this.Width;
        }

        // method
        public void DisplayInfo()
        {
            Console.WriteLine("Length is {0} and height is {1} and width is {2} so the volume is {3}",
                length, height, Width, volume = length * height * Width);
        }
    }
}
