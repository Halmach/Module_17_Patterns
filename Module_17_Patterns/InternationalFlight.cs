using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    public class InternationalFlight : Flight
    {
        public InternationalFlight(string name, List<string> passengers = null) : base(name, passengers)
        {
        }
    }
}
