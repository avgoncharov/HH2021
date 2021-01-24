using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMessageBroker
{
    public interface ISubscriber
    {
        string Name { get; set; }


        void Send(IMessage message);
    }
}
