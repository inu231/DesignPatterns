using Visitor.Visitors;

namespace Visitor.Elements
{
    public class Carro : ILoja
    {
        public Carro(string nome, string modelo, decimal preco)
        {
            Nome = nome;
            Modelo = modelo;
            Preco = preco;
        }

        public string Nome { get; set; }
        public string Modelo { get; set; }
        public decimal Preco { get; set; }

        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
