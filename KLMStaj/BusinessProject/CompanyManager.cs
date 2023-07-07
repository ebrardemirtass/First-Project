using ModelProject;

namespace BusinessProject
{
    public class CompanyManager
    {
        public Company CreateCompany(string name)
        {
            Company company = new Company();
            company.Name = name;

            return company;

        }
    }
}