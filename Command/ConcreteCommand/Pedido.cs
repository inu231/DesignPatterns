using Command.Command;
using Command.Receiver;

namespace Command.ConcreteCommand
{
    public class Pedido : Comando
    {
        private readonly Chef _chef;
        private readonly string _acao;

        public Pedido(Chef chef, string acao)
        {
            _chef = chef;
            _acao = acao;
        }

        public override void Execute()
        {
            if (_acao == "Prato")
            {
                _chef.PrepararAlmoco();
            }
            else
            {
                _chef.PrepararSobremesa();
            }
        }
    }
}
