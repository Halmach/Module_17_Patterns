using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    class BoardComputer
    {
        public void GroundLanding()
        {
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Выпускаем шасси");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--Посадка--");
            Console.WriteLine("Выпускаем тормозной парашют");
        }

        internal void PerformLanding(ILandingProfile groundLandingProfile)
        {
            groundLandingProfile.Execute();
        }
    }
}
