using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
    }

    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "John", Department = "IT", Salary = 50000 },
            new Employee { Name = "Jane", Department = "HR", Salary = 60000 },
            new Employee { Name = "Sam", Department = "IT", Salary = 70000 },
            new Employee { Name = "Lucy", Department = "HR", Salary = 80000 }
        };

        var groupedSalaries = employees.GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, TotalSalary = g.Sum(e => e.Salary) }).ToList();

        Console.WriteLine("Total Salary by Department:");
        groupedSalaries.ForEach(g => Console.WriteLine($"{g.Department}: {g.TotalSalary}"));
    }
}
