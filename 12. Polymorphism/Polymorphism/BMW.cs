using System;
namespace Polymorphism
{
    public class BMW : Car
    {
        public string Model { get; set; }
        private string brand = "BMW";

        public BMW(int hp, string color, string model):base(hp, color)
        {
            Model = model;
        }

        // creates a new method of the same name upon the method from the parent class
        public new void ShowDetails()
        {
            Console.WriteLine("The car's color is {0} and its HP is {1}. The model is a {2} by {3}", Color, HP, Model, brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The {0} is repaired!", brand);
        }
    }
}
