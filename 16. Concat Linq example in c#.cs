using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var moreNumbers = new List<int> { 4, 5, 6 };
        var allNumbers = numbers.Concat(moreNumbers);

        Console.WriteLine("All Numbers:");
        allNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
