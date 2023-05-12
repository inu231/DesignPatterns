using System;

namespace SimpleFactory
{
    public class Pizzaria
    {
        public static void OrdernarPizza()
        {
            Console.WriteLine("Escolha o pazzar da pizza (C) ou (D)");
            var tipoPizza = Console.ReadLine();

            var pizza = PizzaFactory.CriarPizza(tipoPizza);

            if(pizza != null)
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
