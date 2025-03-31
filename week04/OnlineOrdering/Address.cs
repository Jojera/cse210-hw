using System;

public class Address
{
    // Private fields (Encapsulation)
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    // Constructor (Initialization)
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    // Public method to check if the address is in the USA
    public bool IsInUSA()
    {
        return _country.ToLower() == "usa";
    }

    // Public method to get formatted address for shipping label
    public string GetFullAddress()
    {
        return $"{_street}, {_city}, {_state}, {_country}";
    }
}