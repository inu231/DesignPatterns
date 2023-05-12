using System;

namespace FactoryMethod
{
    class Program
    {
        /// <summary>
        /// O Factory method é utilizado quando possuímos 2 ou mais especificidades de um mesmo produto e fábrica.
        /// NEste exemplo, temos a fábrica de pizza SP e a fábrica de pizza de RJ. As pizzas podem ser do mesmos sabor, mas os ingredientes são diferentes.
        /// Este cenário é ideal para o factory method.
        /// Temos o Product , que no caso é a pizza ( Classe abstrata ou interface)
        /// Temos o ConcretProduct, que é uma implementação da abstração da pizza ( Exemplo: PissaCalabresaRJ)
        /// Temos o Creator, que é a fábrica ( Classe PizzaFactoryMethod), representando a fábrica genérica, a abstração da fábrica, que possui um método abstrato que será socrescrito 
        ///     por cada implementação dó creator ou fábrica
        /// Temos o ConcreteCreateor, que é a implementação da fábrica, que sobrescreve o método abastrato do creator, onde cada concreteCreator tem sua implementação diferente
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha o local (RJ) ou (SP)");
            var local = Console.ReadLine();

            PizzaFactoryMethod pizzaFactory = PizzaSimpleFactory.CriarPizzaria(local);

            Console.WriteLine("Escolha o pazzar da pizza (C) ou (D)");
            var tipoPizza = Console.ReadLine();

            var pizza = pizzaFactory.MontarPizza(tipoPizza);

            if (pizza != null)
            {
                pizza.Preparar();
                pizza.Assar();
                pizza.Finalizar();
            }
            else
            {
                Console.WriteLine("Sabor não localizado!");
            }

            Console.ReadKey();
        }
    }
}
