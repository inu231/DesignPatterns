using System;

namespace FactoryMethod
{
    public class PizzaCalabrezaSP : Pizza, IPizza
    {
        public PizzaCalabrezaSP()
        {
            Name = "Calabreza SP";
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando a pizza SUCULENTA de {Name}!");
        }
    }
}
