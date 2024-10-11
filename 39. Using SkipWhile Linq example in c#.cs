using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var skippedNumbers = numbers.SkipWhile(n => n < 4);

        Console.WriteLine("Numbers Skipped While Less Than 4:");
        skippedNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
