using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class Stock : IObservable
    {
        StockData _sData;
        List<IObserver> observers;

        public Stock()
        {
            _sData = new StockData();
            observers = new List<IObserver>();
        }

        public void NotifyObservers()
        {
            foreach(IObserver observer in observers)
            {
                observer.Update(_sData);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            observers.Remove(o);
        }

        public void Market()
        {
            _sData.Euro = new Random().Next(80, 100);
            _sData.USD = new Random().Next(70, 90);

            NotifyObservers();
        }
    }
}
