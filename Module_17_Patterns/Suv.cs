using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    ///  Премиум - внедорожник
    /// </summary>
    public class Suv : IGeneralPack, IPremiumPack, IOffRoadPack, ISportPack
    {
        public void CruiseControl()
        {
            Console.WriteLine("Включаем круиз-контроль");
        }

        public void DescentAssist()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }

        public void Drive()
        {
            Console.WriteLine("Едем");
        }

        public void DriveDown()
        {
            Console.WriteLine("Включаем систему помощи при спуске");
        }

        public void FourWheelDrive()
        {
            Console.WriteLine("Включаем полный привод");
        }

        public void LockDifferential()
        {
            Console.WriteLine("Включаем блокировку центрального дифференциала");
        }
    }
}
