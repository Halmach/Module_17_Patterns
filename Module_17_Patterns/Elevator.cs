namespace Module_17_Patterns
{
    internal class Elevator
    {
        public Elevator(IElevatorState elevatorState)
        {
            this.ElevatorState = elevatorState;
        }

        public IElevatorState ElevatorState { get; set; }

        public void Up()
        {
            ElevatorState.Up(this);
        }

        public void Down()
        {
            ElevatorState.Down(this);
        }

    }
}