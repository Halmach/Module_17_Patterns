﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class FireBreath : IWeapon
    {
        public void Attack()
        {
            Console.WriteLine("Дышим огнем");
        }
    }
}
