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
        double shippingCost = 0;
        if (_customer.PlaceOfLiving = true) {
            shippingCost = 5;
        } else {
            shippingCost = 35;
        }
        return
    }
    public string PackingLabel() {
        return
    }
    public string ShippingLabel() {
        return
    }
}