using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    public class Item
    {
        public decimal Price { get; set; }
    }

    static void Main()
    {
        var items = new List<Item>
        {
            new Item { Price = 10.5m },
            new Item { Price = 20.75m },
            new Item { Price = 30.25m }
        };

        var totalPrice = items.Sum(i => i.Price);

        Console.WriteLine($"Total Price: {totalPrice}");
    }
}
