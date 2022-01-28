using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// У нас премиум-седан, поэтому кроме обычных систем подключаем системы комфорта
    /// </summary>
    class Sedane : IGeneralPack, IPremiumPack
    {
        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }

        public void Drive()
        {
            Console.WriteLine("Едем");
        }
    }
}
