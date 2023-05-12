using Command.ConcreteCommand;

namespace Command.Invoker
{
    public class Garcom 
    {
        private readonly Pedido _pedido;

        public Garcom(Pedido pedido)
        {
            _pedido = pedido;
        }

        public void Executar()
        {
            _pedido.Execute();
        }
    }
}
