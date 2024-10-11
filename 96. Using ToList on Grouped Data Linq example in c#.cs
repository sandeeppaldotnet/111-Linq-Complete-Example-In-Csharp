using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Product
    {
        public string Category { get; set; }
    }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Category = "Electronics" },
            new Product { Category = "Clothing" },
            new Product { Category = "Electronics" },
            new Product { Category = "Furniture" }
        };

        var groupedProducts = products.GroupBy(p => p.Category)
            .ToList();

        Console.WriteLine("Grouped Products:");
        foreach (var group in groupedProducts)
        {
            Console.WriteLine($"Category: {group.Key}, Count: {group.Count()}");
        }
    }
}
