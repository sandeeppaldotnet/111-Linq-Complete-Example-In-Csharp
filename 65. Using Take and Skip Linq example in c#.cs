using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        var taken = numbers.Take(5);
        var skipped = numbers.Skip(5);

        Console.WriteLine("Taken Numbers:");
        taken.ToList().ForEach(n => Console.WriteLine(n));

        Console.WriteLine("Skipped Numbers:");
        skipped.ToList().ForEach(n => Console.WriteLine(n));
    }
}
