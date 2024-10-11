using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = new List<int> { 4, 5, 6 };

        var concatenated = list1.Concat(list2);

        Console.WriteLine("Concatenated List:");
        concatenated.ToList().ForEach(n => Console.WriteLine(n));
    }
}
