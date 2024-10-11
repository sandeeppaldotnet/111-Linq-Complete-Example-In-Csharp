using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var numbersArray = numbers.ToArray();

        Console.WriteLine("Array of Numbers:");
        foreach (var n in numbersArray)
        {
            Console.WriteLine(n);
        }
    }
}
