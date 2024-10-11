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

        var peopleDict = people.ToDictionary(p => p.Name, p => p.Age);

        Console.WriteLine("People Dictionary:");
        foreach (var kvp in peopleDict)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
