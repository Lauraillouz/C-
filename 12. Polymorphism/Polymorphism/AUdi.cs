using System;
namespace Polymorphism
{
    public class Audi : Car
    {
        private string brand = "audi";
        public string Model { get; set; }


        public Audi(int hp, string color, string model) : base(hp, color)
        {
            Model = model;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("The car's color is {0} and its HP is {1}. The model is a {2} by {3}", Color, HP, Model, brand);
        }

        public override void Repair()
        {
            Console.WriteLine("The {0} is repaired!", brand);
        }
    }
}
