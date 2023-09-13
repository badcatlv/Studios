namespace Technology
{
    public class SmartPhone : Computer
    {
        public bool LocationOn { get; set; } = true;
        public SmartPhone(double ram, double storage, bool fullyCharged, bool locationOn) : base(ram, storage, fullyCharged)
        {
            LocationOn = locationOn;
        }

        public void TurnOffLocation()
        {
            LocationOn = false;
        }
    }
}
