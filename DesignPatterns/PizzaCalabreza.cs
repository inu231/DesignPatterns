using System;

namespace SimpleFactory
{
    public class PizzaCalabreza : Pizza, IPizza
    {
        public PizzaCalabreza()
        {
            Name = "Calabreza";
        }

        public override void Preparar()
        {
            Console.WriteLine($"Preparando a pizza SUCULENTA de {Name}!");
        }
    }
}
