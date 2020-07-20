using System;
using System.Collections.Generic;

namespace Vending_Machine
{
  class Program
  {
    static void Main()
    {
      var vendingMachine = new Vending_Machine();

      var products = new Dictionary<Product, string>();
      var coke = new Product("Coke", ProductCategory.Beverage, 1.25);
      var pepsi = new Product("Pepsi", ProductCategory.Beverage, 1.00);
      var drPepper = new Product("Dr Pepper", ProductCategory.Beverage, 1.25);

      vendingMachine.AddProduct(coke, 25);
      products.Add(coke, coke.name);
      vendingMachine.AddProduct(pepsi, 35);
      products.Add(pepsi, pepsi.name);
      vendingMachine.AddProduct(drPepper, 45);
      products.Add(drPepper, drPepper.name);
      
      Console.WriteLine("Please insert money into the machine then make your selection.");
      Console.WriteLine("For more information, type `help`.");

      string line;
      bool atMachine = true;
      while(atMachine)
      {
        Console.WriteLine($"Balance: {vendingMachine.Balance:N2}");
        line = Console.ReadLine();

        switch (line.ToLower())
        {
          case "exit":
            atMachine = false;
            break;
          case "help":
            PrintHelp();
            break;
          case "list":
            vendingMachine.ListProducts();
            break;
          default:
            CheckCommand(line.ToLower());
            break;
        }
      }
    }

    private static void CheckCommand(string command)
    {
      if (String.IsNullOrEmpty(command)) {
        return;
      }

      var tokens = command.Split(' ');
      
      if (tokens[0] == "add")
      {
        
      }
    }

    private static void PrintHelp()
    {
      Console.WriteLine("To view all available products, quantities, and prices type `list`.");
      Console.WriteLine("To insert money, type `add <denomination>`. Ex: `add nickel`");
      Console.WriteLine("The vending machine accepts `penny`, `nickel`, `dime`, `quarter`, `coin dollar`, `one dollar`, and `five dollar`.");
      Console.WriteLine("To leave the vending machine, type `exit`.");
    }
  }
}
