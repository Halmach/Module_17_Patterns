using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Обработчик голосовых уведомлений
    /// </summary>
    class VoiceNotificationHandler : NotificationHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.VoiceNotification == true) Console.WriteLine("Голосовое уведомление выполнено");
            else if (Successor != null) Successor.Handle(receiver);
        }
    }
}
