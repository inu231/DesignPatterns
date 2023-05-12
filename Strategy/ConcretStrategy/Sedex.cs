using Strategy.Strategy;
namespace Strategy.ConcretStrategy
{
    public class Sedex : IFrete
    {
        public double CalcularFrete()
        {
            return 20;
        }
     }
}
