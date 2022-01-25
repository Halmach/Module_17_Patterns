using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Реализация подземного состояния (лифт в подвале)
    /// </summary>
    class LowerElevatorState : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся еще ниже");
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимемся на первый этаж");
            elevator.ElevatorState = new GroundElevatorState();
        }
    }
}
