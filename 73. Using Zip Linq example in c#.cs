using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var names = new List<string> { "Alice", "Bob", "Charlie" };
        var scores = new List<int> { 85, 90, 95 };

        var zipped = names.Zip(scores, (name, score) => $"{name}: {score}");

        Console.WriteLine("Zipped Names and Scores:");
        zipped.ToList().ForEach(z => Console.WriteLine(z));
    }
}
