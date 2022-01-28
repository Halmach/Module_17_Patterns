using System;

namespace Module_17_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowOpenClosePrinciple();
        }

        static void ShowSingleResponsibility()
        {
            PdfExport exporter = new PdfExport();
            Document doc = new Document();
            doc.Export(exporter);
        }
        
        static void ShowOpenClosePrinciple()
        {
            var boardComputer = new BoardComputer();

            // посадка на землю
            boardComputer.PerformLanding(new GroundLandingProfile());

            Console.WriteLine();

            // посадка на воду
            boardComputer.PerformLanding(new WaterLandingProfile());
        }
    }
}
