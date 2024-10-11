using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
        var groups = numbers.GroupBy(n => n % 2);

        Console.WriteLine("Grouped Numbers:");
        foreach (var group in groups)
        {
            Console.WriteLine($"Key: {group.Key}, Values: {string.Join(", ", group)}");
        }
    }
}
