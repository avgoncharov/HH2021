using System;
using System.Collections.Generic;
using System.Text;

namespace TaskMessageBroker
{
    public class Message : IMessage
    {
        public string MessageBody {get; set; }

        public Message(string message)
        {
            MessageBody = message;
        }
    }
}
