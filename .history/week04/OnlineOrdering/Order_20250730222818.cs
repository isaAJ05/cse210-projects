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
        if (_customer.PlaceOfLiving = true) {
            s
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