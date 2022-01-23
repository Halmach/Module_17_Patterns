using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class SmsMessage:Message
    {
        public SmsMessage()
        {
            Console.WriteLine("SMS отправлено");
        }
    }
}
