using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Общий интерфейс наблюдателя
    /// </summary>
    interface IObserver
    {
        void Update(Object o);
    }
}
