using System;
namespace Polymorphism
{
    public class Car
    {
        public int HP { get; set; }
        public string Color { get; set; }

        // Has a relationship
        protected CarIDInfo carIdInfo = new CarIDInfo();

        // Setter / constructor for CarIDInfo
        public void SetCarIDInfo(int idNum, string owner)
        {
            carIdInfo.IDNum = idNum;
            carIdInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of: {0} and is owned by {1}", carIdInfo.IDNum, carIdInfo.Owner);
        }

        public Car(int hp, string color) 
        {
            HP = hp;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("The car's color is {0} and its HP is {1}", Color, HP);
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car is repaired!");
        }
    }
}
