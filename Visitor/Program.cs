using System;
using System.Collections.Generic;
using Visitor.Elements;
using Visitor.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            var carros = new List<Carro>();
            carros.Add(new Carro("Ferrari", "NX0", 10000m));
            carros.Add(new Carro("Lamborguini", "LX0", 3500m));
            carros.Add(new Carro("Gol", "CPM", 1000m));

            var lojas = new List<ILoja>();

            Console.WriteLine("Preços normais dos carros");

            foreach (var carro in carros)
            {
                Console.WriteLine($"Precos normais: Nome: {carro.Nome} | Modelo: {carro.Modelo} | Valor: {carro.Preco}");
                lojas.Add(carro);
            }

            Console.WriteLine("Presssione qualquer tecla para continuar");
            Console.Read();


            Console.WriteLine($"Novos preços com desconto:");
            var precoVisitor = new PrecoVisitor();

            foreach (var item in lojas)
            {
                item.Visit(precoVisitor);
            }
        }
    }
}
