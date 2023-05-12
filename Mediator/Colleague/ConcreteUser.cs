using Mediator.Mediators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator.Colleague
{
    /// <summary>
    /// Concrete Colleague
    /// </summary>
    public class ConcreteUser : User
    {
        public ConcreteUser(string name, IFacebookGroupMediator mediator) : base(name, mediator)
        {
        }

        public override void Receive(string msg)
        {
            Console.WriteLine($"Mensagem recebida pelo usuário {Name} => {msg}");
        }

        public override void Send(string msg)
        {
            Console.WriteLine($"Mensagem enviada pelo usuário {Name} => {msg} \n");
            mediator.SendMessage(msg, this);
        }
    }
}
