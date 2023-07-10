namespace ModelProject
{
    public class Company
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public void Construction()
        {
            Id = Guid.NewGuid();
        }
    }
}
