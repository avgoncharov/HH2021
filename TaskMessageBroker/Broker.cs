using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMessageBroker
{
    public class Broker
    {
        private List<ISubscriber> subscribers;


        public Broker()
        {
            subscribers = new List<ISubscriber>();
        }


        public void Post(IMessage message)
        { 
            foreach (var subscriber in subscribers)
            {
                subscriber.Send(message);
            }
        }


        public void Subscribe(ISubscriber subscriber)
        {
            subscribers.Add(subscriber);
        }


        public void Unsubscribe(ISubscriber subscriber)
        {
            subscribers.Remove(subscriber);
        }

    }
}
