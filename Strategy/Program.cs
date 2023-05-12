using Strategy.ConcretStrategy;
using Strategy.FreteService;
using System;

namespace Strategy
{
    class Program
    {
        /// <summary>
        /// O método stratagy é definido por 3 conceitos:
        /// 1 - Strategy: A abustração, nesse caso o IFrete
        /// 2 - Concrete Strategy: A implementação da abstração/contrato IFrete, todos que o implementam
        /// 3 - Context: É a classe que vai receber um tipo IFrete e chamar seu método Calcular frete
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var context = new FreteContext(new Sedex());

            Console.WriteLine($"O valor do frete é: {context.CalcularValorFrete()}");

            context.DefineStrategy(new Jadlog());

            Console.WriteLine($"O valor do frete é: {context.CalcularValorFrete()}");
        }
    }
}
