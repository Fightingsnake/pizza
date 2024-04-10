using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizza
{
    internal abstract class Pizza
    {
        protected string description;
        protected decimal price = 6M;
        protected decimal faktor;

        public abstract string Description();
        public abstract decimal GetPrice();
        public virtual decimal GetFaktor() => faktor;
    }
}
