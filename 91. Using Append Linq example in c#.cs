using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var appended = numbers.Append(4);

        Console.WriteLine("List After Append:");
        appended.ToList().ForEach(n => Console.WriteLine(n));
    }
}
