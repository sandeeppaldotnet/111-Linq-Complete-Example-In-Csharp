using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var randomNumbers = Enumerable.Range(1, 10).OrderBy(x => Guid.NewGuid());

        Console.WriteLine("Random Numbers:");
        randomNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
