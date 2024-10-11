using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers1 = new List<int> { 1, 2, 3 };
        var numbers2 = new List<int> { 2, 3, 4 };
        var exceptNumbers = numbers1.Except(numbers2);

        Console.WriteLine("Numbers Except:");
        exceptNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
