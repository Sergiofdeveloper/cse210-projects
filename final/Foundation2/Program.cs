using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Product product1 = new Product("Item1", "P1", 2.00, 5);
        Product product2 = new Product("Item2", "P2", 3.50, 10);
        Product product3 = new Product("Item3", "P3", 5.00, 4);
        Product product4 = new Product("Item4", "P4", 7.50, 6);
     
        Address address1 = new Address("Calle Dinamarca 25", "Barcelona", "Cataluña", "Spain");
        Address address2 = new Address(" 17 Dove St", "New York", "New York", "USA");
        Address address3 = new Address("456 Seashore St", "San Diego", "California", "USA");
    
        Customer customer1 = new Customer("Customer 1", address1);
        Customer customer2 = new Customer("Customer 2", address2);
        Customer customer3 = new Customer("Customer 3", address3);

        Order order1 = new Order(customer1, new List<Product> { product1});
        Order order2 = new Order(customer2, new List<Product> { product2 });
        Order order3 = new Order(customer3, new List<Product> { product3, product4  });

       
        Console.WriteLine("Order 1");
        Console.WriteLine("Order Label:");
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.TotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Order Label:");
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.TotalCost());
        Console.WriteLine();

        Console.WriteLine("Order 3");
        Console.WriteLine("Order Label:");
        Console.WriteLine(order3.PackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.ShippingLabel());
        Console.WriteLine("Total Cost: $" + order3.TotalCost());

    }
}
