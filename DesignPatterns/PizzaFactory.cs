using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    // Sealed impede que outras classes herdem desta classe
    public sealed class PizzaFactory
    {
        public static IPizza CriarPizza(string tipoPizza)
        {
            IPizza pizza = null;

            switch (tipoPizza)
            {
                case "C":
                    pizza = new PizzaCalabreza();
                    break;
                case "D":
                    pizza = new PizzaFrango();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
