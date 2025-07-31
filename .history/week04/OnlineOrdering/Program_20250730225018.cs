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

        Address _address2 = new Address("Street 19A 14-81", "Barranquilla", "Atlántico", "Colombia");
        Customer _customer2 = new Customer("Grey Juliao", _address2);
        List<Product> _products2 = new List<Product>();
        Product _product21 = new Product("TV Samsung", 108059, 1500, 2);
        Product _product22 = new Product("- Washing machine", 104026, 1000, 1);
        Product _product23 = new Product("Web Cam", 104027, 500, 2);
        _products.Add(_product21);
        _products.Add(_product22);
        _products.Add(_product23);
        Order _order2 = new Order(_products2, _customer2);
        _order2.PackingLabel();
        Console.WriteLine(_order2.ShippingLabel());
        Console.WriteLine(_order2.CalculateTotalCost());

    }
}