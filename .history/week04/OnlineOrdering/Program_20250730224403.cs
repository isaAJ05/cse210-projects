using System;

class Program
{
    static void Main(string[] args)
    {

        Address _address = new Address("Street 5", "New York City", "New York", "USA");
        Customer _customer = new Customer("Luis Berrio", _address);
        List<Product> _products = new List<Product(>;
        Product _product1 = new Product();
        Product _product2 = new Product();
        Product _product3 = new Product();
        _products.Add(_product1);
        _products.Add(_product2);
        _products.Add(_product3);
        Order _order = new Order(_products, _customer);
        _order.PackingLabel();
        Console.WriteLine(_order.ShippingLabel());
        Console.WriteLine(_order.CalculateTotalCost());
    }
}