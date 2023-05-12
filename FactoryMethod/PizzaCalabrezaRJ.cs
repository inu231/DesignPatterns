using System;

namespace FactoryMethod
{
    public class PizzaCalabrezaRJ : Pizza, IPizza
    {
        public PizzaCalabrezaRJ()
        {
            Name = "Calabreza RJ";
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando a pizza SUCULENTA de {Name}!");
        }
    }
}
