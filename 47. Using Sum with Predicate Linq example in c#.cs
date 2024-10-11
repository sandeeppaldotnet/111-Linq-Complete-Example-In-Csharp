using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        var sumOfEvens = numbers.Where(n => n % 2 == 0).Sum();

        Console.WriteLine($"Sum of Even Numbers: {sumOfEvens}");
    }
}
