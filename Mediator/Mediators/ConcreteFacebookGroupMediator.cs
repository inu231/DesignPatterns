using Mediator.Colleague;
using System.Collections.Generic;

namespace Mediator.Mediators
{
    public class ConcreteFacebookGroupMediator : IFacebookGroupMediator
    {
        private List<User> userList = new List<User>();

        public void RegisterUser(User user)
        {
            userList.Add(user);
        }

        public void SendMessage(string msg, User user)
        {
            foreach (var item in userList)
            {
                if(item != user)
                {
                    item.Receive(msg);
                }
            }
        }
    }
}
