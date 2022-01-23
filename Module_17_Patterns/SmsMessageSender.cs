using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class SmsMessageSender : MessageSender
    {
        public SmsMessageSender(string @from) : base(@from)
        {
        }

        public override Message Send(string text)
        {
            return new SmsMessage();
        }
    }
}
