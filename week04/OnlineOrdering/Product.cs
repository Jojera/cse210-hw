using System;

public class Product
{
    // Private fields (Encapsulation)
    private string _name;
    private string _productId;
    private decimal _price;
    private int _quantity;

    // Constructor (Initialization)
    public Product(string name, string productId, decimal price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    // Public method to calculate total cost of the product
    public decimal GetTotalCost()
    {
        return _price * _quantity;
    }

    // Public method to display product details for the packing label
    public string GetPackingLabel()
    {
        return $"Product: {_name} (ID: {_productId})";
    }
}