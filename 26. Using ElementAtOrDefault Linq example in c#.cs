using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var fifthElement = numbers.ElementAtOrDefault(4);

        Console.WriteLine($"Fifth Element (default if not found): {fifthElement}");
    }
}
