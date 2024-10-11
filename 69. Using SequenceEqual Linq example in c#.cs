using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var list1 = new List<int> { 1, 2, 3 };
        var list2 = new List<int> { 1, 2, 3 };
        var list3 = new List<int> { 3, 2, 1 };

        bool areEqual1 = list1.SequenceEqual(list2);
        bool areEqual2 = list1.SequenceEqual(list3);

        Console.WriteLine($"List1 and List2 are equal: {areEqual1}");
        Console.WriteLine($"List1 and List3 are equal: {areEqual2}");
    }
}
