using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 2, 3, 4 };
        var numberSet = numbers.ToHashSet();

        Console.WriteLine("HashSet of Numbers:");
        foreach (var n in numberSet)
        {
            Console.WriteLine(n);
        }
    }
}
