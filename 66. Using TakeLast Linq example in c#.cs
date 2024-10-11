using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        var lastThree = numbers.TakeLast(3);

        Console.WriteLine("Last Three Numbers:");
        lastThree.ToList().ForEach(n => Console.WriteLine(n));
    }
}
