using System;

class Program
{
    static void Main(string[] args)
    {
        // Create first order
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Victor Mtisi", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "P002", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "P003", 75.00, 1));

        // Create second order
        Address address2 = new Address("15968 Damafalls", "Harare", "ON", "Zimbabwe");
        Customer customer2 = new Customer("Philani Mtisi", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Monitor", "P004", 350.00, 2));
        order2.AddProduct(new Product("USB Cable", "P005", 12.99, 3));

        // Display order 1
        Console.WriteLine("ORDER 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():F2}");
        Console.WriteLine();

        // Display order 2
        Console.WriteLine("ORDER 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():F2}");
    }
}