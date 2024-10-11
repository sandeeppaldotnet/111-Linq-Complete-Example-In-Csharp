using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        var skippedLastThree = numbers.SkipLast(3);

        Console.WriteLine("Skipped Last Three Numbers:");
        skippedLastThree.ToList().ForEach(n => Console.WriteLine(n));
    }
}
