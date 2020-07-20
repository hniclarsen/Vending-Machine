using System;
using System.Collections.Generic;

namespace Vending_Machine
{
  class Vending_Machine
  {
    public double Balance { get; private set; }
    private Dictionary<Product,int> ProductQuantity { get; set; }

    public Vending_Machine()
    {
      ProductQuantity = new Dictionary<Product, int>();
      Balance = 0.00;
    }

    public void AddProduct(Product product, int quantity)
    {
      ProductQuantity.Add(product, quantity);
    }

    public void AddChange(double change)
    {
      Balance += change;
    }

    public void ListProducts()
    {
      Console.WriteLine("Available products & quantities:");

      foreach (var product in ProductQuantity)
      {
        Console.WriteLine($"{product.Key.name}, Quantity: {product.Value}, Price: {product.Key.Price}");
      }
    }
  }
}
