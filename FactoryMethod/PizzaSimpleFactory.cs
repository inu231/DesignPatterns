namespace FactoryMethod
{
    public abstract class PizzaSimpleFactory
    {
        public static PizzaFactoryMethod CriarPizzaria(string tipo)
        {
            PizzaFactoryMethod pizzaFactory = null;

            switch (tipo)
            {
                case "RJ":
                    pizzaFactory = new PizzaFactoryRJ();
                    break;
                case "SP":
                    pizzaFactory = new PizzaFactorySP();                       
                    break;
                default:
                    break;
            }

            return pizzaFactory;
        }
    }
}
