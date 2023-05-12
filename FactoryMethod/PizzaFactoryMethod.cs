using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class PizzaFactoryMethod
    {
        public IPizza MontarPizza(string tipo)
        {
            IPizza pizza = CriarPizza(tipo);
            return pizza;
        }

        protected abstract IPizza CriarPizza(string tipo);
    }
}
