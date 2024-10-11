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
        var products = new List<Product>
        {
            new Product { Name = "Unique Product" }
        };

        var uniqueProduct = products.Single();

        Console.WriteLine($"Unique Product: {uniqueProduct.Name}");
    }
}
