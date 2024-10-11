using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Product
    {
        public string Category { get; set; }
        public decimal Price { get; set; }
    }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Category = "Electronics", Price = 100.5m },
            new Product { Category = "Clothing", Price = 50.75m },
            new Product { Category = "Electronics", Price = 200.25m },
            new Product { Category = "Furniture", Price = 300.0m }
        };

        var categorySums = products.GroupBy(p => p.Category)
            .Select(g => new { Category = g.Key, TotalPrice = g.Sum(p => p.Price) }).ToList();

        Console.WriteLine("Category Total Prices:");
        categorySums.ForEach(g => Console.WriteLine($"{g.Category}: {g.TotalPrice}"));
    }
}
