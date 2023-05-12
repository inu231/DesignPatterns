using FlyWeight.Contract;
using System;

namespace FlyWeight.Model
{
    public class Circle : IForma
    {
        public int Radius = 35;
        public int XAxis = 10;
        public int YAxis = 25;

        public string Color { get; set; }

        public void Draw()
        {
            Console.WriteLine($@"Cícrulo de cor {Color}, Raio: {Radius}");
        }

        public void SetColor(string color)
        {
            Color = color;
        }
    }
}
