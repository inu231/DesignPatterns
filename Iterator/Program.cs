using Iterator.ConcreteAggregate;
using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Cria coleção
            ConcreteCollection collection = new ConcreteCollection();

            // adicionaos elementos na colecao
            collection.AddCliente(new Cliente(1, "Felipe"));
            collection.AddCliente(new Cliente(2, "Maria"));
            collection.AddCliente(new Cliente(3, "José"));
            collection.AddCliente(new Cliente(4, "Mostafá"));

            // Criamos o iterator que vai encapsular a interação
            ConcreteIterator.Iterator iterator = collection.CreateInterator();

            Console.WriteLine("Usando o padrão Iterator ### \n");
            Console.WriteLine("Pressione algo para iniciar");
            Console.ReadKey();

            Console.WriteLine("Iterando sobre a coleção de clientes");

            for(Cliente cliente = iterator.First(); !iterator.IsDone; cliente = iterator.Next())
            {
                Console.WriteLine($"Iterando com o padrão Iterator - ID: {cliente.Id} | Nome: {cliente.Nome}");
            }

            Console.Read();
        }
    }
}
