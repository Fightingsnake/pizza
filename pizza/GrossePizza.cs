using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class GrossePizza : Pizza
    {
        internal decimal faktor = 1.3M;
        public override string Description() => "Pizza, 30cm, Tomatensauce, Kaese";

        public override decimal GetPrice() => base.price * this.faktor;

        public decimal GetFaktor() => faktor;
    }
}
