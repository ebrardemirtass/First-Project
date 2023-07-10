namespace ModelProject
{
    public class Company
    {
        public void Construction()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }

    }
}
