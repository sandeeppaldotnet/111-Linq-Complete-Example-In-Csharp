using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var emptyList = Enumerable.Empty<int>();

        Console.WriteLine($"Empty List Count: {emptyList.Count()}");
    }
}
