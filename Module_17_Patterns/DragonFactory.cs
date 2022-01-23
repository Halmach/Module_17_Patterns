using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class DragonFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new FlyMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new FireBreath();
        }
    }
}
