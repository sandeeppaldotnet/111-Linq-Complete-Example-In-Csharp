using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var repeated = Enumerable.Repeat(5, 3);

        Console.WriteLine("Repeated Number:");
        repeated.ToList().ForEach(n => Console.WriteLine(n));
    }
}
