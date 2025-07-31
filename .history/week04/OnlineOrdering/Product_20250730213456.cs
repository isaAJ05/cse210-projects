using System;
public class Product
{
    private string _name;
    private int _productID;
    private double _price;
    private double _quantity;

    public Product(string name, int productID, double price, double quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }
    public double CalculateTotalCost()
    {
        
    }
}