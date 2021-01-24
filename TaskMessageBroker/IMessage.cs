using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMessageBroker
{
    public interface IMessage
    {
        string MessageBody { get; set; }

    }
}
