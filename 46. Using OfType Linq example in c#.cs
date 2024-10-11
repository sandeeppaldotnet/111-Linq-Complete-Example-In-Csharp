using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList { 1, "two", 3, "four" };
        var numbers = list.OfType<int>();

        Console.WriteLine("OfType<int> from ArrayList:");
        numbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
