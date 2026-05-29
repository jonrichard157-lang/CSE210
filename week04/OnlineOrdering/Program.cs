using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address(
            "123 Main Street",
            "New York",
            "NY",
            "USA"
        );

        Address address2 = new Address(
            "Rua A",
            "São Paulo",
            "SP",
            "Brazil"
        );

        Customer customer1 = new Customer("John Smith", address1);
        Customer customer2 = new Customer("João Ricardo", address2);

        Product product1 = new Product("Keyboard", "K100", 50, 2);
        Product product2 = new Product("Mouse", "M200", 25, 1);
        Product product3 = new Product("Monitor", "MN300", 200, 1);

        Product product4 = new Product("Headset", "H400", 80, 1);
        Product product5 = new Product("Webcam", "W500", 120, 2);

        Order order1 = new Order(customer1);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("ORDER 1");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order1.CalculateTotalPrice()}");

        Console.WriteLine("\n-----------------------\n");

        Console.WriteLine("ORDER 2");
        Console.WriteLine();

        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order2.CalculateTotalPrice()}");
    }
}