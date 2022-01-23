using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Класс для работы с принтером
    /// </summary>
    class PaperPrinter: IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Печатаем на бумаге");
        }
    }
}
