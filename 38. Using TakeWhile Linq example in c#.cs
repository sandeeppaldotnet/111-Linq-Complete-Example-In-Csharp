using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var takenNumbers = numbers.TakeWhile(n => n < 4);

        Console.WriteLine("Numbers Taken While Less Than 4:");
        takenNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
