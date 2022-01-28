using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class Document
    {
        public string Text { get; set; }

        public void ScrollUp()
        {
            Console.WriteLine($"Прокрутка вверх");
        }

        public void ScrollDown()
        {
            Console.WriteLine($"Прокрутка вниз");
        }

        public void ZoomIn()
        {
            Console.WriteLine("Увелчиваем масштаб");
        }

        public void Export(IExport exporter)
        {
            exporter.Export(Text);

        }
    }
}
