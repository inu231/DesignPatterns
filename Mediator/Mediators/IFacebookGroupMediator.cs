using Mediator.Colleague;

namespace Mediator.Mediators
{
    public interface IFacebookGroupMediator
    {
        void SendMessage(string msg, User user);
        void RegisterUser(User user);
    }
}
