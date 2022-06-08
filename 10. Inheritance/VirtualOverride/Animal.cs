using System;
namespace VirtualOverride
{
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }


        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        // an empty virtual method for other classes to override
        public virtual void MakeSound()
        {

        }

        // a virtual method which sub classes can override
        public virtual void Eat()
        {
            // check if animal is hungry
            if (IsHungry)
            {
                // if so, then print the name of the animal
                Console.WriteLine("{0} is eating", Name);
            }
            else
            {
                // otherwise print that animal is not hungry
                Console.WriteLine("{0} is not hungry");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine("{0} is playing", Name);
        }
    }
}
