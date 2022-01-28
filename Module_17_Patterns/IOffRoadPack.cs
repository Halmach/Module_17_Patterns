using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    ///  Интерфейс подключения офф-роуд систем для внедорожников
    /// </summary>
    public interface IOffRoadPack
    {
        void DriveDown();
        void LockDifferential();
        void DescentAssist();
    }
}
