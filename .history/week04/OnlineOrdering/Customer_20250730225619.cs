using System;
using System.Net.Sockets;
public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public bool PlaceOfLiving()
    {
        return _address.LivingInUsa();
    }
    public void SetCustomer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    public string GetCustomerName()
    {
        return _name;
    }
    public string GetCostumerAddress() {
        return _address.FullAddress();
    } 
}