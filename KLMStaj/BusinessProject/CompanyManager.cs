using ModelProject;

namespace BusinessProject
{
    public class CompanyManager
    {
        public Company CreateCompany(string name)
        {
            Company company = new Company();
            DateTimeHelper dateTimeHelper = new DateTimeHelper();
            company.Name = name;
            company.FoundationDate = dateTimeHelper.GenerateRandomDate();
            Company Id = new Company();
            return company;

        }
    }
}