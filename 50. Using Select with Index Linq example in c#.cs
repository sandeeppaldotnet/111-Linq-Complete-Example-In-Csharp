using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var indexedNumbers = numbers.Select((n, index) => new { Index = index, Value = n });

        Console.WriteLine("Indexed Numbers:");
        indexedNumbers.ToList().ForEach(n => Console.WriteLine($"Index: {n.Index}, Value: {n.Value}"));
    }
}
