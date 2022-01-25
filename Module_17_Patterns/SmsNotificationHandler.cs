using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Обработчик sms-уведомлений
    /// </summary>
    class SmsNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.SmsNotification == true) Console.WriteLine("Уведомление по sms выполнено");
            else if (Successor != null) Successor.Handle(receiver);
        }
    }
}
