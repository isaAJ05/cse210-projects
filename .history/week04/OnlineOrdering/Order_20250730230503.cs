using System;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double CalculateTotalCost()
    {
        double shippingCost;
        double total = 0;

        foreach (Product p in _products) {
            total += p.CalculateTotalCost();
        }
        if (_customer.PlaceOfLiving() == true) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }

        return total + shippingCost;
    }
    public string PackingLabel() {
        string aux = "";
        foreach (Product p in _products)
        {
            p.GetName(), p.GetProductID());
        }
        return aux;
    }
    public string ShippingLabel()
    {
        return $"{_customer.GetCustomerName}, {_customer.GetCostumerAddress}";
    }
}