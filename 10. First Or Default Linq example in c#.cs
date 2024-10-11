using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var firstEven = numbers.FirstOrDefault(n => n % 2 == 0);

        Console.WriteLine($"First Even Number: {firstEven}");
    }
}
