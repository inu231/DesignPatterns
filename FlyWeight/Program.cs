using FlyWeight.Factory;
using FlyWeight.Model;

namespace FlyWeight
{
    class Program
    {
        /// <summary>
        /// Flyweigh = peso de mosca
        /// O objetivo deste padrão é criar objetos com um custo mínimo possível de memória. A ideia
        /// é compartilhar o estado intrínseco de um objeto sempre que for necessário utilziar aquele objeto, evitando a criação de um novo objeto.
        /// No nosso exemplo, compartilharemos a propriedade de um círculo. A forma é intrínseca ao círculo, pois todos são redondos. 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Desenha circulos amarelos
            for (int i = 0; i < 5; i++)
            {
                var c1 = FormaFactory.GetForm("circulo") as Circle;
                c1.SetColor("Amarelo");
                c1.Draw();
            }
            // Desenha circulos azuis
            for (int i = 0; i < 5; i++)
            {
                var c1 = FormaFactory.GetForm("circulo") as Circle;
                c1.SetColor("Azul");
                c1.Draw();
            }


        }
    }
}
