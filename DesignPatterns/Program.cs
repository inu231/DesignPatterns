using SimpleFactory;

namespace DesignPatterns
{
    class Program
    {
        /// <summary>
        /// O padrão simple factory é utilizado quando a lógica de criação dos objetos não é tão complexa assim
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Pizzaria.OrdernarPizza();
        }
    }
}
