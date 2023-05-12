using Facade.Subsistemas;
using System;

namespace Facade.Facade
{
    public class ConcessaoCreditoFacade
    {
        private LimiteCredito _limite;
        private Serasa _serasa;
        private Cadin _cadin;
        private Cadastro _cadastro;

        public ConcessaoCreditoFacade()
        {
            _limite = new LimiteCredito();
            _serasa = new Serasa();
            _cadin = new Cadin();
            _cadastro = new Cadastro();
        }

        public bool ConcederEmprestimo(Cliente cliente, double valor)
        {
            Console.WriteLine($"Cliente deseja empresimo no valor de {valor}");
            _cadastro.CadastrarCliente(cliente);

            bool concederEmprestimo = true;

            if(_serasa.EstaNoSerasa(cliente))
            {
                Console.WriteLine("Cliente está no SERASA. Consessão negada");
                concederEmprestimo = false;
            }
            else if (_cadin.EstaNoCadin(cliente))
            {
                Console.WriteLine("Cliente está no CADIN. Consessão negada");
                concederEmprestimo =  false;
            }
            else if(!_limite.PossuiLimite(cliente, valor))
            {
                Console.WriteLine("Cliente não possui limite. Consessão negada");
                concederEmprestimo =  false;
            }

            return concederEmprestimo;
        }
    }
}
