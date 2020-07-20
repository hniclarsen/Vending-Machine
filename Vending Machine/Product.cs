namespace Vending_Machine
{
  class Product
  {
    public readonly string name;
    public readonly ProductCategory type;
    public double Price { get; set; }

    public Product(string name, ProductCategory type = ProductCategory.Unclassified, double price = 0.00)
    {
      this.name = name;
      this.type = type;
      Price = price;
    }
  }
}
