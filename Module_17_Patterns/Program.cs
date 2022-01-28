using System;
using System.Collections.Generic;

namespace Module_17_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowDependencyInversionPrinciple();
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

        static void ShowLiskovSubstitutionPrinciple()
        {
            // Новый список полётов
            var flightsList = new List<Flight>()
            {
                new DomesticFlight("Mow-32", new List<string>() {"Вася", "Петя"}),
                new DomesticFlight("SPB-14", new List<string>() {"Андрей"})
            };

            // Считаем пассажиров
            FlightPassengerCount(flightsList);
        }

        public static void FlightPassengerCount(List<Flight> flights)
        {
            foreach (var flight in flights)
                flight.CountPassengers();
        }

        static void ShowInterfaceSegregationPrinciple()
        {
            // наш водитель
            var driver = new Driver();

            // водителю всё равно, на чём ехать
            Console.WriteLine("Садимся в седан");
            driver.Drive(new Sedane());

            Console.WriteLine();

            Console.WriteLine("Садимся в джип");
            driver.Drive(new Suv());
        }

        static void ShowDependencyInversionPrinciple()
        {
            //  выводим на монитор
            var connectedMonitor = new VideoAdapter(new Monitor());
            connectedMonitor.Display();

            //  выводим на телевизор
            var connectedTv = new VideoAdapter(new Tv());
            connectedTv.Display();
        }
    }
}
