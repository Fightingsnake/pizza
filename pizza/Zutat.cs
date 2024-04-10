using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal abstract class Zutat : Pizza
    {
        protected Pizza pizza;

        public abstract override string Description();

        public abstract override decimal GetPrice();
    }
}
