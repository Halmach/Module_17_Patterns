using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class EmailMessageSender : MessageSender
    {
        /// <summary>
        /// Класс для рассылки e-mail
        /// </summary>
        /// <param name="from"></param>
        public EmailMessageSender(string @from) : base(@from)
        {
        }

        public override Message Send(string text)
        {
            return new EmailMessage();
        }
    }
}
