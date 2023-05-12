using Strategy.Strategy;

namespace Strategy.FreteService
{
    public class FreteContext
    {
        private IFrete _frete;

        public FreteContext(IFrete frete)
        {
            DefineStrategy(frete);
        }

        public void DefineStrategy(IFrete frete)
        {
            _frete = frete;
        }

        public double CalcularValorFrete()
        {
            return _frete.CalcularFrete();
        }
    }
}
