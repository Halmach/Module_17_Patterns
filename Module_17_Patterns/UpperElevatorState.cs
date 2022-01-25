using System;

namespace Module_17_Patterns
{
    /// <summary>
    /// Реализация надземного состояния (лифт на верхних этажах)
    /// </summary>
    internal class UpperElevatorState : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся на первый этаж");
            elevator.ElevatorState = new GroundElevatorState();
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся еще выше");
        }
    }
}