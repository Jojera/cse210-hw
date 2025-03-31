using System;
using System.Collections.Generic;

public class Order
{
    // Private fields (Encapsulation)
    private List<Product> _products;
    private Customer _customer;

    // Constructor (Initialization)
    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>(); // Initialize an empty list
    }

    // Public method to add products to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Public method to calculate the total cost of the order (including shipping)
    public decimal GetTotalCost()
    {
        decimal total = 0;

        foreach (Product product in _products)
        {
            total += product.GetTotalCost();
        }

        // Add shipping cost
        total += _customer.IsInUSA() ? 5 : 35;

        return total;
    }

    // Public method to generate packing label (list of product names & IDs)
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";

        foreach (Product product in _products)
        {
            label += product.GetPackingLabel() + "\n";
        }

        return label;
    }

    // Public method to generate shipping label (customer name & address)
    public string GetShippingLabel()
    {
        return "Shipping Label:\n" + _customer.GetShippingLabel();
    }
}