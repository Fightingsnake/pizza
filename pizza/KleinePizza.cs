using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal class KleinePizza : Pizza
    {
        internal decimal faktor = 0.8M;
        public override string Description() => "Pizza, 20cm, Tomatensauce, Kaese";
        public override decimal GetPrice() => base.price * this.faktor;
        public decimal GetFaktor() => faktor;
    }
}
