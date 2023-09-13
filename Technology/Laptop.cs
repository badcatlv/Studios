namespace Technology
{
    public class Laptop : Computer
    {
        public double Weight { get; set; }
        public Laptop(double ram, double storage, bool fullyCharge, double weight) : base(ram, storage, fullyCharge)
        {
            Weight = weight;
        }

        public bool IsHeavy()
        {
            if (Weight > 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
