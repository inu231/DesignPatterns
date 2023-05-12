using System;

namespace Observer.Observers
{
    public class ConcreteObserver : IObserver
    {
        public string Usuario { get; set; }

        public void Atualizar(string disponibilidade)
        {
            Console.WriteLine($"");
        }
    }
}
