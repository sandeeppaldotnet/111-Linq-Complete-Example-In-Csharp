using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class School
    {
        public string Name { get; set; }
        public List<string> Students { get; set; }
    }

    static void Main()
    {
        var schools = new List<School>
        {
            new School { Name = "School A", Students = new List<string> { "Alice", "Bob" } },
            new School { Name = "School B", Students = new List<string> { "Charlie", "David" } }
        };

        var allStudents = schools.SelectMany(s => s.Students).ToList();

        Console.WriteLine("All Students:");
        allStudents.ForEach(student => Console.WriteLine(student));
    }
}
