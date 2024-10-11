using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Person
    {
        public string Name { get; set; }
    }

    static void Main()
    {
        var list1 = new List<Person> { new Person { Name = "Alice" }, new Person { Name = "Bob" } };
        var list2 = new List<Person> { new Person { Name = "Bob" }, new Person { Name = "Charlie" } };

        var commonNames = list1.Select(p => p.Name).Intersect(list2.Select(p => p.Name));

        Console.WriteLine("Common Names:");
        foreach (var name in commonNames)
        {
            Console.WriteLine(name);
        }
    }
}
