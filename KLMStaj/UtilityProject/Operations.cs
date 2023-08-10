using BusinessProject;
using ModelProject;

namespace UtilityProject
{
    public class Operations
    {
        private List<Company> resultList = new List<Company>();
        public List<Company> LINQOperation(int selectedValue)
        {
            using (var dbContext = new CompanyDbContext())
            {
                switch (selectedValue)
                {
                    case 0:
                        resultList =
                            (from company in dbContext.Companies.ToList()
                             where DateTime.Now.Year - company.FoundationDate.Year <= 10
                             select company).ToList();
                        break;

                    case 1:
                        resultList =
                            (from company in dbContext.Companies.ToList()
                             where company.Name.StartsWith("F", StringComparison.OrdinalIgnoreCase)
                             select company).ToList();
                        break;

                    case 2:
                        resultList =
                       (from company in dbContext.Companies.ToList()
                        where company.Name.Contains("X", StringComparison.OrdinalIgnoreCase) || company.Name.Contains("E", StringComparison.OrdinalIgnoreCase)
                        select company).ToList();
                        break;

                    default:
                        break;
                }
                return resultList;
            }
        }


        private bool ValidateInput(string input, out int number, out int repeatCount)
        {
            number = 0;
            repeatCount = 0;

            string[] inputValues = input.Split(' ');

            if (inputValues.Length != 2)
            {
                return false;
            }

            if (!int.TryParse(inputValues[0], out number) || !int.TryParse(inputValues[1], out repeatCount))
            {
                return false;
            }

            return true;
        }
        public  string? ProcessOperation(int selectedValue, string input)
        {
            AlgorithmHelper algorithmHelper = new AlgorithmHelper();
            string? result = null;

            switch (selectedValue)
            {
                case 0:
                    if (ValidateInput(input, out int number, out int repeatCount))
                    {
                        result = algorithmHelper.CustomAlgorithm(number, repeatCount);
                    }
                    else
                    {
                        result = "CustomAlgorithm için geçersiz girdi biçimi. Beklenen biçim: [sayı] [tekrar sayısı]";
                    }
                    break;
                case 1:
                    if (int.TryParse(input, out int starsNumber))
                    {
                        result = algorithmHelper.PrintStars(starsNumber);
                    }
                    else
                    {
                        result = "PrintStars için geçersiz girdi biçimi. Beklenen biçim: [sayı]";
                    }
                    break;
                case 2:
                    if (int.TryParse(input, out int divideNumber))
                    {
                        result = algorithmHelper.DivideByThree(divideNumber);
                    }
                    else
                    {
                        result = "DivideByThree için geçersiz girdi biçimi. Beklenen biçim: [sayı]";
                    }
                    break;
                case 3:
                    string filePath = input;
                    result = algorithmHelper.CompanyMode(filePath);
                    break;
                default:
                    break;
            }

            return result;
        }

    }
}
