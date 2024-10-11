using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Product
    {
        public string Name { get; set; }
    }

    static void Main()
    {
        var products = new List<Product>();

        var uniqueProduct = products.SingleOrDefault();

        Console.WriteLine($"Unique Product (or default): {uniqueProduct?.Name ?? "None"}");
    }
}
