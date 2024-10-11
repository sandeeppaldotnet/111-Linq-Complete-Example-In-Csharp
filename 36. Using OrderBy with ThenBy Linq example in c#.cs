using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "John", Department = "IT", Age = 25 },
            new Employee { Name = "Jane", Department = "HR", Age = 30 },
            new Employee { Name = "Sam", Department = "IT", Age = 22 },
            new Employee { Name = "Lucy", Department = "HR", Age = 28 }
        };

        var orderedEmployees = employees.OrderBy(e => e.Department).ThenBy(e => e.Age).ToList();

        Console.WriteLine("Ordered Employees:");
        orderedEmployees.ForEach(e => Console.WriteLine($"{e.Name} - {e.Department} - {e.Age}"));
    }
}
