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

        var categoryCounts = products.GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, Count = g.Count() }).ToList();

        Console.WriteLine("Category Counts:");
        categoryCounts.ForEach(g => Console.WriteLine($"{g.Category}: {g.Count}"));
    }
}
