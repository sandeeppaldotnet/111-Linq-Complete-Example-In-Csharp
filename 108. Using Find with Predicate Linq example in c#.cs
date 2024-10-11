using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000m },
            new Product { Name = "Mouse", Price = 20m },
            new Product { Name = "Keyboard", Price = 50m }
        };

        var foundProduct = products.Find(p => p.Price < 100);

        Console.WriteLine($"Found Product: {foundProduct?.Name ?? "None"}");
    }
}
