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
        public DateTime OrderDate { get; set; }
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
            new Order { Id = 1, CustomerId = 1, OrderDate = DateTime.Now },
            new Order { Id = 2, CustomerId = 2, OrderDate = DateTime.Now }
        };

        var customerOrders = from c in customers
                             join o in orders on c.Id equals o.CustomerId
                             select new { c.Name, o.OrderDate };

        Console.WriteLine("Customer Orders:");
        customerOrders.ToList().ForEach(co => Console.WriteLine($"{co.Name}: {co.OrderDate}"));
    }
}
