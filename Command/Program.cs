using Command.ConcreteCommand;
using Command.Invoker;
using Command.Receiver;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria uma instance de chef para preparar o pedido
            // Receiver
            Chef chef = new Chef();

            // concret Command
            Pedido pedido = new Pedido(chef, "Prato");

            //invoker
            Garcom garcom = new Garcom(pedido);
            garcom.Executar();


            // concret Command
            pedido = new Pedido(chef, "Sobremesa");

            //invoker
            garcom = new Garcom(pedido);
            garcom.Executar();
        }
    }
}
