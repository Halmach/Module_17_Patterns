using System;
using System.Collections.Generic;
using System.Text;

namespace Module_17_Patterns
{
    /// <summary>
    /// Интерфейс состояния лифта
    /// </summary>
    interface IElevatorState
    {
        void Up(Elevator elevator);
        void Down(Elevator elevator);
    }
}
