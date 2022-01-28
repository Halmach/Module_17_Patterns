using System;

namespace Module_17_Patterns
{
    public class Monitor :IHdmiInterface
    {
        public void Display(string text)
        {
            Console.WriteLine("Вывод на монитор");
        }
    }
}