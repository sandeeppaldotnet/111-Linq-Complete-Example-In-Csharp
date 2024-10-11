using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var lastElement = numbers.LastOrDefault();

        Console.WriteLine($"Last Element (default if not found): {lastElement}");
    }
}
