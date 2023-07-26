using ModelProject;
using UtilityProject;

namespace BusinessProject
{
    public class CompanyManager
    {
        public Company CreateCompany(string name)
        {
            using (var dbContext = new CompanyDbContext())
            {
                Company company = new Company();
                DateTimeHelper dateTimeHelper = new DateTimeHelper();
                company.Name = name;
                company.FoundationDate = dateTimeHelper.GenerateRandomDate();

                // Şirket nesnesini veritabanına kaydetme işlemi
                dbContext.Companies.Add(company);
                dbContext.SaveChanges();

                return company;
            }
        }

    }
}