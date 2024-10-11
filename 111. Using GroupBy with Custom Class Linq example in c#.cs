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
            new Employee { Name = "Alice", Department = "HR" },
            new Employee { Name = "Bob", Department = "IT" },
            new Employee { Name = "Charlie", Department = "HR" },
            new Employee { Name = "David", Department = "IT" }
        };

        var groupedEmployees = employees.GroupBy(e => e.Department)
            .Select(g => new { Department = g.Key, Employees = g.ToList() });

        Console.WriteLine("Employees Grouped by Department:");
        foreach (var group in groupedEmployees)
        {
            Console.WriteLine($"Department: {group.Department}");
            group.Employees.ForEach(e => Console.WriteLine($" - {e.Name}"));
        }
    }
}
