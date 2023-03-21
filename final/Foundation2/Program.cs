using System;

class Program
{
    static void Main(string[] args)
    {
        string address = "";
        double productTotal = 0.00;

        Console.WriteLine("-------- Order 1 --------");
        Address a1 = new Address("10010 W Meadowlark St.", "Bosie", "ID", "USA");
        address = a1.AddressString();
        Customer c1 = new Customer("Andrew Blad", a1);
        Product p1 = new Product("Milk", "M1101", 2.99, 2);
        Product p2 = new Product("Beans", "B220", .99, 7);
        Order o1 = new Order(c1);
        o1.AddProduct(p1); o1.AddProduct(p2);
        o1.DisplayPackingLabel();
        Console.WriteLine();
        o1.DisplayShippingLabel();
        productTotal = o1.CalculateTotal();
        Console.WriteLine();
        Console.WriteLine($"Order Total: {productTotal}");

        Console.WriteLine();
        Console.WriteLine("-------- Order 2 --------");
        Address a2 = new Address("4356 N Banana St.", "BananaTown", "CK", "BananaLand");
        address = a2.AddressString();
        Customer c2 = new Customer("Bobby Smith", a2);
        Product p3 = new Product("Banana", "B809", .75, 5);
        Product p4 = new Product("BananaBread", "BB123", 5.99, 1);
        Order o2 = new Order(c2);
        o2.AddProduct(p3); o2.AddProduct(p4);
        o2.DisplayPackingLabel();
        Console.WriteLine();
        o2.DisplayShippingLabel();
        productTotal = o2.CalculateTotal();
        Console.WriteLine();
        Console.WriteLine($"Order Total: {productTotal}");
        
    }
}