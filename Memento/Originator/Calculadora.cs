using Memento.Mementos;
using System;

namespace Memento.Originator
{
    public class Calculadora : ICalculadora
    {
        private int primeiroNumero;
        private int segundoNumero;

        /// <summary>
        /// Aqui, criamos o memento, que armazenarrá o backup do estado do objeto
        /// </summary>
        /// <returns></returns>
        public ICaretaker BackupUltimoCalculo()
        {
            return new Mementos.Memento(primeiroNumero, segundoNumero);
        }

        public void RestaurarUltimoCalculo(ICaretaker memento)
        {
            primeiroNumero = ((IMementoOriginator)memento).GetPrimeiroNumero();
            segundoNumero = ((IMementoOriginator)memento).GetSegundoNumero();
        }

        public int GetCalculoResultado()
        {
            return primeiroNumero + segundoNumero;
        }

        public void SetPrimeiroNumero(int n)
        {
            primeiroNumero = n;
        }

        public void SetSegundoNumero(int n)
        {
            segundoNumero = n;
        }
    }
}
