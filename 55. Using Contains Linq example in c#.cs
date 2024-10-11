using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 };
        bool containsThree = numbers.Contains(3);

        Console.WriteLine($"Contains 3: {containsThree}");
    }
}
