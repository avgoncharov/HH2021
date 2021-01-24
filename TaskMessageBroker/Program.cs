using System;

namespace TaskMessageBroker
{
    class Program
    {
        static void Main(string[] args)
        {
            Broker broker = new Broker();
            Message message = new Message("Hello world!");
            Subscriber sub1 = new Subscriber("Admin");
            Subscriber sub2 = new Subscriber("root");
            Subscriber sub3 = new Subscriber("User");

            broker.Subscribe(sub1);
            broker.Subscribe(sub2);
            broker.Subscribe(sub3);

            broker.Post(message);


            broker.Unsubscribe(sub2);

            broker.Post(new Message("Hello world without root subscriber!"));
        }
    }
}
