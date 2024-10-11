using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = Enumerable.Range(1, 10);

        Console.WriteLine("Range of Numbers:");
        numbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
