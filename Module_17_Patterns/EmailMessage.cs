using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("e-mail отправлен");
        }
    }
}
