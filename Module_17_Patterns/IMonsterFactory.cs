using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    interface IMonsterFactory
    {
        IMovement CreateMovement();
        IWeapon CreateWeapon();
    }
}
