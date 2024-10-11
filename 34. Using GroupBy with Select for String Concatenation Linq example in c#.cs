using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }

    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Name = "John", Department = "IT" },
            new Employee { Name = "Jane", Department = "HR" },
            new Employee { Name = "Sam", Department = "IT" },
            new Employee { Name = "Lucy", Department = "HR" }
        };

        var grouped = employees.GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, Count = g.Count() }).ToList();

        Console.WriteLine("Employee Count by Department:");
        grouped.ForEach(g => Console.WriteLine($"{g.Department}: {g.Count}"));
    }
}
