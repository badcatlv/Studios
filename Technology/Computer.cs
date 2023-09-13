namespace Technology
{
    public class Computer : AbstractEntity
    {
        public double Ram { get; set; }
        public double Storage { get; set; }
        public bool FullyCharged { get; set; } = false;


        public Computer(double ram, double storage, bool fullyCharged)
        {
            Ram = ram;
            Storage = storage;
            FullyCharged = fullyCharged;
        }

        public void IncreaseRam(double ram)
        {
            Ram += ram;
        }

        public void IncreaseStorage(double storage)
        {
            Storage += storage;
        }

        public void IncreaseToFullyCharged()
        {
            FullyCharged = true;
        }
    }
}
