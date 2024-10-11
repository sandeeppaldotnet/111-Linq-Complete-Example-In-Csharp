using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var fourthElement = numbers.ElementAtOrDefault(3); // Index 3 is the fourth element

        Console.WriteLine($"Fourth Element: {fourthElement}");
    }
}
