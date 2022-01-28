using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class PdfExport : IExport
    {
        public void Export(string Text)
        {
            Console.WriteLine("Экспортируем текст в PDF");
            Console.WriteLine(Text);
        }
    }
}
