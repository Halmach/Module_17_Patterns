using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class OrcFactory : IMonsterFactory
    {
        public IMovement CreateMovement()
        {
            return new RunMovement();
        }

        public IWeapon CreateWeapon()
        {
            return new Axe();
        }
    }
}
