using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var firstFive = numbers.Take(5).ToList();
        var skipFirstFive = numbers.Skip(5).ToList();

        Console.WriteLine("First Five Numbers:");
        firstFive.ForEach(n => Console.WriteLine(n));

        Console.WriteLine("Skip First Five Numbers:");
        skipFirstFive.ForEach(n => Console.WriteLine(n));
    }
}
