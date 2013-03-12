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
        }

        public void ShifGear()
        {
        }

        public void Start()
        {
            state = "Started";
        }
    }
}