using System;
using System.Collections;
using System.Collections.Generic;

namespace IEnumerable
{
    class Program
    {

        static void Main(string[] args)
        {
            DogShelter shelter = new DogShelter();

            foreach(Dog dog in shelter)
            {
                if(!dog.IsNaughtyDog)
                {
                    dog.GiveTreat(2);
                }
                else
                {
                    dog.GiveTreat(1);
                }
            }
        }
    }
}

class DogShelter : IEnumerable<Dog>
{
    public List<Dog> dogs;

    // constructor to inistialise dogs list
    public DogShelter()
    {
        dogs = new List<Dog>()
        {
            new Dog("Casper", false),
            new Dog("Sif", true),
            new Dog("Oreo", false),
            new Dog("Johnny", false),
        };
    }

    // allows to acces the List of dogs outside of the class
    IEnumerator<Dog> IEnumerable<Dog>.GetEnumerator()
    {
        return dogs.GetEnumerator();
    }

    IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        throw new NotImplementedException();
    }
}

class Dog
{
    public string Name { get; set; }

    public bool IsNaughtyDog { get; set; }

    public Dog(string name, bool isNaughtyDog)
    {
        this.Name = name;
        this.IsNaughtyDog = isNaughtyDog;
    }

    public void GiveTreat(int numberOfTreats)
    {
        Console.WriteLine("Dog: {0} said wuf {1} times!", Name, numberOfTreats);
    }
}