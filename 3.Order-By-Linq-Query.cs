using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 5, 3, 4, 1, 2 };
        var orderedNumbers = numbers.OrderBy(n => n);

        Console.WriteLine("Ordered Numbers:");
        orderedNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
