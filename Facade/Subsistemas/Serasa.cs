using System;

namespace Facade.Subsistemas
{
    public class Serasa
    {
        public bool EstaNoSerasa(Cliente cliente)
        {
            Console.WriteLine($"Verificando se o clinte {cliente.Nome} está no serasa");
            return false;
        }
    }
}
