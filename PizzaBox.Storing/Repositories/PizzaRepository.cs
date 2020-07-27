using System;
using System.Collections.Generic;
using System.Linq;
using domain = PizzaBox.Domain.Models;

namespace PizzaBox.Storing.Repositories
{
  public class PizzaRepository
  {
    private PizzaBoxDbContext _db = new PizzaBoxDbContext();

    public void Create(domain.Pizza pizza)
    {
      var newPizza = new Pizza();

      newPizza.Crust = new Crust() { Name = pizza.Crust.Name };
      newPizza.Size = new Size() { Name = pizza.Size.Name };
      newPizza.Name = pizza.Name;
      var orderDate = DateTime.UtcNow;
      //newPizza.DateModified = DateTime.Now;
      //newPizza.Active = false;
      //newPizza.UserModified = Identity.Hash;

      _db.Pizza.Add(newPizza);
      _db.SaveChanges();
    }

    public List<domain.Pizza> ReadAll()
    {
      var domainPizzaList = new List<domain.Pizza>();

      foreach(var item in _db.Pizza.ToList())
      {
        domainPizzaList.Add(new domain.Pizza()
        {
          Crust = new domain.Crust() { Name = item.Crust.Name },
          Size = new domain.Size() { Name = item.Size.Name },
          Toppings = new List<domain.Topping>()
        });
      };

      return domainPizzaList;
    }

    public void Update() {}

    public void Delete() {}
  }
}
