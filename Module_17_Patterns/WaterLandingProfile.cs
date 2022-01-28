using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    public class WaterLandingProfile : ILandingProfile
    {
        public void Execute()
        {
            Console.WriteLine(">> Загружен профиль: ПОСАДКА НА ВОДУ <<");

            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Опускаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("Поднимаем руль высоты");
            Console.WriteLine("Сбрасываем скорость");
            Console.WriteLine("--ПОСАДКА--");
        }
    }
}
