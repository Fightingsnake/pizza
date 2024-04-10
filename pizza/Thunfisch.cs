using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class Thunfisch : Zutat
    {
        internal decimal preis = 0.8M;
        public Thunfisch(Pizza pizza)
        {
            this.pizza = pizza;
        }
        public override string Description() => pizza.Description() + ", Thunfisch";

        public override decimal GetPrice() => pizza.GetPrice() + (this.preis * pizza.GetFaktor());
    }
}
