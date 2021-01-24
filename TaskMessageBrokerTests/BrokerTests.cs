using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TaskMessageBroker.Tests
{
    [TestClass]
    public class BrokerTests
    {
        [TestMethod]
        public void BrokerTest()
        {
            Broker broker = new Broker();
            Subscriber subscriber = new Subscriber("name");
            Message message = new Message("msg");

            broker.Subscribe(subscriber);
            broker.Post(message);

            Assert.AreEqual(message.MessageBody, subscriber.SendedMessage);
        }
    }
}
