using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 3, 5 };
        bool hasEven = numbers.Any(n => n % 2 == 0);

        Console.WriteLine($"Any Number Is Even: {hasEven}");
    }
}
