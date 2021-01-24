using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMessageBroker
{
    public class Subscriber : ISubscriber
    {
        public string Name { get ; set; }
        public string SendedMessage;


        public Subscriber(string name)
        {
            Name = name;
        }


        public void Send(IMessage message)
        {
            SendedMessage = message.MessageBody;
            Console.WriteLine(String.Format("Подписчик: {0}, получил сообщение: {1}",Name, message.MessageBody));
        }
    }
}
