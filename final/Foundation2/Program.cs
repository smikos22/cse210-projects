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

        Console.WriteLine();
    }
}