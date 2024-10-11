using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var sum = numbers.Aggregate((total, next) => total + next);

        Console.WriteLine($"Sum of Numbers: {sum}");
    }
}
