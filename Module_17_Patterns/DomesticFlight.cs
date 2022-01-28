using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class DomesticFlight : Flight
    {
        public DomesticFlight(string name, List<string> passengers = null) : base(name, passengers)
        {
        }
    }
}
