using System;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public bool LivingInUsa()
    {
        if (_country.ToUpper() == "USA") {
            return true;
        }
        return false;
    }
    public string FullAddress() {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
    public void SetAddress(string street, string city, string state, string country) {

        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}