using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "John" },
            new Employee { Id = 2, Name = "Jane" }
        };

        var employeeDict = employees.ToDictionary(e => e.Id, e => e.Name);

        Console.WriteLine("Employee Dictionary:");
        foreach (var kvp in employeeDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
