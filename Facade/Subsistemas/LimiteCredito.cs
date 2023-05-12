using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade.Subsistemas
{
    public class LimiteCredito
    {
        public bool PossuiLimite(Cliente cliente, double valor)
        {
            Console.WriteLine($"Verificando limite de crédito do cliente {cliente.Nome}");
            return valor < 20000;
        }
    }
}
