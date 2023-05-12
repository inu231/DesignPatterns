using System;

namespace Facade.Subsistemas
{
    public class Cadastro
    {
        public void CadastrarCliente(Cliente cliente)
        {
            Console.WriteLine($"Cliente {cliente.Nome} cadastrado com sucesso!");
        }
    }
}
