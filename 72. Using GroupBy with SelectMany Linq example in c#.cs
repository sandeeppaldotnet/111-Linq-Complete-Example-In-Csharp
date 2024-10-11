using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Order
    {
        public string Customer { get; set; }
        public List<string> Items { get; set; }
    }

    static void Main()
    {
        var orders = new List<Order>
        {
            new Order { Customer = "Alice", Items = new List<string> { "Item1", "Item2" } },
            new Order { Customer = "Bob", Items = new List<string> { "Item3" } },
            new Order { Customer = "Alice", Items = new List<string> { "Item4" } }
        };

        var customerItems = orders.GroupBy(o => o.Customer)
            .SelectMany(g => g.SelectMany(o => o.Items)).ToList();

        Console.WriteLine("Items Ordered by Customers:");
        customerItems.ForEach(item => Console.WriteLine(item));
    }
}
