using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
    }

    static void Main()
    {
        var products = new List<Product>
        {
            new Product { Name = "Laptop", Price = 1000m, Category = "Electronics" },
            new Product { Name = "Mouse", Price = 20m, Category = "Electronics" },
            new Product { Name = "Shirt", Price = 30m, Category = "Clothing" },
            new Product { Name = "Jeans", Price = 50m, Category = "Clothing" }
        };

        var orderedProducts = products.OrderBy(p => p.Category).ThenByDescending(p => p.Price);

        Console.WriteLine("Products Ordered by Category and Price (Descending):");
        orderedProducts.ToList().ForEach(p => Console.WriteLine($"{p.Category} - {p.Name}: {p.Price}"));
    }
}
