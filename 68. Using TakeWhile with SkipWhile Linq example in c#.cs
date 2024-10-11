using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        var takenWhile = numbers.TakeWhile(n => n < 4);
        var skippedWhile = numbers.SkipWhile(n => n < 4);

        Console.WriteLine("Taken While Less Than 4:");
        takenWhile.ToList().ForEach(n => Console.WriteLine(n));

        Console.WriteLine("Skipped While Less Than 4:");
        skippedWhile.ToList().ForEach(n => Console.WriteLine(n));
    }
}
