using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        ArrayList list = new ArrayList { 1, 2, 3 };
        var numbers = list.Cast<int>();

        Console.WriteLine("Cast ArrayList to List:");
        numbers.ToList().ForEach(n => Console.WriteLine(n));
    }
}
