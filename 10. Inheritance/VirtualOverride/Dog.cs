using System;
namespace VirtualOverride
{
    public class Dog : Animal
    {
        // add a property specific to Dog class
        public bool IsHappy { get; set; }

        // simple constructor where we pass name and age to the base constructor and add our new property
        public Dog(string name, int age):base(name, age)
        {
            IsHappy = true;
        }

        // simple override of the virtual method
        public override void Eat()
        {
            // call the method from base class but not really overriding it, just saying that it is used the same way as the base Animal
            base.Eat();
        }

        public override void MakeSound()
        {
            // each animal will implement their own version of MakeSound
            Console.WriteLine("Ouaf");
        }

        public override void Play()
        {
            if(IsHappy)
            {
                base.Play();
            }
        }
    }
}
