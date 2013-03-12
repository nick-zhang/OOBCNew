namespace Session4
{
    public class Car
    {
        private string state;

        public Car(string state)
        {
            this.state = state;
        }

        public Car()
        {
            state = "Flameout";
        }

        public string Display()
        {
            return state;
        }

        public void StepOnGas()
        {
            if (state.Equals("Started"))
                state = "Idle";
        }

        public void ShiftGear()
        {
            if (state.Equals("Started"))
                state = "GearShifted";
        }

        public void Start()
        {
            state = "Started";
        }
    }
}