using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 2, 3, 4 };
        var prepended = numbers.Prepend(1);

        Console.WriteLine("List After Prepend:");
        prepended.ToList().ForEach(n => Console.WriteLine(n));
    }
}
