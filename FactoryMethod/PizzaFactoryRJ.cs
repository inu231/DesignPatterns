namespace FactoryMethod
{
    class PizzaFactoryRJ : PizzaFactoryMethod
    {
        protected override IPizza CriarPizza(string tipoPizza)
        {
            IPizza pizza = null;

            switch (tipoPizza)
            {
                case "C":
                    pizza = new PizzaCalabrezaRJ();
                    break;
                case "D":
                    pizza = new PizzaFrangoRJ();
                    break;
                default:
                    break;
            }

            return pizza;
        }
    }
}
