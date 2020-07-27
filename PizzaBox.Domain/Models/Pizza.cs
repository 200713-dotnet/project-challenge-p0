using System.Collections.Generic;
using System.Linq;

namespace PizzaBox.Domain.Models
{
  public class Pizza
  {
    public string Name { get; set; }
    public Crust Crust { get; set; }
    public Size Size { get; set; }
    public List<Topping> Toppings { get; set; }
    public decimal Price
    {
      get
      {
        return Crust.Price + Size.Price + Toppings.Sum(t => t.Price);
      }
    }

    public override string ToString()
    {
      return $"{Name}\n{Crust.Name}\n{Size.Name}";
    }
  }
}
