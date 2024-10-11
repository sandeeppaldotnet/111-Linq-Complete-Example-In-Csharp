using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
        var distinctNumbers = numbers.Distinct();

        Console.WriteLine("Distinct Numbers:");
        distinctNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
