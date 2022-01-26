using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Реализация брокера в качестве наблюдателя
    /// </summary>
    class Broker : IObserver
    {
        IObservable stock;
        public Broker(IObservable stock)
        {
            this.stock = stock;
            this.stock.RegisterObserver(this);
        }

        public void Update(object o)
        {
            StockData sData = (StockData)o;

            if (sData.USD > 85)
                Console.WriteLine($"Брокер продает доллары по курсу {sData.USD}");
            else
                Console.WriteLine($"Брокер покупает доллары по курсу {sData.USD}");
        }

        public void StopTrade()
        {
            this.stock.RemoveObserver(this);
        }
    }
}
