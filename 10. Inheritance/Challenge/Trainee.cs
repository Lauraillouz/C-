using System;
namespace Challenge
{
    public class Trainee : Employee
    {
        protected string WorkingHours { get; set; }
        protected string SchoolHours { get; set; }

        public Trainee(string name, string firstName, int salary, string workingHours, string schoolHours):base(name, firstName, salary)
        {
            this.Name = name;
            this.FirstName = firstName;
            this.Salary = salary;
            this.WorkingHours = workingHours;
            this.SchoolHours = schoolHours;
        }

        public void Learn()
        {
            Console.WriteLine("{0} {1} is learning", Name, FirstName);
        }

        public override void Work()
        {
            Console.WriteLine("{0} {1}'s working hours are: {2}", Name, FirstName, WorkingHours);
        }
    }
}
