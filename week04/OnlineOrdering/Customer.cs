using System;

public class Customer
{
    // Private fields (Encapsulation)
    private string _name;
    private Address _address;

    // Constructor (Initialization)
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Public method to check if customer lives in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Public method to get the shipping label (Customer name + Address)
    public string GetShippingLabel()
    {
        return $"Customer: {_name}\nAddress: {_address.GetFullAddress()}";
    }
}