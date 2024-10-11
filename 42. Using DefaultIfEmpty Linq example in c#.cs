using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int>();
        var defaultNumber = numbers.DefaultIfEmpty(-1).First();

        Console.WriteLine($"Default If Empty: {defaultNumber}");
    }
}
