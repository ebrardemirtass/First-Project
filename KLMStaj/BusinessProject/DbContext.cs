using ModelProject;
using System.Data.Entity;

namespace BusinessProject
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext() : base("Data Source=localhost;Initial Catalog=KLMStajDB;Integrated Security=True")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CompanyDbContext>());
        }
        public DbSet<Company> Companies { get; set; }
    }
}
