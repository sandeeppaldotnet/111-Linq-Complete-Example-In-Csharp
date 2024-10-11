using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Student
    {
        public string Name { get; set; }
        public List<string> Subjects { get; set; }
    }

    static void Main()
    {
        var students = new List<Student>
        {
            new Student { Name = "John", Subjects = new List<string> { "Math", "Science" } },
            new Student { Name = "Jane", Subjects = new List<string> { "English", "History" } }
        };

        var allSubjects = students.SelectMany(s => s.Subjects).Distinct();

        Console.WriteLine("All Subjects:");
        allSubjects.ToList().ForEach(subject => Console.WriteLine(subject));
    }
}
