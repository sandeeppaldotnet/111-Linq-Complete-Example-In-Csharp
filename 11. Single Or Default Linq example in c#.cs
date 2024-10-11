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

        var singleEmployee = employees.SingleOrDefault(e => e.Id == 1);
        Console.WriteLine($"Single Employee: {singleEmployee?.Name}");
    }
}
