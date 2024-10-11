using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };

        Console.WriteLine("Numbers:");
        numbers.ForEach(n => Console.WriteLine(n));
    }
}
