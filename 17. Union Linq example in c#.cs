using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers1 = new List<int> { 1, 2, 3 };
        var numbers2 = new List<int> { 3, 4, 5 };
        var unionNumbers = numbers1.Union(numbers2);

        Console.WriteLine("Union of Numbers:");
        unionNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
