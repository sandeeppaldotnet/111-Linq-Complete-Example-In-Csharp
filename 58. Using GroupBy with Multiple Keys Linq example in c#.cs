using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Student
    {
        public string Name { get; set; }
        public string Course { get; set; }
        public int Year { get; set; }
    }

    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", Course = "Math", Year = 1 },
            new Student { Name = "Bob", Course = "Math", Year = 1 },
            new Student { Name = "Alice", Course = "Science", Year = 2 },
            new Student { Name = "Bob", Course = "Science", Year = 2 }
        };

        var groupedStudents = students.GroupBy(s => new { s.Course, s.Year })
            .Select(g => new { g.Key.Course, g.Key.Year, Count = g.Count() }).ToList();

        Console.WriteLine("Students Grouped by Course and Year:");
        groupedStudents.ForEach(g => Console.WriteLine($"{g.Course} - Year {g.Year}: {g.Count}"));
    }
}
