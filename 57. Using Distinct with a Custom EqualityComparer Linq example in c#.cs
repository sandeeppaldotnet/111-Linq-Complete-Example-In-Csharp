using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Person
    {
        public string Name { get; set; }
    }

    public class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y) => x.Name == y.Name;
        public int GetHashCode(Person obj) => obj.Name.GetHashCode();
    }

    static void Main()
    {
        var people = new List<Person>
        {
            new Person { Name = "John" },
            new Person { Name = "Jane" },
            new Person { Name = "John" }
        };

        var distinctPeople = people.Distinct(new PersonComparer());

        Console.WriteLine("Distinct People:");
        foreach (var person in distinctPeople)
        {
            Console.WriteLine(person.Name);
        }
    }
}
