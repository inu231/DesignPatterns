namespace Memento.Mementos
{
    public class Memento : ICaretaker, IMementoOriginator
    {
        private readonly int primeiroNumero;
        private readonly int segundoNumero;

        public Memento(int primeiroNumero, int segundoNumero)
        {
            this.primeiroNumero = primeiroNumero;
            this.segundoNumero = segundoNumero;
        }

        public int GetPrimeiroNumero()
        {
            return primeiroNumero;
        }

        public int GetSegundoNumero()
        {
            return segundoNumero;
        }
    }
}
