using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var minEven = numbers.Where(n => n % 2 == 0).Min();

        Console.WriteLine($"Minimum Even Number: {minEven}");
    }
}
