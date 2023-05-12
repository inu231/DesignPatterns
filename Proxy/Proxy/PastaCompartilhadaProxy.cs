using Proxy.RealSubject;
using Proxy.Subject;
using System;

namespace Proxy.Proxy
{
    public class PastaCompartilhadaProxy : IPastaCompartilhada
    {
        private IPastaCompartilhada _pastaCompartilhada;
        private Funcionario _func;

        public PastaCompartilhadaProxy(Funcionario func)
        {
            _func = func;
        }

        public void OperacaoLeituraGravacao()
        {
            _pastaCompartilhada = new PastaCompartilhada();

            if(_func.Perfil.Equals("CEO"))
            {
                Console.WriteLine($"Permissão de leitura e gravação será concedida para o usuário {_func.Nome}");
                _pastaCompartilhada.OperacaoLeituraGravacao();
            }
            else
            {
                Console.WriteLine($"Permissão de leitura e gravação negada para o usuário {_func.Nome}");
            }
        }
    }
}
