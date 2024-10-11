using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var secondElement = numbers.ElementAt(1); // Zero-based index

        Console.WriteLine($"Second Element: {secondElement}");
    }
}
