using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating Address 1 (USA)
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");

        // Creating Customer 1
        Customer customer1 = new Customer("Jonathan Ojera", address1);

        // Creating Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99m, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50m, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 49.99m, 1));

        // Displaying Order 1 Details
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        // Creating Address 2 (Non-USA)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");

        // Creating Customer 2
        Customer customer2 = new Customer("Brandon Goerge", address2);

        // Creating Order 2
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P004", 79.99m, 1));
        order2.AddProduct(new Product("Monitor", "P005", 199.99m, 1));

        // Displaying Order 2 Details
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}\n");
    }
}

