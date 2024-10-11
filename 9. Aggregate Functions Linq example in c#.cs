using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        var sum = numbers.Sum();
        var max = numbers.Max();
        var min = numbers.Min();
        var count = numbers.Count();

        Console.WriteLine($"Sum: {sum}, Max: {max}, Min: {min}, Count: {count}");
    }
}
