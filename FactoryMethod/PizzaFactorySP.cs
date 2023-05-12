using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PizzaFactorySP : PizzaFactoryMethod
    {
        protected override IPizza CriarPizza(string tipoPizza)
        {
            IPizza pizza = null;

            switch (tipoPizza)
            {
                case "C":
                    pizza = new PizzaCalabrezaSP();
                    break;
                case "D":
                    pizza = new PizzaFrangoSP();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
