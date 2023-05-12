using System;

namespace FactoryMethod
{
    public abstract class Pizza : IPizza
    {
        public string Name { get; set; }

        public virtual void Preparar()
        {
            Console.WriteLine($"Preparando a pizza {Name}!");
        }

        public virtual void Assar()
        {
            Console.WriteLine($"Assando a pizza {Name}!");
        }

        public virtual void Finalizar()
        {
            Console.WriteLine($"Finalizando a pizza {Name}!");
        }
    }
}
