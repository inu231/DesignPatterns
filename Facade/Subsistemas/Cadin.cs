using System;

namespace Facade.Subsistemas
{
    public class Cadin
    {
        public bool EstaNoCadin(Cliente cliente)
        {
            Console.WriteLine($"Verificando se o clinte {cliente.Nome} está no CADIN");
            return false;
        }
    }
}
