using Strategy.Strategy;
using System;

namespace Strategy.ConcretStrategy
{
    public class Jadlog : IFrete
    {
        public double CalcularFrete()
        {
            return 15;
        }
    }
}
