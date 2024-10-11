using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 2, 4, 6, 8 };
        bool allEven = numbers.All(n => n % 2 == 0);

        Console.WriteLine($"All Numbers Are Even: {allEven}");
    }
}
