using Proxy.Subject;
using System;

namespace Proxy.RealSubject
{
    public class PastaCompartilhada : IPastaCompartilhada
    {
        public void OperacaoLeituraGravacao()
        {
            Console.WriteLine("Operação de leitura e escrita na pasta ###");
        }
    }
}
