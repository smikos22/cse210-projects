using System;

class Program
{
    static void Main(string[] args)
    {
        string street = "3314 N Brindley Ave";
        string city = "Litchfield Park";
        string state = "AZ";
        string country = "USA";

        Address address = new Address(street, city, state, country);
        Customer customer = new Customer("Sarah Mikos", address);

        List<string> productNames = new List<string>();
        List<int> productIds = new List<int>();
        List<int> productPrices = new List<int>();
        List<int> productQuantities = new List<int>();

        productNames.Add("Protein Bar");
        productIds.Add(1);
        productPrices.Add(2);
        productQuantities.Add(20);

        productNames.Add("Milk");
        productIds.Add(2);
        productPrices.Add(2);
        productQuantities.Add(10);

        productNames.Add("Bread");
        productIds.Add(3);
        productPrices.Add(2);
        productQuantities.Add(30);

        productNames.Add("Hand Cream");
        productIds.Add(4);
        productPrices.Add(4);
        productQuantities.Add(10);

        productNames.Add("Tennis Shoes");
        productIds.Add(5);
        productPrices.Add(40);
        productQuantities.Add(1);

        List<Product> firstOrderProducts = new List<Product>();

        for (int i = 0; i < 3; i++)
        {
            firstOrderProducts.Add(new Product(productNames[i], productIds[i], productPrices[i], productQuantities[i]));

        }

        Order firstOrder = new Order(firstOrderProducts, customer);

        Console.WriteLine(firstOrder.GetPackingLabel());
        Console.WriteLine(firstOrder.GetShippingLabel());
        Console.WriteLine(firstOrder.GetOrderTotal());
        List<Product> secondOrderProducts = new List<Product>();
        for (int i = 3; i<5; i++)
        {
            secondOrderProducts.Add(new Product(productNames[i], productIds[i], productPrices[i], productQuantities[i]));

        }
        Order secondOrder = new Order(firstOrderProducts, customer);

        Console.WriteLine(secondOrder.GetPackingLabel());
        Console.WriteLine(secondOrder.GetShippingLabel());
        Console.WriteLine(secondOrder.GetOrderTotal());



       

        Console.WriteLine(address.GetFormatedAddress());
    }
}