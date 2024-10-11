using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3 };
        var firstNumber = numbers.FirstOrDefault();

        Console.WriteLine($"First Number: {firstNumber}");
    }
}
