using System;

namespace Module_17_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowSingleResponsibility();
        }

        static void ShowSingleResponsibility()
        {
            PdfExport exporter = new PdfExport();
            Document doc = new Document();
            doc.Export(exporter);
        }
    }
}
