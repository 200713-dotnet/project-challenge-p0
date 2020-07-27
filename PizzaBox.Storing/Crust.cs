using System;
using System.Collections.Generic;

namespace PizzaBox.Storing
{
    public partial class Crust
    {
        public Crust()
        {
            Pizza = new HashSet<Pizza>();
        }

        public int CrustId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Pizza> Pizza { get; set; }
    }
}
