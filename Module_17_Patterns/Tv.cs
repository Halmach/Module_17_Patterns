using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class Tv : IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на телевизор");
        }
    }
}
