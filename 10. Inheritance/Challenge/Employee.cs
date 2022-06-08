using System;
namespace Challenge
{
    public class Employee
    {
        protected string Name { get; set; }
        protected string FirstName { get; set; }
        protected int Salary { get; set; }


        public Employee(string name, string firstName, int salary)
        {
            Name = name;
            FirstName = firstName;
            Salary = salary;
        }

        public virtual void Work()
        {
            Console.WriteLine("{0} {1} is working", Name, FirstName);
        }

        public void Pause()
        {
            Console.WriteLine("{0} {1} is on a break", Name, FirstName);
        }
    }
}
