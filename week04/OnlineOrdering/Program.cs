using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // address and customers
        Address addr1 = new Address("123 Main St", "Orlando", "FL", "USA");
        Address addr2 = new Address("456 Maple Ave", "Toronto", "ON", "Canada");
        Address addr3 = new Address("789 Oak Rd", "Seattle", "WA", "USA");

        Customer cust1 = new Customer("Alice Johnson", addr1);
        Customer cust2 = new Customer("Bob Smith", addr2);
        Customer cust3 = new Customer("Carol Lee", addr3);

        // Products
        Product prod1 = new Product("Mouse", "P001", 25.00m, 2);
        Product prod2 = new Product("keyboard", "P002", 45.00m, 1);
        Product prod3 = new Product("Monitor", "P003", 150.00m, 1);
        Product prod4 = new Product("HDMI cable", "P004", 10.00m, 3);
        Product prod5 = new Product("Webcam", "P005", 60.00m, 1);
        Product prod6 = new Product("Headset", "P006", 35.00m, 2);

        // orders
        Order order1 = new Order(new List<Product> { prod1, prod2 }, cust1);
        Order order2 = new Order(new List<Product> { prod3, prod4, prod5 }, cust2);
        Order order3 = new Order(new List<Product> { prod6, prod1 }, cust3);

        // show informations
        List<Order> orders = new List<Order> { order1, order2, order3 };
        int i = 1;
        foreach (var order in orders)
        {
            Console.WriteLine($"--- Order {i} ---");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"Total cost: ${order.GetTotalCost():F2}\n");
            i++;
        }
    }
}