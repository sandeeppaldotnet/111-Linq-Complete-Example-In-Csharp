using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers1 = new List<int> { 1, 2, 3 };
        var numbers2 = new List<int> { 4, 5, 6 };

        var zipped = numbers1.Zip(numbers2, (a, b) => a + b);

        Console.WriteLine("Zipped Numbers:");
        zipped.ToList().ForEach(n => Console.WriteLine(n));
    }
}
