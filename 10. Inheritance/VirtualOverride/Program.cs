using System;

namespace VirtualOverride
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("Joe", 15);
            Console.WriteLine("{0} is {1} years old", myDog.Name, myDog.Age);
            myDog.MakeSound();
            myDog.Play();
            myDog.Eat();
        }
    }
}
