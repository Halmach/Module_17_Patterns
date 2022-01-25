using System;

namespace Module_17_Patterns
{
    /// <summary>
    /// Реализация наземного состояния (лифт на первом этаже)
    /// </summary>
    class GroundElevatorState : IElevatorState
    {
        public void Down(Elevator elevator)
        {
            Console.WriteLine("Опускаемся в подвал");
            elevator.ElevatorState = new LowerElevatorState();
        }

        public void Up(Elevator elevator)
        {
            Console.WriteLine("Поднимаемся на верхний этаж");
            elevator.ElevatorState = new UpperElevatorState();
        }
    }
}