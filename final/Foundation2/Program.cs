using System;

class Program
{
    static void Main(string[] args)
    {
         // Create some product
            Product product1 = new Product("Knife", "W123", 10.0, 2);
            Product product2 = new Product("Eraser", "E456", 5.0, 5);
            Product product3 = new Product("Mouse", "M345", 20.0, 1);
            Product product4 = new Product("Notebook", "N123", 25.0, 1);
            
            // Create some addresses
            Address address1 = new Address("123 Main St","Utah","CA","USA");
            Address address2 = new Address("456 Elm St","Toronto","ON","Canada");

            // Create some customers
            Customer customer1 = new Customer("Chad Macbeth", address1);
            Customer customer2 = new Customer("Jane Smith", address2);

            // Create some orders
            Order order1 = new Order(customer1);
            order1.AddProduct(product1);
            order1.AddProduct(product2);

            Order order2 = new Order(customer2);
            order2.AddProduct(product3);
            order2.AddProduct(product4);
            
          

            // Display order details
            Console.WriteLine("Order 1");
            Console.WriteLine("=======================");
            order1.DisplayOrderDetails();

            Console.WriteLine("Order 2");
            Console.WriteLine("========================");
            order2.DisplayOrderDetails();
        
     }     
}
