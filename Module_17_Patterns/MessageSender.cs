using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    abstract class MessageSender
    {
        public string From { get; set; }
        public MessageSender (string @from)
        {
            From = @from;
        }

        // Фабричный метод
        abstract public Message Send(string text);
    }
}
