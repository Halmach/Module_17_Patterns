using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    public abstract class Flight
    {
        public string Name;
        public List<string> PassengerList;
        
        public Flight(string name, List<string> passengers = null)
        {
            Name = name;
            PassengerList = passengers ?? new List<string>();
        }

        // Подсчет количества пассажиров
        public void CountPassengers()
        {
            Console.WriteLine($"На рейсе {Name} {PassengerList.Count} пассажиров");
        }
    }
}
