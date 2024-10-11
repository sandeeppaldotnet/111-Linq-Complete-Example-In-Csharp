using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 4, 5 }.AsQueryable();
        var evenNumbers = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even Numbers using AsQueryable:");
        evenNumbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
