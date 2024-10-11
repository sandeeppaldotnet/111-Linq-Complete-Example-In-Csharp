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
        public int CustomerId { get; set; }
        public string Product { get; set; }
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
            new Order { CustomerId = 1, Product = "Laptop" },
            new Order { CustomerId = 2, Product = "Mouse" }
        };

        var customerOrders = customers.Join(orders,
            customer => customer.Id,
            order => order.CustomerId,
            (customer, order) => new { customer.Name, order.Product }).ToList();

        Console.WriteLine("Customer Orders:");
        customerOrders.ForEach(co => Console.WriteLine($"{co.Name} ordered {co.Product}"));
    }
}
