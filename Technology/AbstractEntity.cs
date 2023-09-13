namespace Technology
{
    public abstract class AbstractEntity
    {
        public int Id {  get; set; }
        private static int nextId = 1;
        public AbstractEntity() 
        {
            Id = nextId;
            nextId++;
        }
    }
}
