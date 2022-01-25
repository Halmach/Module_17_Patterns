using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{   
    /// <summary>
    /// Абстрактный класс для всех обработчиков событий
    /// </summary>
    abstract class NotificationHandler
    {
        public NotificationHandler Successor { get; set; }
        public abstract void Handle(Receiver receiver);
    }
}
