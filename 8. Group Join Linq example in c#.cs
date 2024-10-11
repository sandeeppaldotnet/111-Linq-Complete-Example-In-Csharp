using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
    }

    static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer { Id = 1, Name = "Alice" },
            new Customer { Id = 2, Name = "Bob" }
        };

        var orders = new List<Order>
        {
            new Order { Id = 1, CustomerId = 1 },
            new Order { Id = 2, CustomerId = 1 },
            new Order { Id = 3, CustomerId = 2 }
        };

        var groupedOrders = from c in customers
                            join o in orders on c.Id equals o.CustomerId into orderGroup
                            select new { Customer = c.Name, Orders = orderGroup.Count() };

        Console.WriteLine("Customer Orders Count:");
        groupedOrders.ToList().ForEach(g => Console.WriteLine($"{g.Customer}: {g.Orders}"));
    }
}
