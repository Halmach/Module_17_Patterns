using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Интерфейс наблюдаемого объекта(источника информации, на который подписаны наблюдатели)
    /// </summary>
    interface IObservable
    {
        // добавить наблюдателя
        void RegisterObserver(IObserver o);

        // удалить наблюдателя
        void RemoveObserver(IObserver o);

        // уведомить наблюдателей
        void NotifyObservers();
    }
}
