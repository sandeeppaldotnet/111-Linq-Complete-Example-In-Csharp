using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var skipped = numbers.Skip(2);
        var taken = numbers.Take(3);

        Console.WriteLine("Skipped Numbers:");
        skipped.ToList().ForEach(n => Console.WriteLine(n));

        Console.WriteLine("Taken Numbers:");
        taken.ToList().ForEach(n => Console.WriteLine(n));
    }
}
