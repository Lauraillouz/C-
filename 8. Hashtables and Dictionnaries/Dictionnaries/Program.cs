using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionnaries
{
    class Program
    {
        static void Main(string[] args)
        {
            // create new instances of class Employee and store them in an array employees
            Employee[] employees =
            {
                new Employee("CEO", "Lin", 95, 200),
                new Employee("Manager", "Joe", 35, 25),
                new Employee("HR", "Mary", 32, 21),
                new Employee("Secretary", "Joe", 28, 18),
                new Employee("Lead Developer", "Laura", 95, 50),
                new Employee("Intern", "Karl", 22, 8),

            };

            // create dictionnary entry
            Dictionary<string, Employee> employeesDirectory = new Dictionary<string, Employee>();

            // iterate over employees array and store keys/values into employeesDirectory Dictionary
            foreach(Employee emp in employees)
            {
                employeesDirectory.Add(emp.Role, emp);
            }

            // iterate over our dictionnary to get index of element via KeyValuePair
            for (int i = 0; i < employeesDirectory.Count; i++)
            {
                // using ElementAt(i) to return the key-value pair stored at index 1
                KeyValuePair<string, Employee> keyValuePair = employeesDirectory.ElementAt(i);

                // print the key
                Console.WriteLine("Key: {0}", keyValuePair.Key);

                // store the value in an employee object
                Employee employeeValue = keyValuePair.Value;

                // print the properties of the employee object
                Console.WriteLine("Employee Name: {0}", employeeValue.Name);
                Console.WriteLine("Employee Role: {0}", employeeValue.Role);
                Console.WriteLine("Employee Age: {0}", employeeValue.Age);
                Console.WriteLine("Employee Salary: {0}", employeeValue.Salary);

            }


            string key = "CEO";

            // add a condition to prevent the app from crashing if key doesn't exist
            if(employeesDirectory.ContainsKey(key))
            {
                // call an instance of class already created and stored in Dictionary
                Employee empl = employeesDirectory["CEO"];
                // Display informations of instance retrieved above
                Console.WriteLine("Employee name: {0}, role: {1}, salary: {2}", empl.Name, empl.Role, empl.Salary);
            }
            else
            {
                Console.WriteLine("No employee found with this role");
            }

            // other way of doing the above
            Employee result = null;

            // using TryGetValue() returns true if the operation was successful and false otherwise
            if(employeesDirectory.TryGetValue("Intern", out result))
            {
                Console.WriteLine("Value retrieveed!");

                Console.WriteLine("Employee name: {0}", result.Name);
                Console.WriteLine("Employee role: {0}", result.Role);
                Console.WriteLine("Employee age: {0}", result.Age);
                Console.WriteLine("Employee salary: {0}", result.Salary);

            }
            else
            {
                Console.WriteLine("this key does not exist");
            }


            // UPDATE A KEY ENTRY
            string KeyToUpdate = "HR";
            if (employeesDirectory.ContainsKey(KeyToUpdate))
            {
                employeesDirectory[KeyToUpdate] = new Employee("HR", "Eleka", 26, 18);
                Console.WriteLine("Employee with Role/Key {0} was updated", KeyToUpdate);
            }
            else
            {
                Console.WriteLine("Sorry, we could not find this key to update");
            }


            // REMOVE A KEY ENTRY
            string KeyToRemove = "Intern";
            if(employeesDirectory.ContainsKey(KeyToRemove))
            {
                employeesDirectory.Remove(KeyToRemove);
                Console.WriteLine("Employee with Role/Key {0} has been removed", KeyToRemove);
            }
            else
            {
                Console.WriteLine("Sorry, this role does not exist");
            }

        }
    }

    class Employee
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Rate { get; set; }

        // Rate/h * nb of days/week * nb of weeks/month * nb of months
        public float Salary
        {
            get
            {
                return Rate * 8 * 5 * 4 * 12;
            }
        }

        public Employee(string role, string name, int age, float rate)
        {
            this.Role = role;
            this.Name = name;
            this.Age = age;
            this.Rate = rate;
        }
    }
}
