using System;

class Program
{
    static void Main(string[] args)
    {

        Address _address = new Address("Street 5", "New York City", "New York", "USA");
        Customer _customer = new Customer("Luis Berrio", _address);
        List<Product> _products = new List<Product>();
        Product _product1 = new Product("Led", 104025, 20, 5);
        Product _product2 = new Product("Computer", 104026, 1000, 1);
        Product _product3 = new Product("Web Cam", 104027, 500, 2);
        _products.Add(_product1);
        _products.Add(_product2);
        _products.Add(_product3);
        Order _order = new Order(_products, _customer);
        _order.PackingLabel();
        Console.WriteLine(_order.ShippingLabel());
        Console.WriteLine(_order.CalculateTotalCost());
        Console.WriteLine("");

        Address _address = new Address("Street 5", "New York City", "New York", "USA");
        Customer _customer = new Customer("Luis Berrio", _address);
        List<Product> _products = new List<Product>();
        Product _product1 = new Product("Led", 104025, 20, 5);
        Product _product2 = new Product("Computer", 104026, 1000, 1);
        Product _product3 = new Product("Web Cam", 104027, 500, 2);
        _products.Add(_product1);
        _products.Add(_product2);
        _products.Add(_product3);
        Order _order = new Order(_products, _customer);
        _order.PackingLabel();
        Console.WriteLine(_order.ShippingLabel());
        Console.WriteLine(_order.CalculateTotalCost());

    }
}