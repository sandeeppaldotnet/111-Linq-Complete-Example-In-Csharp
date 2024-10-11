using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

        var orderedPeople = people.OrderBy(p => new { p.Age, p.Name });

        Console.WriteLine("People Ordered by Age and Name:");
        orderedPeople.ToList().ForEach(p => Console.WriteLine($"{p.Name}, Age: {p.Age}"));
    }
}
