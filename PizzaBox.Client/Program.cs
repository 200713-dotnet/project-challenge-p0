using System;
using PizzaBox.Domain.Models;
using PizzaBox.Storing.Repositories;

namespace PizzaBox.Client
{
  class Program
  {
    static void Main(string[] args)
    {
      var pr = new PizzaRepository();
      var pizza = new Pizza()
      {
        Name = "Cheesy Pizza",
        Crust = new Crust() { Name = "NY Style" },
        Size = new Size() { Name = "Medium" },
        Toppings = new System.Collections.Generic.List<Topping>() { new Topping() { Name = "Cheese"}}
      };
      
      pr.Create(pizza);
      Console.ReadLine();

      foreach (var item in pr.ReadAll())
      {
        System.Console.WriteLine(item); 
      }
    }
  }
}
