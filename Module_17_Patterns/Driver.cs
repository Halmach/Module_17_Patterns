using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    public class Driver
    {
        public void Drive(IGeneralPack car)
        {
            car.Drive();
        }
    }
}
