namespace ModelProject
{
    public class Company
    {
        public Company()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime FoundationDate { get; set; }

    }
}
