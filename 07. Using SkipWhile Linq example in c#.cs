using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var skipWhileEven = numbers.SkipWhile(n => n % 2 == 0).ToList();

        Console.WriteLine("Numbers Skipped While Even:");
        skipWhileEven.ForEach(n => Console.WriteLine(n));
    }
}
