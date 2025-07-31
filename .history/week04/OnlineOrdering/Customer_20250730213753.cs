using System;
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, int productID, double price, double quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
