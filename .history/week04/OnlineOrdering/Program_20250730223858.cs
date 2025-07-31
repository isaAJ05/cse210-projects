using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> _products = new List<Product>;
        Product _product1 = new Product();
        Product _product2 = new Product();
        Product _product3 = new Product();
        _products.Add(_product1);
        _products.Add(_product2);
        _products.Add(_product1);
        Order _order = new Order();
    }
}