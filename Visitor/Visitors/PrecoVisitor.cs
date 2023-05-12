using System;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class PrecoVisitor : IVisitor
    {
        private readonly int DESCONTO = 15; // %

        public void Accept(Carro carro)
        {
            Console.WriteLine($"Marca: {carro.Nome} Modelo: {carro.Modelo} Carro com desconto: {carro.Preco - (carro.Preco * DESCONTO / 100)}");
        }
    }
}
