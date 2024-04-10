using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class MittlerePizza : Pizza
    {
        internal decimal faktor = 1;
        public override string Description() => "Pizza, 25cm, Tomatensauce, Kaese";

        public override decimal GetPrice() => base.price;
        public decimal GetFaktor() => faktor;
    }
}
