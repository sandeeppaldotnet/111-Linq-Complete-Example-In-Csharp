using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var words = new List<string> { "Hello", "World", "from", "LINQ" };
        var sentence = words.Aggregate((a, b) => a + " " + b);

        Console.WriteLine($"Sentence: {sentence}");

      //Sentence: Hello World from LINQ
    }
}
