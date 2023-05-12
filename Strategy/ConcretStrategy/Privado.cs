using Strategy.Strategy;
using System;

namespace Strategy.ConcretStrategy
{
    public class Privado : IFrete
    {
        public double CalcularFrete()
        {
            return 10.00;
        }
    }
}
