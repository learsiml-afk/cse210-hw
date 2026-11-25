using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1: customer in the USA
        Address address1 = new Address("123 Main St", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Sarah Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Widget", "W100", 3.50, 4));
        order1.AddProduct(new Product("USB Cable", "C200", 8.25, 2));
        order1.AddProduct(new Product("Notebook", "N300", 2.00, 10));

        // Order 2: customer outside the USA
        Address address2 = new Address("Av. Revolución 456", "Tijuana", "Baja California", "Mexico");
        Customer customer2 = new Customer("Carlos Ramírez", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Keyboard", "K400", 45.00, 1));
        order2.AddProduct(new Product("Mouse", "M500", 19.99, 2));

        DisplayOrder(order1);
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice():F2}");
        Console.WriteLine("----------------------------------------\n");
    }
}