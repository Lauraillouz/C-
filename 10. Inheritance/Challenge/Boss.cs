using System;
namespace Challenge
{
    public class Boss : Employee
    {
        protected string CompagnyCar { get; set; }

        public Boss(string name, string firstName, int salary, string compagnyCar):base(name, firstName, salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.CompagnyCar = compagnyCar;
        }

        public void Lead()
        {
            Console.WriteLine("{0} {1} is leading", Name, FirstName);
        }
    }
}
