using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class Axe : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Бъем топором");
        }
    }
}
