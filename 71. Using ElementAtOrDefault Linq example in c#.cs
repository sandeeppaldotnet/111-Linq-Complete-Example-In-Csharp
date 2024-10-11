using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var sixthElement = numbers.ElementAtOrDefault(5); // Index out of range

        Console.WriteLine($"Sixth Element (or default): {sixthElement}");
    }
}
