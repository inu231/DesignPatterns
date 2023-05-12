using Mediator.Mediators;

namespace Mediator.Colleague
{
    public abstract class User
    {
        public string Name { get; set; }
        protected IFacebookGroupMediator mediator;

        protected User(string name, IFacebookGroupMediator mediator)
        {
            Name = name;
            this.mediator = mediator;
        }

        public abstract void Send(string msg);
        public abstract void Receive(string msg);
    }
}
