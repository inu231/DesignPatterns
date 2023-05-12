using Mediator.Colleague;
using Mediator.Mediators;
using System;

namespace Mediator
{
    class Program
    {
        /*
         * Neste exemplo, usamos o padrão mediator para definir troca de mensagens em um grupo de facebook. 
         * E esta troca de mensagens será feita através de um mediador, que é o IFacebookGroupMediator. 
         * Checar as demais explicaçãos na pasta docs
         */

        static void Main(string[] args)
        {
            IFacebookGroupMediator mediator = new ConcreteFacebookGroupMediator();

            User Felipe = new ConcreteUser("Felipe", mediator);
            User Ana = new ConcreteUser("Ana", mediator);
            User Rafael = new ConcreteUser("Rafael", mediator);
            User Luciano = new ConcreteUser("Luciano", mediator);
            User Carol = new ConcreteUser("Carol", mediator);
            User Bernadete = new ConcreteUser("Bernadete", mediator);

            mediator.RegisterUser(Felipe);
            mediator.RegisterUser(Ana);
            mediator.RegisterUser(Rafael);
            mediator.RegisterUser(Luciano);
            mediator.RegisterUser(Carol);
            mediator.RegisterUser(Bernadete);

            // Todos receberão a mensagem do felipe
            Felipe.Send("Eai, pessoal, tá tudo certo?");

            Console.WriteLine("\n");

            // E todos receberão a msg da ana
            Ana.Send("Bom dia à todos!");

            Console.Read();
        }
    }
}
